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
    public partial class Form4_roomstate : Form
    {
        static string con = @"Data Source=.\sqlexpress;Initial Catalog=Hotel;Integrated Security=True";
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();

        public Form4_roomstate()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string get_roomInfo = "select state from roomInfo where rnum = " + textBox1.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(get_roomInfo, HotelCon);
            dataset.Clear();
            adapter.Fill(dataset, "table0");
            textBox2.Text = dataset.Tables["table0"].Rows[0][0].ToString();
            if (Convert.ToInt32(textBox2.Text) == 1) 
                textBox2.Text += " 空闲";
            else if (Convert.ToInt32(textBox2.Text) == 2)
                textBox2.Text += " 入住";
            else if (Convert.ToInt32(textBox2.Text) == 3)
                textBox2.Text += " 待清洁";
            else if (Convert.ToInt32(textBox2.Text) == 4)
                textBox2.Text += " 维修";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text== "1 入住"|| textBox2.Text == "2 空闲")
            {
                MessageBox.Show("该房无需进行任何操作", "警告");
                textBox1.Text = textBox2.Text = textBox3.Text = "";
            }
            else
            {
                string update_roomInfo = "update roomInfo set state=1 where rnum = " + textBox1.Text;
                SqlCommand cmd3 = new SqlCommand(update_roomInfo, HotelCon);

                HotelCon.Open();

                cmd3.ExecuteNonQuery();

                HotelCon.Close();

                MessageBox.Show("已完成", "成功");

                textBox1.Text = textBox2.Text = textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
