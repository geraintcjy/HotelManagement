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
    public partial class Form8_addservice : Form
    {
        public Form8_addservice()
        {
            InitializeComponent();
        }
        static string con = Program.connect;
        SqlConnection HotelCon = new SqlConnection(con);

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""|| textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("请输入必填信息", "警告");
                return;
            }
            DialogResult dr = MessageBox.Show("确认该条记录？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string str = "insert into service values ('" + textBox1.Text + "','"  + textBox2.Text + "','";
                str += DateTime.Now.ToString() + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                SqlCommand cmd = new SqlCommand(str, HotelCon);
                HotelCon.Open();
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("添加成功！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                HotelCon.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
