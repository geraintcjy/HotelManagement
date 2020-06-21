using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 酒店信息管理系统
{
    public partial class Form_home : Form
    {
        public Form_home()
        {
            InitializeComponent();
        }

        private void 入住登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();//点击按钮，先清空panel里的内容
            Form2_checkin form2 = new Form2_checkin { TopLevel = false, FormBorderStyle = FormBorderStyle.None };//要添加的Form不显示窗体头和边框
            this.panel1.Controls.Add(form2);//把form里的内容添到panel中
            form2.Show();//显示内容 
        }

        private void 退房登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form3_checkout form3 = new Form3_checkout { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form3);
            form3.Show();
        }

        private void 房态管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form4_roomstate form4 = new Form4_roomstate { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form4);
            form4.Show();
        }

        private void 入住记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form5_query1 form51 = new Form5_query1 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form51);
            form51.Show();
        }

        private void 往期账目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form5_query2 form52 = new Form5_query2 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form52);
            form52.Show();
        }

        private void 房间设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form6_roomset1 form61 = new Form6_roomset1 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form61);
            form61.Show();
        }

        private void 房价设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form6_roomset2 form62 = new Form6_roomset2 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.panel1.Controls.Add(form62);
            form62.Show();
        }

        private void 首页ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
