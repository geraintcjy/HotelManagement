﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 酒店信息管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_home());
        }

        public static string currentId = "";
        public static string connect =@"Data Source=.;Initial Catalog=Hotel;Integrated Security=True";
        //public static string connect = @"Data Source=.\sqlexpress;Initial Catalog=Hotel;Integrated Security=True";
    }
}
