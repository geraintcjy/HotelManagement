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
    public partial class Form2_checkin : Form
    {
        //写placeholder!!!
        static string con = Program.connect;
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();

        public void clearAll()
        {
            foreach (Control C in Controls)
            {
                if (C is ComboBox || C is TextBox)
                    C.Text = "";
                else if (C is GroupBox)
                    foreach (Control C1 in C.Controls)
                    {
                        if (C1 is ComboBox || C1 is TextBox)
                            C1.Text = "";
                        else if (C1 is GroupBox)
                            foreach (Control C2 in C1.Controls)
                                if (C2 is ComboBox || C2 is TextBox)
                                    C2.Text = "";
                    }
            }
        }
        public Form2_checkin()
        {
            InitializeComponent();
        }

        private void Form2_checkin_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                string query1 = "select type from roomInfo where rnum = '" + textBox3.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query1, HotelCon);
                dataset.Clear();
                adapter.Fill(dataset, "table0");
                if (dataset.Tables["table0"].Rows.Count > 0) 
                {
                    int temp = comboBox2.Items.IndexOf(dataset.Tables["table0"].Rows[0][0].ToString());
                    comboBox2.Text = comboBox2.Items[temp].ToString();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query2 = "select price from roomInfo where type = '" + comboBox2.SelectedItem + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query2, HotelCon);
            dataset.Clear();
            adapter.Fill(dataset, "table1");
            textBox4.Text = dataset.Tables["table1"].Rows[0][0].ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text==""|| textBox1.Text == "" || textBox5.Text == "" || textBox4.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("请输入必填信息", "警告");
                return;
            }
            roomInfo ri = new roomInfo();
            if (!ri.roomStatus[textBox3.Text])
            {
                MessageBox.Show("输入的房号有误或房间不可用","警告");
                textBox3.Text = "";
                return;
            }
            checkinConfirm cc = new checkinConfirm(this);
            cc.ShowDialog();
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text=="")
                MessageBox.Show("请输入预期入住天数", "警告");
            else if (textBox4.Text == "")
                MessageBox.Show("请输入房间单价", "警告");
            else
            {
                textBox6.Text = (Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox4.Text) * 2).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            roomInfo r = new roomInfo();
            r.Show();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(this.BackColor);   
        }
    }
}
