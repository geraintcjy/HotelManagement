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
    public partial class Form8_getservice : Form
    {
        public Form8_getservice()
        {
            InitializeComponent();
        }
        static string con = Program.connect;
        SqlConnection HotelCon = new SqlConnection(con);

        private void Form8_getservice_Load(object sender, EventArgs e)
        {
            string str0 = "select rnum '房间号',enum '服务人员',time '时间',type'服务名',note'备注',price '价格' from service";
            SqlDataAdapter adapter = new SqlDataAdapter(str0, HotelCon);
            DataTable table_service = new DataTable();
            adapter.Fill(table_service);
            dataGridView1.DataSource = table_service;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                string str1 = "select rnum '房间号',enum '服务人员',time '时间',type'服务名',note'备注',price '价格' from service where rnum='" + textBox1.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(str1, HotelCon);
                DataTable table_service = new DataTable();
                adapter.Fill(table_service);
                dataGridView1.DataSource = table_service;
            }
            else if (radioButton2.Checked == true)
            {
                string str1 = "select rnum '房间号',enum '服务人员',time '时间',type'服务名',note'备注',price '价格' from service where CONVERT(varchar(100), time, 23)='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(str1, HotelCon);
                DataTable table_service = new DataTable();
                adapter.Fill(table_service);
                dataGridView1.DataSource = table_service;
            }
            else if (radioButton3.Checked == true)
            {
                string str1 = "select rnum '房间号',enum '服务人员',time '时间',type'服务名',note'备注',price '价格' from service where enum='" + textBox3.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(str1, HotelCon);
                DataTable table_service = new DataTable();
                adapter.Fill(table_service);
                dataGridView1.DataSource = table_service;
            }
        }
    }
}
