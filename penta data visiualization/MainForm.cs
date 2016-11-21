/*
 * 由SharpDevelop创建。
 * 用户： ykc
 * 日期: 2015/4/11
 * 时间: 11:30
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using System.Threading;
using System.Xml.Linq;
using System.Data;
namespace penta_data_visiualization
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
         
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		#region		Gloable Value declare
		string[] ori_jamList;//从config中直接读取的 jam列表
		string[]checkedJamList;// 选择列表框 所选后的 jam列表
		JamInfo[] jamSum;
		string alarmPath;
		List<JamInfo[]> jamSumByDay=new List<JamInfo[]>();
        List<int[]> downTime = new List<int[]>();
		List<int[]> topJamCountByDay = new List<int[]>();
		List<int>qtyByDay=new List<int>();
		char seprator='\n';
		StreamReader reader;
        List<string> dateList = new List<string>(); //this list is for line chart X-asix value;
        List<int>MUBA=new List<int>();
      	Series[] bubbleDatas;
      	DateTime now=new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,00,00,00);
      	string dbPath,lotInfo_TBname,oeeInfo_TBname;
      	FileSystemWatcher dog= new  FileSystemWatcher();
      	string lotDetial="";
        string exp_downTime="";//要导出的文本。
      


        //创建委托，用于 file dog 事件发生时调用执行core
        public delegate void runTask(object pa1, object pa2, object pa3);

        public void runCore(object startDate, object endDate, object jamlist)
        {
            
            core((DateTime)startDate, (DateTime)endDate, (string[])jamlist);
        }
    

        #endregion
        void MainFormLoad(object sender, EventArgs e)
		{

            #region read config file add split to arr;
            reader = new StreamReader(Application.StartupPath+"\\35config.ini");
			ori_jamList= reader.ReadToEnd().Replace("\r","").Split('\n');
			clBox1.Items.AddRange(ori_jamList);
			bubbleDatas=new Series[ori_jamList.Length];
            reader.Close();
            reader.Dispose();
            #endregion

            #region read XML config information
            XDocument xDoc = XDocument.Load("config");
           
            alarmPath=xDoc.Element("configuration").Element("alarmPath").Value;
            dbPath=xDoc.Element("configuration").Element("dbPath").Value;
             lotInfo_TBname=xDoc.Element("configuration").Element("lotInfo_TBname").Value;
              oeeInfo_TBname=xDoc.Element("configuration").Element("oeeInfo_TBname").Value;
            #endregion

            #region initiallize file watch dog
            dog.Path=alarmPath;
            dog.NotifyFilter=NotifyFilters.Size|NotifyFilters.FileName|NotifyFilters.DirectoryName|NotifyFilters.CreationTime;
            dog.Filter="*.log";
            dog.EnableRaisingEvents=true;
            dog.Changed+=OnChange;
            dog.Created+=OnCreat;
            #endregion
            label4.Text=alarmPath;
            
            //MessageBox.Show(Application.StartupPath+@"\" +Application.ProductName+".exe.config");
            // add config arr to check list box and set them all checked.
			for (int i = 0; i < clBox1.Items.Count; i++) 
			{
				clBox1.SetItemChecked(i,true);
			}
			
			//get the jam list selected in checklistbox and use for calculation
            checkedJamList = new string[clBox1.CheckedItems.Count];
			
            for (int i = 0; i < clBox1.CheckedItems.Count; i++)
            {
                checkedJamList[i] = clBox1.CheckedItems[i].ToString().Replace("\r", "");//remove the "\r"!!!!!!!!!!!

            }

            // run core() at main form load
            date_StartTime.Value = DateTime.Now.AddDays(-7);
            core(date_StartTime.Value, DateTime.Now, ori_jamList);

			
		}
		
		public void core(DateTime startTime,DateTime endTime,string[] jamList)
		{
				#region initialize vars
				
            //start timer
            
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //参与计算的总天数
            int dateInterval=(int)(endTime-startTime).TotalDays+1;
            dateList.Clear();//clear datelist 
			jamSumByDay.Clear();
            downTime.Clear();
			qtyByDay.Clear();
			MUBA.Clear();
			int firstQTY,lastQty;
		    DateTime time1=startTime;

		    
#endregion
				
					for (int j=0;j<dateInterval;j++)
						    {
                                // if the alarm file of one day not exist continue to next loop
                                if (File.Exists(alarmPath+time1.ToString("yyyyMMdd")+".log"))
								    {
                                    
									    #region calc data(if this file exists)
				                        dateList.Add(time1.ToString("MM-dd"));//add date string to dateList
                                        //Debug.WriteLine(alarmPath+time1.ToString("yyyyMMdd")+".log");

                                         reader=new StreamReader(alarmPath+time1.ToString("yyyyMMdd")+".log");
                                           string jamTxt = reader.ReadToEnd();
                                      
                                            if (jamTxt.Length<=1)//如果alarm文件没有内容，直接跳转到下一天
                                            {
                                                time1 = time1.AddDays(1);
                                                continue;
                                              }
                                                //1.5.0.8 add check box to enable/disable filter#1#2#3 function.
                                                string[] jamToArr = null;
                                                if (chk_mixStation.Checked)
                                            {
                                                jamToArr = jamTxt.Replace("#1", "").Replace("#2", "").Replace("#3", "").Split(seprator);
                                            }
                                            else
                                            {
                                                 jamToArr = jamTxt.Split(seprator);
                                            }
  
                                            //string[] jamToArr=jamTxt.Split(seprator);
										    reader.Close();
                                            reader.Dispose();//close reader 
                    


										    JamInfo[] tempJamCount=new JamInfo[jamList.Length];
                                             int[] singleJamDownTime = new int[jamList.Length];
										    for (int i = 0; i < jamList.Length; i++)//calculate every jam 's count in current alarm file
										    {
											
											    tempJamCount[i].jamName=jamList[i];
											    bubbleDatas[i]=new Series(jamList[i]);
											    tempJamCount[i].count= oneJamCounter(jamToArr,jamList[i],ref bubbleDatas[i],i,ref singleJamDownTime[i]);
									        
										    }

                                        //add current day jam count arr to list;
                                        jamSumByDay.Add(tempJamCount);
                                         downTime.Add(singleJamDownTime);

                    #region  caculate MUBA

                    //caculate current day quantity out and add to qtyByDay list



                                            firstQTY = getMachineCycle(jamToArr);
                                             

                                             lastQty = getMachineCycle(jamToArr.Reverse().ToArray());
                                         //   MessageBox.Show(firstQTY.ToString() + "..." + lastQty.ToString());
                                           
                                            qtyByDay.Add(lastQty - firstQTY);
                   
               			
										    //Debug.WriteLine(time1.ToString()+ " :last:"+lastQty.ToString()+"--first:"+firstQTY.ToString());
										
										    //caculate current day MUBA and add to MUBAbyDay list
										    var currentDayJamCount=
											    from n in tempJamCount
											    select n.count;
										   // MessageBox.Show(currentDayJamCount.Sum().ToString());
											    if(currentDayJamCount.Sum()!=0)
											    {
												    MUBA.Add((lastQty-firstQTY)/currentDayJamCount.Sum());
											    }
											    else
											    {
                                                    //如果一天没有报警，那么当天的跑料数就是MUBA
												    MUBA.Add(lastQty-firstQTY);
											    }
										    #endregion
										
										
										    time1=time1.AddDays(1);
										    Application.DoEvents();

                        #endregion
                                    
                                    }
								else
								    {
									    time1=time1.AddDays(1);
                                          continue;
								    }

							}
                        drawChart();
                        sw.Stop();//update processing time
                        label1.Text =  sw.ElapsedMilliseconds + "ms";
			          


		}
		
	public int oneJamCounter(string[] srcText,string seedText,ref Series bubbleData,double yInBubbleChart,ref int SingleJamDownTime)// calculate one jam message appear frequency in a jam text array
		{
			int count=0;
		
			
			for (int i=0;i<srcText.Length;i++)
			{
			
				if(srcText[i].Contains(seedText))
				{
					count+=1;
                    //收集数据用来生成  jam发生时间 的气泡图
                  // MessageBox.Show(srcText[i].Substring(srcText[i].IndexOf(":") - 2, 8)+"----"+yInBubbleChart.ToString());
					bubbleData.Points.AddXY(DateTime.ParseExact(srcText[i].Substring(srcText[i].IndexOf(":")-2,8),"HH:mm:ss",null),yInBubbleChart);
                    
                    // 累加每个报警当天 一共占用多少时间

                    // MessageBox.Show(srcText[i].Substring(srcText[i].Length - 12, 9));
                   
                       

                        DateTime temp = DateTime.ParseExact(srcText[i].Substring(srcText[i].LastIndexOf(":") - 5, 8), "HH:mm:ss", null);
                        
                        SingleJamDownTime += temp.Second + temp.Minute * 60 + temp.Hour * 3600;
                       // MessageBox.Show(srcText[i].Substring(srcText[i].LastIndexOf(":") - 5, 8));
                        //MessageBox.Show((temp.Second + temp.Minute * 60 + temp.Hour * 3600).ToString());
                    
                 
                }
			 }
			
			return count;
		}
		
	public int oneJamCounter(string[] srcText,string seedText)// calculate one jam message appear frequency in a jam text array
		{
			int count=0;
		
			
			for (int i=0;i<srcText.Length;i++)
			{
			
				if(srcText[i].Contains(seedText))
				{
					count+=1;

				}
			 }
			
			return count;
		}
		
		
        private void drawChart() //draw all charts
		{
		    #region draw the Jam quantity chart
			
			
			    jamSum=new JamInfo[ori_jamList.Length];// sum everyday jam count to a array
			    for (int i = 0; i <jamSumByDay.Count; i++)
			    {
				    for (int j = 0; j < ori_jamList.Length; j++) 
				    {
					    jamSum[j].jamName=jamSumByDay[i][j].jamName;
					    jamSum[j].count+=jamSumByDay[i][j].count;
				    }
			    }

                var orderedJamSum =
                    from n in jamSum
                    orderby n.count descending
                    select n;
            
                
			    var orderedJamSumsOverDays=
				    from n in orderedJamSum
			
				    where n.count>0
				    select n.count;

                if (orderedJamSumsOverDays.Count() == 0)
                {
                    //如果计算的日期区间内没有文件，或者报警数为0，则不进行绘图，防止bug。
               
                    return;
                }
			    chart1.Series[0].Points.DataBindY(orderedJamSumsOverDays.ToArray());
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.ChartAreas[0].BackColor = Color.Gray;
                chart1.ChartAreas[0].AxisX.Interval=1;
                chart1.ChartAreas[0].AxisX.IntervalAutoMode=IntervalAutoMode.VariableCount;
                chart1.Legends[0].Enabled = false;


                #region 绘制柏拉图
                Series bolato = new Series();
                double moveSum = 0;
                double[] bolatuData = new double[orderedJamSumsOverDays.ToArray().Length];
                for (int i = 0; i < orderedJamSumsOverDays.ToArray().Length; i++)
                {
                    moveSum = moveSum + orderedJamSumsOverDays.ToArray()[i];
                    bolatuData[i] = Math.Round(moveSum / orderedJamSumsOverDays.Sum(), 3);
                    
                }
                bolato.Points.DataBindY(bolatuData);
                bolato.ChartType = SeriesChartType.Spline;
                bolato.Color = Color.LightGreen;
                bolato.BorderWidth = 2;
                bolato.IsValueShownAsLabel = true;
                bolato.YAxisType=AxisType.Secondary;
                chart1.ChartAreas[0].AxisY2.Maximum = 1;
                if (chart1.Series.Count == 1)
                {
                    chart1.Series.Add(bolato);
                }
                else
                {
                    chart1.Series[1] = bolato;
                }
            #endregion
            #endregion

            #region update checklistbox
            var result2 = 
                    from n in jamSum
                    orderby n.count descending
                    where n.count > 0
                    select n.jamName;


                clBox1.Items.Clear();
                clBox1.Items.AddRange(result2.ToArray());
                for (int i = 0; i < clBox1.Items.Count; i++)
                {
                    clBox1.SetItemChecked(i, true);
                }
            
                //			
                #endregion
			
	   	    #region draw line chart

       int[]tempArr;
       topJamCountByDay.Clear();
   
       foreach (string item in result2)
       {
           tempArr =new int[jamSumByDay.Count];
           for (int i = 0; i < jamSumByDay.Count; i++)
           {

               var tempRe =
                 from n in jamSumByDay[i]
                 where n.jamName.IndexOf(item) >= 0
                 select n.count;
               tempArr[i] = tempRe.ToArray<int>()[0];


           }

           topJamCountByDay.Add(tempArr);
       }    
            chart2.Series.Clear();
            int topCount = 0;
            if (topJamCountByDay.Count <= 7)
            {
                topCount = topJamCountByDay.Count;
            }
            else { topCount = 7; }
		    Series tempSeries;
            for (int i=0;i<topCount;i++)
            {
                tempSeries = new Series();
                tempSeries.Points.DataBindXY(dateList, topJamCountByDay[i]);
                tempSeries.ChartType = SeriesChartType.Spline;
                tempSeries.Name = result2.ToArray()[i];
                tempSeries.ToolTip = result2.ToArray()[i];
                tempSeries.BorderWidth = 2;
                tempSeries.LabelForeColor=Color.White;
                
                chart2.Series.Add(tempSeries);
            }
           //setting line chart property;
            
            chart2.ChartAreas[0].BackColor = Color.FromArgb(70, 70, 70);
            chart2.ChartAreas[0].AxisX.Interval=1;
            chart2.Legends[0].Enabled = false;
            if (topJamCountByDay[0].Max() >= 150)
            {
                chart2.ChartAreas[0].AxisY.Maximum = topJamCountByDay[0].Max();
                chart2.ChartAreas[0].BackColor = Color.Black;

            }
            else
            {
                chart2.ChartAreas[0].AxisY.Maximum = 150;
                chart2.ChartAreas[0].BackColor = Color.Gray;
            }

         

      



    #endregion
                 //highlight the first item in chart
		        if(clBox1.Items.Count>0)
       	         clBox1.SetSelected(0, true);
    
		    #region draw the MUBA chart
		
		    chart_muba.Series[0].Points.DataBindXY(dateList,MUBA);
            chart_muba.ChartAreas[0].AxisY.Maximum = 3000;
            if (MUBA.Max() > 3000)
            {
                chart_muba.ChartAreas[0].AxisY.Maximum = MUBA.Max();
            }




            #endregion

            #region draw jam distribution bubble chart



            chart_bubble.Series.Clear();
             
                chart_bubble.ChartAreas[0].AxisX.Interval = 1;
               // chart_bubble.ChartAreas[0].AxisX.Minimum = 0d;
              //chart_bubble.ChartAreas[0].AxisX.Maximum = 1;
                chart_bubble.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
             
                for (int i = 0; i< bubbleDatas.Length; i++)
            	     {
            		    if (result2.Take(7).Contains(bubbleDatas[i].Name))
            	   	     {
	            		    bubbleDatas[i].ChartType=SeriesChartType.Bubble;;
                       
	            		    bubbleDatas[i].XValueType=ChartValueType.Time;
                       
			          	    chart_bubble.Series.Add(bubbleDatas[i]);
		          	
					    }
            		
                }





                #endregion

            #region  draw down time chart
                #region sum each jam's down time over the days and re-order result
                jamWithDownTime[] downTimeOverDays = new jamWithDownTime[ori_jamList.Length];
                for (int i=0; i<ori_jamList.Length; i++)

                {
                    int tempSum=0;
                    for (int j = 0; j < downTime.Count; j++)
                    {
                        tempSum+=downTime[j][i]; 
                    }
                    downTimeOverDays[i].jamName = ori_jamList[i];
                    downTimeOverDays[i].downSec = tempSum;
                }

            var orderedDownTime = downTimeOverDays.OrderByDescending(a => a.downSec);
            var orderedDownTimeNames = orderedDownTime.Where(a => a.downSec > 0).Select(a => a.jamName);
            var ordereDownTimeSecs = orderedDownTime.Where(a => a.downSec > 0).Select(a => a.downSec);
            
                #endregion

                #region draw total down time of each jam chart 

                chart_downTime.Series[0].Points.DataBindXY(orderedDownTimeNames.ToArray<string>(), ordereDownTimeSecs.ToArray<double>());
                chart_downTime.Series[0].IsValueShownAsLabel = true;
                chart_downTime.ChartAreas[0].AxisX.Interval = 1;
            
                lb_totalDwonTime.Text = "total: " + ordereDownTimeSecs.Sum()/60+" min";

                #endregion

                #region draw average down time of each Jam

                //创建数组用于存放每个jam对应的平均down time 
                jamWithDownTime[] avgDownTimeOfEachJam = new jamWithDownTime[orderedDownTimeNames.Count()];
                for (int i = 0; i < avgDownTimeOfEachJam.Length; i++)
                {

                    //从jam-count 的数据中 选出 固定jam名称所对应的报警数量。
                    var sortedJamCount =
                         from n in orderedJamSum
                         where n.jamName == orderedDownTime.ToArray()[i].jamName
                         select n.count;

                  
                    avgDownTimeOfEachJam[i].jamName = orderedDownTimeNames.ToArray()[i];
                    avgDownTimeOfEachJam[i].downSec = Math.Round(orderedDownTime.ToArray()[i].downSec/sortedJamCount.ToArray()[0],2);
                }
            //将创建的数组选择出来 down time作为 下一步 画图表时 的y轴数据
            var orderedAvgOfEach = avgDownTimeOfEachJam.Select(a => a.downSec);
                  
            
                chart_avgDownTime.Series[0].Points.DataBindXY(orderedDownTimeNames.ToArray(), orderedAvgOfEach.ToArray());
                chart_avgDownTime.Series[0].IsValueShownAsLabel = true;
                chart_avgDownTime.ChartAreas[0].AxisX.Interval = 1;


                #endregion

                #region generate text file to export

                exp_downTime = "Jam,count,totalDT,averageDT" + "\n";

                for (int i = 0; i < orderedDownTimeNames.Count(); i++)
                {
                    exp_downTime += orderedDownTimeNames.ToArray()[i] + "," + ordereDownTimeSecs.ToArray()[i] / orderedAvgOfEach.ToArray()[i]+","+ordereDownTimeSecs.ToArray()[i] + "," + orderedAvgOfEach.ToArray()[i] + '\n';
                }

          

                #endregion

               #endregion
        }

        private void drawDBchart()
        {
            //UPH chart
            readMdb.drawDBToChart((DataTable)dataGrid1.DataSource, chart_UPH, "LOT NUMBER", "UPH", SeriesChartType.Column);
            //test yield chart
            readMdb.drawDBToChart((DataTable)dataGrid1.DataSource, chart_testYield, "LOT NUMBER", "YIELD", SeriesChartType.Column);

            #region  vision yield chart
            DataTable SrcDB =(DataTable)dataGrid1.DataSource;

            List<double> v1Yields = new List<double>();
            List<double> v2Yields = new List<double>();
            List<double> v4Yields = new List<double>();
            List<string> lotNos = new List<string>();
            double v1FailUint,v2FailUint,v4FailUint,quantityOut, quantityIn;

            for (int i = 0; i < SrcDB.Rows.Count; i++)
            {
                //get fail unit of each lot for each vision
                v1FailUint = Convert.ToDouble(SrcDB.Rows[i].Field<string>("VISION 1 FAIL UNIT"));
                v2FailUint = Convert.ToDouble(SrcDB.Rows[i].Field<string>("VISION 2 FAIL UNIT"));
                v4FailUint = Convert.ToDouble(SrcDB.Rows[i].Field<string>("VISION 4 FAIL UNIT"));
                //get quantity in/out of each lot for each vision
                quantityOut = Convert.ToDouble(SrcDB.Rows[i].Field<string>("QUANTITY OUT"));
                quantityIn= Convert.ToDouble(SrcDB.Rows[i].Field<string>("QUANTITY IN"));
                if (ck_netMethod.Checked)
                {
                    v1Yields.Add(Math.Round((1 - ((v1FailUint/2 )/ quantityIn)), 2));
                    v2Yields.Add(Math.Round((1 - ((v2FailUint / 2) / quantityIn)), 2));
                    v4Yields.Add(Math.Round((1 - ((v4FailUint / 2) / quantityIn)), 2));
                }
                else
                {
                    v1Yields.Add(Math.Round((1 - (v1FailUint / quantityOut)), 2));
                    v2Yields.Add(Math.Round((1 - (v2FailUint / quantityOut)), 2));
                    v4Yields.Add(Math.Round((1 - (v4FailUint / quantityOut)), 2));
                }
                
                lotNos.Add(SrcDB.Rows[i].Field<string>("LOT NUMBER"));
            }

            //setup serise on chart
            chart_topYield.Series.Clear();
            for (int i = 0; i < 3; i++)
            {
                chart_topYield.Series.Add(new Series());
                chart_topYield.Series[i].ChartType = SeriesChartType.Spline;
                chart_topYield.Series[i].IsValueShownAsLabel = true;
                chart_topYield.ChartAreas[0].AxisX.Interval = 1;
                chart_topYield.ChartAreas[0].AxisY.Maximum = 1;
                chart_topYield.ChartAreas[0].AxisY.Minimum = 0.7;
                chart_topYield.Series[i].BorderWidth = 2;
            }
            //draw the lot-v1yield  /  lot-v2 yield   /  lot-v4yield to chart
            chart_topYield.Series[0].Points.DataBindXY(lotNos, v1Yields);
            chart_topYield.Series[1].Points.DataBindXY(lotNos, v2Yields);
            chart_topYield.Series[2].Points.DataBindXY(lotNos, v4Yields);


            #endregion
        }


        #region set controls' event
        private void button2_Click(object sender, EventArgs e)
        {
            date_EndTime.Value = date_EndTime.Value.AddDays(-1);
            date_StartTime.Value = date_StartTime.Value.AddDays(-1);
            core(date_StartTime.Value, date_EndTime.Value, ori_jamList);
     
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            date_EndTime.Value = date_EndTime.Value.AddDays(1);
            date_StartTime.Value = date_StartTime.Value.AddDays(1);
            core(date_StartTime.Value, date_EndTime.Value, ori_jamList);
      
        }

		void Btn_lastWeekClick(object sender, EventArgs e)
		{
			date_EndTime.Value = date_StartTime.Value;
            date_StartTime.Value = date_StartTime.Value.AddDays(-7);
            core(date_StartTime.Value, date_EndTime.Value, ori_jamList);
         
		}
		void Btn_nextWeekClick(object sender, EventArgs e)
		{
			date_StartTime.Value = date_EndTime.Value;
			 date_EndTime.Value = date_EndTime.Value.AddDays(7);
            
            core(date_StartTime.Value, date_EndTime.Value, ori_jamList);
       
		}
		void Btn_todayClick(object sender, EventArgs e)
		{
			date_EndTime.Value = DateTime.Now;
			date_StartTime.Value =DateTime.Now;
            core(date_StartTime.Value, date_EndTime.Value, ori_jamList);
         
		}
		void Button1Click(object sender, EventArgs e)
		{
         
            core(date_StartTime.Value, date_EndTime.Value,ori_jamList);
        	
		}
			
			void Btn_goClick(object sender, EventArgs e)
				
		{				
				if (text_inputLot.Text=="") {
					MessageBox.Show("please input lot No.");
					return;
				}
						lotDetial="";
						if (isLotExist(text_inputLot.Text,(DataTable)dataGrid1.DataSource))
						{
							lotInfo Form_lotInfo=new lotInfo();
							Form_lotInfo.Tag=lotDetial;
							Form_lotInfo.ShowDialog();
							
						}	
						else
						{
							MessageBox.Show("lot not found");
						}
					
						
		}
			void Btn_searchAllClick(object sender, EventArgs e)
		{
				
				dataGrid1.DataSource=readMdb.sortLot(readMdb.getDataTable(dbPath,lotInfo_TBname),readMdb.getDataTable(dbPath,"lot alarm"),date_StartTime.Value,date_EndTime.Value);
                    if (dataGrid1.DataSource!=null)
                    {
                        drawDBchart();
                    }
           
                 
				
		}
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            chart_downTime.Series[0].ChartType = (SeriesChartType)numericUpDown1.Value;
            chart_avgDownTime.Series[0].ChartType= (SeriesChartType)numericUpDown1.Value; ;
        }

     

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            var result = op.ShowDialog();
            if (result == DialogResult.OK)
            {
                dbPath = op.FileName;
                dataGrid1.DataSource = readMdb.getDataTable(dbPath, lotInfo_TBname);
                dataGrid2.DataSource = readMdb.getDataTable(dbPath, oeeInfo_TBname);
            }
            else
            {
                MessageBox.Show("no file selected!");
            }
        }
        private void btn_exportDownTime_Click(object sender, EventArgs e)
        {
            SaveFileDialog sa = new SaveFileDialog();
            sa.DefaultExt = "csv";
            sa.ShowDialog();
            StreamWriter writer = new StreamWriter(sa.FileName);
            try
            {
             
                writer.Write(exp_downTime);
            }
            catch
            {
                MessageBox.Show("can not export to file");
            }
            writer.Close();
            writer.Dispose();
        }
        private void tab_history_Click(object sender, EventArgs e)
        {
            dataGrid1.DataSource = readMdb.getDataTable(dbPath, lotInfo_TBname);
            dataGrid2.DataSource = readMdb.getDataTable(dbPath, oeeInfo_TBname);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
        	if ((dataGrid1.DataSource != null)&(dataGrid2.DataSource!=null))
        	return;

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    dataGrid1.DataSource = readMdb.sortLot(readMdb.getDataTable(dbPath, lotInfo_TBname), readMdb.getDataTable(dbPath, "lot alarm"), date_StartTime.Value, date_EndTime.Value);

                    if (dataGrid1.DataSource != null)
                    {
                        drawDBchart();
                    }

                    break;
                case 3:
                    
                    dataGrid2.DataSource = readMdb.getDataTable(dbPath, oeeInfo_TBname);
                    break;


            }

        }



        private void clBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int index = 0; index < clBox1.Items.Count; index++)
            {
                if (clBox1.SelectedIndices.Contains(index))
                {
                    chart1.Series[0].Points[index].Color = Color.FromArgb(255, 150, 150);//when select a item from checklist box,highlight this item from chart1
                    if (index < chart2.Series.Count)
                    {
                        chart2.Series[index].BorderWidth = 7;// when select a item form checklist box,highlight this item from chart2
                        chart2.Series[index].IsValueShownAsLabel = true;
                    }

                }
                else
                {
                    chart1.Series[0].Points[index].Color = Color.Yellow;
                    if (index < chart2.Series.Count)
                    {
                        chart2.Series[index].BorderWidth = 2;// when select a item form checklist box,highlight this item from chart2
                        chart2.Series[index].IsValueShownAsLabel = false;
                    }
                }
            }

        }
        #endregion

        #region dog event define
        public void OnChange(object sender,FileSystemEventArgs e)
        {
            
            runTask newTask = runCore;
            this.BeginInvoke(newTask, new object[] { date_StartTime.Value, date_EndTime.Value, ori_jamList });             
        }

       

        private void btn_exportDB_Click(object sender, EventArgs e)
        {
            readMdb.writeDTtoCSV((DataTable)dataGrid1.DataSource);
           
        }

        public void OnCreat (object sender, FileSystemEventArgs e)
        {
            runTask newTask = runCore;
            this.BeginInvoke(newTask, new object[] { date_StartTime.Value, date_EndTime.Value, ori_jamList });
            
        }


        #endregion

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private bool isLotExist(string lot,DataTable dt)
       {
	       	bool found=false;
	       
	     
	       	foreach (var element in dt.AsEnumerable())
	       	{
	       		if (element.ItemArray[6].ToString()==lot.ToUpper()||element.ItemArray[6].ToString()==lot.ToLower())
	       		{
	       			found=true;
	       			
	       			for (int i=0;i<element.ItemArray.Length;i++)
	       			{
	       				lotDetial+=dt.Columns[i].ColumnName+" : ";
	       				lotDetial+=element.ItemArray[i].ToString()+"\r\n";
	       				
	       			}
	       			
	       			break;
	       		}
	       		
	       	}
	       	return found;
       }

        public static int getMachineCycle (string[] jamArr)
        {
            int result = 0;
            for (int i = 0; i < jamArr.Length; i++)
            {
                if (jamArr[i].IndexOf(";") > 1)
                {
                    result = Convert.ToInt32(jamArr[i].Split(';')[1]);
                    break;
                }
                else
                {
                    continue;
                   
                }
            }

            return result;
       

        }

	}
}
