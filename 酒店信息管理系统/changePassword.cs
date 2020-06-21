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
    public partial class changePassword : Form
    {
        static string con = Program.connect;
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();
        public changePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != textBox2.Text)
                MessageBox.Show("两次输入的密码不一致", "警告");
            else if (textBox1.Text.Length < 4)
                MessageBox.Show("密码过短", "警告");
            else
            {
                string get_username = "select username from employee";
                string update_password = "update employee set password ='" + textBox1.Text + "' where username = '" + textBox3.Text + "'";
                SqlCommand cmd1 = new SqlCommand(update_password, HotelCon);
                SqlCommand cmd2 = new SqlCommand(get_username, HotelCon);
                SqlDataReader reader;
                bool isUsername = false;
                HotelCon.Open();

                reader = cmd2.ExecuteReader();
                bool anomaly = false;
                try
                {
                    while (reader.Read())
                        if (reader.GetValue(0).ToString().Trim() == textBox3.Text)
                        {
                            isUsername = true;
                            break;
                        }
                    reader.Close();

                    if (isUsername) 
                        cmd1.ExecuteNonQuery();
                    else
                    {
                        MessageBox.Show("该用户名不存在", "警告");
                        anomaly = true;
                    }
                }
                catch (Exception ex)
                {
                    anomaly = true;
                    MessageBox.Show(ex.ToString(), "警告");
                }

                HotelCon.Close();

                if (!anomaly)
                {
                    MessageBox.Show("已完成,请用新密码登录", "成功");
                    Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
