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
        static string con = @"Data Source=.\sqlexpress;Initial Catalog=Hotel;Integrated Security=True";
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();
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
                int temp = comboBox2.Items.IndexOf(dataset.Tables["table0"].Rows[0][0].ToString());
                if (temp >= 0)
                    comboBox2.Text = comboBox2.Items[temp].ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query2 = "select price from typeInfo where type = '" + comboBox2.SelectedItem + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query2, HotelCon);
            dataset.Clear();
            adapter.Fill(dataset, "table1");
            textBox4.Text = dataset.Tables["table1"].Rows[0][0].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            roomInfo r = new roomInfo();
            r.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control C in Controls)
            {
                if (C is ComboBox || C is TextBox)
                    C.Text = "";
                else if (C is GroupBox)
                    foreach (Control C1 in C.Controls)
                        if (C1 is ComboBox || C1 is TextBox)
                            C1.Text = "";
            }
        }
    }
}
