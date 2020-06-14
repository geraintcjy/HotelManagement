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
    public partial class Form6_roomset1 : Form
    {
        public Form6_roomset1()
        {
            InitializeComponent();
        }
        static string con = @"Data Source=.\sqlexpress;Initial Catalog=Hotel;Integrated Security=True";
        //static string con = @"Data Source=.;Initial Catalog=Hotel;Integrated Security=True";
        SqlConnection connect = new SqlConnection(con);
        static bool uptate;

        private void Form6_roomset1_Load(object sender, EventArgs e)
        {
            //表格录入数据//
            string str = "select rnum '房间号',type '房间类型',price '房间价格' from roominfo";
            SqlDataAdapter adapter = new SqlDataAdapter(str, connect);
            DataTable table_room = new DataTable();
            adapter.Fill(table_room);
            dataGridView1.DataSource = table_room;
        }

        private void button_alter_Click(object sender, EventArgs e)
        {
            uptate = true;
            groupBox1.Text = "修改房间信息";
            button_OK.Text = "确认修改";
            textBox_rnum.Text = dataGridView1.CurrentCell.Value.ToString();

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            uptate = false;
            groupBox1.Text = "增添房间";
            button_OK.Text = "确认增添";
            textBox_rnum.Clear();
            textBox_price.Clear();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            uptate = true;
            groupBox1.Text = "修改房型信息";
            button_OK.Text = "确认修改";
            int i = dataGridView1.CurrentRow.Index;
            textBox_rnum.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox_type.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox_price.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            //执行更新或添加// 
            int i = dataGridView1.CurrentRow.Index;
            if (uptate)
            {
                //更新//
                string str_update = "update roominfo set type='" + textBox_type.Text + "',price=" + textBox_price.Text + " where rnum='" + textBox_rnum.Text + "'";
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
                string str_insert = "insert into roominfo values ('" + textBox_rnum.Text + "','" + textBox_type.Text + "',1,"+textBox_price.Text+")";
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
            string str = "select rnum '房间号',type '房间类型',price '房间价格' from roominfo";
            SqlDataAdapter adapter1 = new SqlDataAdapter(str, connect);
            DataTable table_room = new DataTable();
            adapter1.Fill(table_room);
            dataGridView1.DataSource = table_room;
        }
    }
}
