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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1650391" && textBox2.Text == "123456")
            {
                this.Close();
                forceManage fm = new forceManage { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                Form_home fh = (Form_home)this.Owner;
                fh.panel1.Controls.Add(fm);
                fm.Show();
            }
            else
            {
                MessageBox.Show("账号或密码错误", "警告");
                textBox1.Text = textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
