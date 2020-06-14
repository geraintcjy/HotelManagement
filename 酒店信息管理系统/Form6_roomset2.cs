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
    public partial class Form6_roomset2 : Form
    {
        public Form6_roomset2()
        {
            InitializeComponent();
        }
        static string con = @"Data Source=.\sqlexpress;Initial Catalog=Hotel;Integrated Security=True";
        //static string con = @"Data Source=.;Initial Catalog=Hotel;Integrated Security=True";
        SqlConnection connect = new SqlConnection(con);
        static bool uptate;

        private void Form6_roomset2_Load(object sender, EventArgs e)
        {
            //表格录入数据//
            string str = "select type '房间类型',price '价格' from roomtype";
            SqlDataAdapter adapter2 = new SqlDataAdapter(str, connect);
            DataTable table_room = new DataTable();
            adapter2.Fill(table_room);
            dataGridView1.DataSource = table_room;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uptate = true;
            groupBox1.Text = "修改房型信息";
            button_OK.Text = "确认修改";
            textBox_type.Text = dataGridView1.CurrentCell.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uptate = false;
            groupBox1.Text = "增添房型信息";
            button_OK.Text = "确认增添";
            textBox_type.Clear();
            textBox_price.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            uptate = true;
            groupBox1.Text = "修改房型信息";
            button_OK.Text = "确认修改";
            textBox_type.Text = dataGridView1.CurrentCell.Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //执行更新或添加//
            if (uptate)
            {
                //更新//
                string str_update = "update roomtype set type='" + textBox_type.Text + "',price=" + textBox_price.Text + " where type='" + dataGridView1.CurrentCell.Value.ToString() + "'";
                SqlCommand cmd_update = new SqlCommand(str_update, connect);
                connect.Open();
                {
                    try
                    {
                        cmd_update.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                connect.Close();
            }
            else
            {
                //添加//
                string str_insert = "insert into roomtype values ('" + textBox_type.Text + "'," + textBox_price.Text + ")";
                SqlCommand cmd_insert = new SqlCommand(str_insert, connect);
                connect.Open();
                {
                    try
                    {
                        cmd_insert.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                connect.Close();
            }
            //更新表格内容//
            string str = "select type '房间类型',price '价格' from roomtype";
            SqlDataAdapter adapter3 = new SqlDataAdapter(str, connect);
            DataTable table_room = new DataTable();
            adapter3.Fill(table_room);
            dataGridView1.DataSource = table_room;
        }

       
    }
}
