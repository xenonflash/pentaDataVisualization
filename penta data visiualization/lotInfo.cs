/*
 * 由SharpDevelop创建。
 * 用户： ky024810
 * 日期: 2015/8/16
 * 时间: 15:28
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace penta_data_visiualization
{
	/// <summary>
	/// Description of lotInfo.
	/// </summary>
	public partial class lotInfo : Form
	{
		public lotInfo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void LotInfoLoad(object sender, EventArgs e)
		{
			textBox1.Text=this.Tag.ToString();
		}
	}
}
