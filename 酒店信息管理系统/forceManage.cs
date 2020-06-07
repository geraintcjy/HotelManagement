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
    public partial class forceManage : Form
    {
        static string con = @"Data Source=.\sqlexpress;Initial Catalog=Hotel;Integrated Security=True";
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();

        public forceManage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string update_roomInfo = "update roomInfo set state=" + (comboBox1.SelectedIndex + 1).ToString() + " where rnum = " + textBox1.Text;
            SqlCommand cmd3 = new SqlCommand(update_roomInfo, HotelCon);

            HotelCon.Open();

            cmd3.ExecuteNonQuery();

            HotelCon.Close();

            MessageBox.Show("已完成", "成功");

            textBox1.Text = comboBox1.Text = textBox2.Text = "";
        }
    }
}
