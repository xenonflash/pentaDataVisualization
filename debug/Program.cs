/*
 * 由SharpDevelop创建。
 * 用户： ky024810
 * 日期: 2015/5/1
 * 时间: 9:59
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace debug
{
	class Program
	{
		public static void Main(string[] args)
		{
            string src = "BBH72 - 2X2.5X.915 ; 42527819 ; 08/16/2014 ; 00:01:50 ; TNR#1 VISION FAIL. ; 00:00:40 ; ";
            string dst = src.Substring(src.LastIndexOf(":") - 5, 8);
           DateTime d= DateTime.ParseExact(dst, "hh:mm:ss", null);
            Console.WriteLine(d.Second);
			Console.ReadKey(true);
		}
	}
}