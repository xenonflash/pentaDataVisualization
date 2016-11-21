/*
 * 由SharpDevelop创建。
 * 用户： ky024810
 * 日期: 2015/8/14
 * 时间: 17:13
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Data;
using System.IO;
using System.Data.OleDb;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace penta_data_visiualization
{
	/// <summary>
	/// Description of readMdb.
	/// </summary>
	public class readMdb
	{
		public readMdb()
		{
			
		}
		
		public static DataTable getDataTable(string Path,string tableName)
		{
            if (!File.Exists(Path))
            {
                MessageBox.Show("can not find History.mdb file");
                return null;
            }
            
			OleDbConnection con=new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source="+Path);
			OleDbDataAdapter da=new OleDbDataAdapter("select * from ["+tableName+"]",con);
			DataTable dt =new DataTable();
			da.Fill(dt);
			return dt;
		}
		
	
		public static DataTable sortLot(DataTable lotInfo_DT,DataTable lotAlarm_DT, DateTime startDate,DateTime endDate)
		{


            try
            {
                var sortedLots = from n in lotInfo_DT.AsEnumerable()
                                 where DateTime.Parse(n.ItemArray[3].ToString()).Ticks >= startDate.Ticks && DateTime.Parse(n.ItemArray[3].ToString()).Ticks <= endDate.Ticks
                                 select n;
                var sortedID = from n in sortedLots
                               select n.ItemArray[0];

                //			 var r=from n in lotAlarm_DT.AsEnumerable()
                //			 	where sortedID.ToArray().Contains(n.ItemArray[0])
                //			 	select n ;
                //			 	
                //			 var sortedJam=from n in r
                //			 	group n by n.ItemArray[2] into J
                //			 	select J.Key;
                //			 
                //			 string msg="";
                //		
                //			foreach (var n in sortedJam) 
                //			{
                //				int sum=0;
                //				
                //				msg+=n.ToString();
                //				
                //			}
                //				MessageBox.Show("done");
                return sortedLots.CopyToDataTable();
                //		
            }
            catch
            {
                MessageBox.Show("no data found during selected date");
                return null;
            }
			 
			
			
			
		}

        public static Series drawDBToChart(DataTable srcDB,Chart srcChart , string X_colum, string Y_Colum,SeriesChartType chartType)
        {
            Series result = new Series();
            if (srcDB != null)
            {
                result.Points.DataBind(srcDB.AsEnumerable(), X_colum, Y_Colum, "");
                result.ChartType = chartType;
                result.IsValueShownAsLabel = true;
                srcChart.ChartAreas[0].AxisX.Interval = 1;
                srcChart.Series[0] = result;
            }
           
            return result;
        }


        public static void writeDTtoCSV(DataTable dt)
        {
            
            if (dt == null)
            {
                MessageBox.Show("empty file");
                return;
            }
            SaveFileDialog sa = new SaveFileDialog();
            sa.DefaultExt = "CSV";
            if (sa.ShowDialog() != DialogResult.Cancel && sa.FileName != "")
            {
                try
                {
                    StreamWriter writer = new StreamWriter(sa.FileName);
                    string expTxt = "";
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        expTxt += dt.Columns[i].ColumnName + ",";
                    }
                    expTxt += "\n";

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            expTxt += dt.Rows[i].Field<object>(j).ToString() + ",";
                        }
                        expTxt += "\n";
                    }
                    writer.Write(expTxt);
                    writer.Close();
                    writer.Dispose();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;
                  
                }
                
               
                



            }

        }
		
		
	}
}
