/*
 * 由SharpDevelop创建。
 * 用户： ykc
 * 日期: 2015/4/11
 * 时间: 11:30
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace penta_data_visiualization
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpge_1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DateTimePicker date_StartTime;
		private System.Windows.Forms.DateTimePicker date_EndTime;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox clBox1;
		
        
        	
        private System.Windows.Forms.Button btn_yesterday;
        private System.Windows.Forms.Button btn_tomorrow;
        private System.Windows.Forms.Button btn_lastWeek;
        private System.Windows.Forms.Button btn_nextWeek;
        private System.Windows.Forms.Button btn_today;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_muba;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_bubble;
        private System.Windows.Forms.TabPage tab_history;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGrid dataGrid2;
        private System.Windows.Forms.Button btn_SearchLot;
        private System.Windows.Forms.TextBox text_inputLot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_searchAll;
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpge_1 = new System.Windows.Forms.TabPage();
            this.chk_mixStation = new System.Windows.Forms.CheckBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart_bubble = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_muba = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tab_history = new System.Windows.Forms.TabPage();
            this.btn_exportDB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabC_lotHisoryCharts = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart_UPH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ck_netMethod = new System.Windows.Forms.CheckBox();
            this.chart_topYield = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chart_testYield = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_searchAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SearchLot = new System.Windows.Forms.Button();
            this.text_inputLot = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart_avgDownTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_totalDwonTime = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chart_downTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_exportDownTime = new System.Windows.Forms.Button();
            this.date_StartTime = new System.Windows.Forms.DateTimePicker();
            this.date_EndTime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_yesterday = new System.Windows.Forms.Button();
            this.btn_tomorrow = new System.Windows.Forms.Button();
            this.btn_lastWeek = new System.Windows.Forms.Button();
            this.btn_nextWeek = new System.Windows.Forms.Button();
            this.btn_today = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpge_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bubble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_muba)).BeginInit();
            this.tab_history.SuspendLayout();
            this.tabC_lotHisoryCharts.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_UPH)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_topYield)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_testYield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_avgDownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_downTime)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpge_1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tab_history);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(68, 30);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(776, 520);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tpge_1
            // 
            this.tpge_1.BackColor = System.Drawing.Color.DimGray;
            this.tpge_1.Controls.Add(this.chk_mixStation);
            this.tpge_1.Controls.Add(this.chart2);
            this.tpge_1.Controls.Add(this.chart1);
            this.tpge_1.Controls.Add(this.clBox1);
            this.tpge_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpge_1.Location = new System.Drawing.Point(4, 34);
            this.tpge_1.Name = "tpge_1";
            this.tpge_1.Padding = new System.Windows.Forms.Padding(3);
            this.tpge_1.Size = new System.Drawing.Size(768, 482);
            this.tpge_1.TabIndex = 0;
            this.tpge_1.Text = "jam";
            // 
            // chk_mixStation
            // 
            this.chk_mixStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_mixStation.AutoSize = true;
            this.chk_mixStation.Location = new System.Drawing.Point(612, 452);
            this.chk_mixStation.Name = "chk_mixStation";
            this.chk_mixStation.Size = new System.Drawing.Size(89, 20);
            this.chk_mixStation.TabIndex = 3;
            this.chk_mixStation.Text = "Mix station";
            this.chk_mixStation.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.BackColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Gray;
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(3, 254);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Lime,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Aqua,
        System.Drawing.Color.Fuchsia,
        System.Drawing.Color.DodgerBlue,
        System.Drawing.Color.White};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.CustomProperties = "LineTension=0.2";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(606, 232);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart_line";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.WhiteSmoke;
            title1.Name = "Title1";
            title1.ShadowOffset = 1;
            title1.Text = "Top 7 Jam Trend";
            this.chart2.Titles.Add(title1);
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.DimGray;
            chartArea2.Area3DStyle.Inclination = 10;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.PointDepth = 2;
            chartArea2.Area3DStyle.PointGapDepth = 2;
            chartArea2.Area3DStyle.Rotation = 10;
            chartArea2.Area3DStyle.WallWidth = 2;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.InterlacedColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.Title = "count";
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY2.Title = "percent";
            chartArea2.BackColor = System.Drawing.Color.DimGray;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Silver;
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(604, 255);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart_bolatu";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.WhiteSmoke;
            title2.Name = "Title1";
            title2.ShadowOffset = 1;
            title2.Text = "Jam summary ";
            this.chart1.Titles.Add(title2);
            // 
            // clBox1
            // 
            this.clBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clBox1.ForeColor = System.Drawing.Color.Black;
            this.clBox1.FormattingEnabled = true;
            this.clBox1.Location = new System.Drawing.Point(610, 0);
            this.clBox1.Name = "clBox1";
            this.clBox1.Size = new System.Drawing.Size(162, 454);
            this.clBox1.TabIndex = 0;
            this.clBox1.SelectedIndexChanged += new System.EventHandler(this.clBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.chart_bubble);
            this.tabPage2.Controls.Add(this.chart_muba);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "muba";
            // 
            // chart_bubble
            // 
            this.chart_bubble.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_bubble.BackColor = System.Drawing.Color.Gray;
            this.chart_bubble.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.Name = "ChartArea1";
            this.chart_bubble.ChartAreas.Add(chartArea3);
            legend3.AutoFitMinFontSize = 50;
            legend3.DockedToChartArea = "ChartArea1";
            legend3.IsDockedInsideChartArea = false;
            legend3.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend3.Name = "Legend1";
            legend3.ShadowColor = System.Drawing.Color.Silver;
            legend3.ShadowOffset = 1;
            legend3.TextWrapThreshold = 20;
            legend3.Title = "jam name";
            this.chart_bubble.Legends.Add(legend3);
            this.chart_bubble.Location = new System.Drawing.Point(6, 348);
            this.chart_bubble.Name = "chart_bubble";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series3.CustomProperties = "BubbleMinSize=1, BubbleMaxSize=3";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            this.chart_bubble.Series.Add(series3);
            this.chart_bubble.Size = new System.Drawing.Size(979, 279);
            this.chart_bubble.TabIndex = 1;
            this.chart_bubble.Text = "chart_bubble";
            // 
            // chart_muba
            // 
            this.chart_muba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_muba.BackColor = System.Drawing.Color.Gray;
            this.chart_muba.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea4.AxisX.IntervalOffset = 1D;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisX.MajorGrid.LineWidth = 2;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY.MajorGrid.LineWidth = 2;
            chartArea4.AxisY.Maximum = 5000D;
            chartArea4.Name = "ChartArea1";
            this.chart_muba.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart_muba.Legends.Add(legend4);
            this.chart_muba.Location = new System.Drawing.Point(2, 1);
            this.chart_muba.Name = "chart_muba";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.ShadowOffset = 1;
            this.chart_muba.Series.Add(series4);
            this.chart_muba.Size = new System.Drawing.Size(986, 342);
            this.chart_muba.TabIndex = 0;
            this.chart_muba.Text = "chart3";
            // 
            // tab_history
            // 
            this.tab_history.BackColor = System.Drawing.Color.DimGray;
            this.tab_history.Controls.Add(this.btn_exportDB);
            this.tab_history.Controls.Add(this.button2);
            this.tab_history.Controls.Add(this.tabC_lotHisoryCharts);
            this.tab_history.Controls.Add(this.btn_searchAll);
            this.tab_history.Controls.Add(this.label3);
            this.tab_history.Controls.Add(this.btn_SearchLot);
            this.tab_history.Controls.Add(this.text_inputLot);
            this.tab_history.Controls.Add(this.dataGrid1);
            this.tab_history.Location = new System.Drawing.Point(4, 34);
            this.tab_history.Name = "tab_history";
            this.tab_history.Padding = new System.Windows.Forms.Padding(3);
            this.tab_history.Size = new System.Drawing.Size(992, 633);
            this.tab_history.TabIndex = 2;
            this.tab_history.Text = "history";
            // 
            // btn_exportDB
            // 
            this.btn_exportDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exportDB.Location = new System.Drawing.Point(914, 592);
            this.btn_exportDB.Name = "btn_exportDB";
            this.btn_exportDB.Size = new System.Drawing.Size(67, 29);
            this.btn_exportDB.TabIndex = 7;
            this.btn_exportDB.Text = "export mdb";
            this.btn_exportDB.UseVisualStyleBackColor = true;
            this.btn_exportDB.Click += new System.EventHandler(this.btn_exportDB_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(809, 592);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tabC_lotHisoryCharts
            // 
            this.tabC_lotHisoryCharts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabC_lotHisoryCharts.Controls.Add(this.tabPage1);
            this.tabC_lotHisoryCharts.Controls.Add(this.tabPage5);
            this.tabC_lotHisoryCharts.Controls.Add(this.tabPage6);
            this.tabC_lotHisoryCharts.Location = new System.Drawing.Point(6, 249);
            this.tabC_lotHisoryCharts.Name = "tabC_lotHisoryCharts";
            this.tabC_lotHisoryCharts.SelectedIndex = 0;
            this.tabC_lotHisoryCharts.Size = new System.Drawing.Size(990, 338);
            this.tabC_lotHisoryCharts.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart_UPH);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UPH";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart_UPH
            // 
            this.chart_UPH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea5.Name = "ChartArea1";
            this.chart_UPH.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_UPH.Legends.Add(legend5);
            this.chart_UPH.Location = new System.Drawing.Point(6, 6);
            this.chart_UPH.Name = "chart_UPH";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart_UPH.Series.Add(series5);
            this.chart_UPH.Size = new System.Drawing.Size(965, 303);
            this.chart_UPH.TabIndex = 0;
            this.chart_UPH.Text = "chart3";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ck_netMethod);
            this.tabPage5.Controls.Add(this.chart_topYield);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(982, 312);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "vision yield";
            // 
            // ck_netMethod
            // 
            this.ck_netMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ck_netMethod.AutoSize = true;
            this.ck_netMethod.Location = new System.Drawing.Point(866, 257);
            this.ck_netMethod.Name = "ck_netMethod";
            this.ck_netMethod.Size = new System.Drawing.Size(79, 17);
            this.ck_netMethod.TabIndex = 2;
            this.ck_netMethod.Text = "net method";
            this.ck_netMethod.UseVisualStyleBackColor = true;
            // 
            // chart_topYield
            // 
            this.chart_topYield.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea6.Name = "ChartArea1";
            this.chart_topYield.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_topYield.Legends.Add(legend6);
            this.chart_topYield.Location = new System.Drawing.Point(6, 3);
            this.chart_topYield.Name = "chart_topYield";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart_topYield.Series.Add(series6);
            this.chart_topYield.Size = new System.Drawing.Size(968, 305);
            this.chart_topYield.TabIndex = 1;
            this.chart_topYield.Text = "chart3";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chart_testYield);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(982, 312);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "test yield";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chart_testYield
            // 
            this.chart_testYield.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea7.Name = "ChartArea1";
            this.chart_testYield.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart_testYield.Legends.Add(legend7);
            this.chart_testYield.Location = new System.Drawing.Point(9, 5);
            this.chart_testYield.Name = "chart_testYield";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart_testYield.Series.Add(series7);
            this.chart_testYield.Size = new System.Drawing.Size(965, 303);
            this.chart_testYield.TabIndex = 1;
            this.chart_testYield.Text = "chart3";
            // 
            // btn_searchAll
            // 
            this.btn_searchAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_searchAll.Location = new System.Drawing.Point(346, 590);
            this.btn_searchAll.Name = "btn_searchAll";
            this.btn_searchAll.Size = new System.Drawing.Size(67, 29);
            this.btn_searchAll.TabIndex = 4;
            this.btn_searchAll.Text = "Show All";
            this.btn_searchAll.UseVisualStyleBackColor = true;
            this.btn_searchAll.Click += new System.EventHandler(this.Btn_searchAllClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(8, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lot";
            // 
            // btn_SearchLot
            // 
            this.btn_SearchLot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SearchLot.Location = new System.Drawing.Point(273, 589);
            this.btn_SearchLot.Name = "btn_SearchLot";
            this.btn_SearchLot.Size = new System.Drawing.Size(67, 29);
            this.btn_SearchLot.TabIndex = 2;
            this.btn_SearchLot.Text = "Search lot";
            this.btn_SearchLot.UseVisualStyleBackColor = true;
            this.btn_SearchLot.Click += new System.EventHandler(this.Btn_goClick);
            // 
            // text_inputLot
            // 
            this.text_inputLot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_inputLot.Location = new System.Drawing.Point(31, 593);
            this.text_inputLot.Name = "text_inputLot";
            this.text_inputLot.Size = new System.Drawing.Size(220, 20);
            this.text_inputLot.TabIndex = 1;
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(5, 3);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.Size = new System.Drawing.Size(986, 240);
            this.dataGrid1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGrid2);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 633);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "OEE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGrid2
            // 
            this.dataGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid2.DataMember = "";
            this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid2.Location = new System.Drawing.Point(0, 0);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.ReadOnly = true;
            this.dataGrid2.Size = new System.Drawing.Size(992, 632);
            this.dataGrid2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage4.Controls.Add(this.chart_avgDownTime);
            this.tabPage4.Controls.Add(this.lb_totalDwonTime);
            this.tabPage4.Controls.Add(this.numericUpDown1);
            this.tabPage4.Controls.Add(this.chart_downTime);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(992, 633);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "downTime";
            // 
            // chart_avgDownTime
            // 
            this.chart_avgDownTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_avgDownTime.BackColor = System.Drawing.Color.DarkGray;
            chartArea8.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea8.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea8.BorderColor = System.Drawing.Color.LightSalmon;
            chartArea8.Name = "ChartArea1";
            this.chart_avgDownTime.ChartAreas.Add(chartArea8);
            this.chart_avgDownTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chart_avgDownTime.Location = new System.Drawing.Point(6, 324);
            this.chart_avgDownTime.Name = "chart_avgDownTime";
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series8.Name = "Series1";
            this.chart_avgDownTime.Series.Add(series8);
            this.chart_avgDownTime.Size = new System.Drawing.Size(896, 309);
            this.chart_avgDownTime.TabIndex = 3;
            this.chart_avgDownTime.Text = "chart3";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title3.ForeColor = System.Drawing.Color.White;
            title3.Name = "Title1";
            title3.Text = "Average down time of each jam(Seconds)";
            this.chart_avgDownTime.Titles.Add(title3);
            // 
            // lb_totalDwonTime
            // 
            this.lb_totalDwonTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_totalDwonTime.AutoSize = true;
            this.lb_totalDwonTime.Location = new System.Drawing.Point(894, 53);
            this.lb_totalDwonTime.Name = "lb_totalDwonTime";
            this.lb_totalDwonTime.Size = new System.Drawing.Size(35, 13);
            this.lb_totalDwonTime.TabIndex = 2;
            this.lb_totalDwonTime.Text = "label6";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(897, 15);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            34,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // chart_downTime
            // 
            this.chart_downTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_downTime.BackColor = System.Drawing.Color.DarkGray;
            chartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea9.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea9.AxisX.ScrollBar.Enabled = false;
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea9.Name = "ChartArea1";
            this.chart_downTime.ChartAreas.Add(chartArea9);
            this.chart_downTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chart_downTime.Location = new System.Drawing.Point(5, 6);
            this.chart_downTime.Name = "chart_downTime";
            series9.ChartArea = "ChartArea1";
            series9.Name = "Series1";
            this.chart_downTime.Series.Add(series9);
            this.chart_downTime.Size = new System.Drawing.Size(897, 321);
            this.chart_downTime.TabIndex = 0;
            this.chart_downTime.Text = "chart3";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title4.ForeColor = System.Drawing.Color.White;
            title4.Name = "Title1";
            title4.Text = "Down time of each jam(Seconds)";
            this.chart_downTime.Titles.Add(title4);
            // 
            // btn_exportDownTime
            // 
            this.btn_exportDownTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exportDownTime.Location = new System.Drawing.Point(787, 521);
            this.btn_exportDownTime.Name = "btn_exportDownTime";
            this.btn_exportDownTime.Size = new System.Drawing.Size(58, 40);
            this.btn_exportDownTime.TabIndex = 4;
            this.btn_exportDownTime.Text = "export";
            this.btn_exportDownTime.UseVisualStyleBackColor = true;
            this.btn_exportDownTime.Click += new System.EventHandler(this.btn_exportDownTime_Click);
            // 
            // date_StartTime
            // 
            this.date_StartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.date_StartTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_StartTime.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_StartTime.Location = new System.Drawing.Point(4, 528);
            this.date_StartTime.Name = "date_StartTime";
            this.date_StartTime.Size = new System.Drawing.Size(167, 26);
            this.date_StartTime.TabIndex = 1;
            // 
            // date_EndTime
            // 
            this.date_EndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.date_EndTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_EndTime.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_EndTime.Location = new System.Drawing.Point(213, 527);
            this.date_EndTime.Name = "date_EndTime";
            this.date_EndTime.Size = new System.Drawing.Size(161, 26);
            this.date_EndTime.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(410, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // btn_yesterday
            // 
            this.btn_yesterday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_yesterday.Location = new System.Drawing.Point(536, 521);
            this.btn_yesterday.Name = "btn_yesterday";
            this.btn_yesterday.Size = new System.Drawing.Size(58, 40);
            this.btn_yesterday.TabIndex = 5;
            this.btn_yesterday.Text = "<";
            this.btn_yesterday.UseVisualStyleBackColor = true;
            this.btn_yesterday.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_tomorrow
            // 
            this.btn_tomorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_tomorrow.Location = new System.Drawing.Point(661, 521);
            this.btn_tomorrow.Name = "btn_tomorrow";
            this.btn_tomorrow.Size = new System.Drawing.Size(58, 40);
            this.btn_tomorrow.TabIndex = 6;
            this.btn_tomorrow.Text = ">";
            this.btn_tomorrow.UseVisualStyleBackColor = true;
            this.btn_tomorrow.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_lastWeek
            // 
            this.btn_lastWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_lastWeek.Location = new System.Drawing.Point(474, 521);
            this.btn_lastWeek.Name = "btn_lastWeek";
            this.btn_lastWeek.Size = new System.Drawing.Size(58, 40);
            this.btn_lastWeek.TabIndex = 7;
            this.btn_lastWeek.Text = "<<";
            this.btn_lastWeek.UseVisualStyleBackColor = true;
            this.btn_lastWeek.Click += new System.EventHandler(this.Btn_lastWeekClick);
            // 
            // btn_nextWeek
            // 
            this.btn_nextWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_nextWeek.Location = new System.Drawing.Point(723, 521);
            this.btn_nextWeek.Name = "btn_nextWeek";
            this.btn_nextWeek.Size = new System.Drawing.Size(58, 40);
            this.btn_nextWeek.TabIndex = 8;
            this.btn_nextWeek.Text = ">>";
            this.btn_nextWeek.UseVisualStyleBackColor = true;
            this.btn_nextWeek.Click += new System.EventHandler(this.Btn_nextWeekClick);
            // 
            // btn_today
            // 
            this.btn_today.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_today.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_today.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_today.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_today.Location = new System.Drawing.Point(598, 521);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(58, 40);
            this.btn_today.TabIndex = 9;
            this.btn_today.Text = "Today";
            this.btn_today.UseVisualStyleBackColor = false;
            this.btn_today.Click += new System.EventHandler(this.Btn_todayClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(668, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "process: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(668, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(179, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "To";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(732, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "v1.5.0.8";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btn_exportDownTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_today);
            this.Controls.Add(this.btn_nextWeek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_lastWeek);
            this.Controls.Add(this.date_EndTime);
            this.Controls.Add(this.btn_tomorrow);
            this.Controls.Add(this.date_StartTime);
            this.Controls.Add(this.btn_yesterday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "penta data visiualization";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.tabControl1.ResumeLayout(false);
            this.tpge_1.ResumeLayout(false);
            this.tpge_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_bubble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_muba)).EndInit();
            this.tab_history.ResumeLayout(false);
            this.tab_history.PerformLayout();
            this.tabC_lotHisoryCharts.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_UPH)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_topYield)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_testYield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_avgDownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_downTime)).EndInit();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_downTime;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lb_totalDwonTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_avgDownTime;
        private System.Windows.Forms.Button btn_exportDownTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabC_lotHisoryCharts;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_UPH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_topYield;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_testYield;
        private System.Windows.Forms.Button btn_exportDB;
        private System.Windows.Forms.CheckBox ck_netMethod;
        private System.Windows.Forms.CheckBox chk_mixStation;
    }


}

