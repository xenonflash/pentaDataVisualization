/*
 * 由SharpDevelop创建。
 * 用户： ykc
 * 日期: 2015/4/11
 * 时间: 12:10
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace penta_data_visiualization
{
	/// <summary>
	/// Description of StructClass.
	/// </summary>
	public class StructClass
	{
		public StructClass()
		{
		}
	}
	
	public struct JamInfo
	{
		public string jamName;
		public int count;
		public JamInfo(string name,int count)
		{
			this.jamName=name;
			this.count=count;
		}
	}

    public struct jamWithDownTime
    {
        public string jamName;
        public double downSec;
        public jamWithDownTime(string name, double sec)
        {
            jamName = name;
            downSec = sec ;
        }
    }
	
	
	
}
