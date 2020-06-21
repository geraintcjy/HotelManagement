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
    public partial class Form5_query1 : Form
    {
        public Form5_query1()
        {
            InitializeComponent();
        }

        static string con = Program.connect;
        SqlConnection HotelCon = new SqlConnection(con);
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton_id.Checked == true)
            {
                string str1 = "select dnum '订单号', guestinfo.id '身份证号',name '姓名',indate '入住时间',outdate '离店时间',rnum '入住房间'";
                string str2 = "from guestinfo,record where guestinfo.id=record.id and guestinfo.id='" + textBox1.Text + "' or companion1Id='" + textBox1.Text + "' or companion2Id='"+textBox1.Text+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(str1 + str2, HotelCon);
                DataTable table_record = new DataTable();
                adapter.Fill(table_record);
                dataGridView1.DataSource = table_record;
            }
            else if (radioButton_name.Checked == true)
            {
                string str1 = "select dnum '订单号', guestinfo.id '身份证号',name '姓名',indate '入住时间',outdate '离店时间',rnum '入住房间'";
                string str2 = "from guestinfo,record where guestinfo.id=record.id and guestinfo.name='" + textBox1.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(str1 + str2, HotelCon);
                DataTable table_record = new DataTable();
                adapter.Fill(table_record);
                dataGridView1.DataSource = table_record;
            }
            else if (radioButton_dnum.Checked == true)
            {
                string str1 = "select dnum '订单号', guestinfo.id '身份证号',name '姓名',indate '入住时间',outdate '离店时间',rnum '入住房间'";
                string str2 = "from guestinfo,record where guestinfo.id=record.id and dnum='" + textBox1.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(str1 + str2, HotelCon);
                DataTable table_record = new DataTable();
                adapter.Fill(table_record);
                dataGridView1.DataSource = table_record;
            }
            else if (radioButton_date.Checked == true)
            {
                string str1 = "select dnum '订单号', guestinfo.id '身份证号',name '姓名',indate '入住时间',outdate '离店时间',rnum '入住房间'";
                string str2 = "from guestinfo,record where guestinfo.id=record.id and indate='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(str1 + str2, HotelCon);
                DataTable table_record = new DataTable();
                adapter.Fill(table_record);
                dataGridView1.DataSource = table_record;
            }
        }

        private void Form5_query1_Load(object sender, EventArgs e)
        {
            radioButton_id.Checked = true;
        }
    }
}
