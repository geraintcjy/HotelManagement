using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 酒店信息管理系统
{
    public partial class adminLogin : Form
    {
        int sta;
        static string con = Program.connect;
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();

        public adminLogin(int status)
        {
            InitializeComponent();
            sta = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sta == 1)//修改房价状态时的验证
            {
                bool flag = false;
                for (int i = 0; i < dataset.Tables["employee"].Rows.Count; i++)
                {
                    string username = dataset.Tables["employee"].Rows[i][2].ToString().Trim();
                    string password = dataset.Tables["employee"].Rows[i][3].ToString().Trim();
                    string position = dataset.Tables["employee"].Rows[i][1].ToString().Trim();
                    if (textBox1.Text == username && textBox2.Text == password && (position == "总经理" || position == "管理员"))
                    {
                        flag = true;
                        forceManage fm = new forceManage { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                        Form_home fh = (Form_home)Owner;
                        fh.BackgroundImage = Properties.Resources.big;
                        fh.panel1.Controls.Clear();
                        fh.panel1.Controls.Add(fm);
                        fh.changestyle();
                        fm.Show();
                        Close();
                        break;
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("账号或密码错误", "警告");
                    textBox1.Text = textBox2.Text = "";
                }
            }

            if (sta == 2) //修改密码时的验证
            {
                bool flag = false;
                for (int i = 0; i < dataset.Tables["employee"].Rows.Count; i++)
                {
                    string username = dataset.Tables["employee"].Rows[i][2].ToString().Trim();
                    string password = dataset.Tables["employee"].Rows[i][3].ToString().Trim();
                    string position = dataset.Tables["employee"].Rows[i][1].ToString().Trim();
                    if (textBox1.Text == username && textBox2.Text == password && (position == "总经理" || position == "管理员"))
                    {
                        flag = true;
                        changePassword cp = new changePassword { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                        Form_home fh = (Form_home)Owner.Owner;
                        fh.panel1.Controls.Clear();
                        fh.panel1.Controls.Add(cp);
                        fh.BackgroundImage = Properties.Resources.big;
                        fh.changestyle();
                        cp.Show();
                        Close();
                        break;
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("账号或密码错误", "警告");
                    textBox1.Text = textBox2.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminLogin_Load(object sender, EventArgs e)
        {
            string getEmployee = "select enum, position, username, password from employee";
            SqlDataAdapter adapter = new SqlDataAdapter(getEmployee, HotelCon);
            dataset.Clear();
            adapter.Fill(dataset, "employee");
        }
    }
}
