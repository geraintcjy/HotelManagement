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
    public partial class Form3_checkout : Form
    {
        public Form3_checkout()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clearAll()
        {
            foreach (Control C in Controls)
            {
                if (C is ComboBox || C is TextBox)
                    C.Text = "";
            }
        }

        //static string con = @"Data Source=.\sqlexpress;Initial Catalog=Hotel;Integrated Security=True";
        static string con = @"Data Source=.;Initial Catalog=Hotel;Integrated Security=True";
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();
        private void Form3_checkout_Load(object sender, EventArgs e)
        {
            clearAll();
           string query1 = "select rnum from roomInfo where state = 2";
           SqlDataAdapter adapter = new SqlDataAdapter(query1, HotelCon);
           dataset.Clear();
           adapter.Fill(dataset, "table0");
           for(int i=0;i<dataset.Tables["table0"].Rows.Count;i++){
               comboBox1.Items.Add(dataset.Tables["table0"].Rows[i][0]);
           }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                checkoutConfirm cof = new checkoutConfirm(this);
                cof.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择需要退房的房间号，并检查信息是否正确", "警告");
                clearAll();

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            string sql="select name,guestInfo.id,pledge,DATEDIFF(DAY,record.indate,getdate()) as 居住天数";
            sql += " from guestInfo,record where guestInfo.id=record.id and record.rnum='" + comboBox1.SelectedItem + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, HotelCon);
            dataset.Clear();
            adapter.Fill(dataset, "tabel0");
            textBox1.Text = dataset.Tables["tabel0"].Rows[0][0].ToString();
            textBox2.Text = dataset.Tables["tabel0"].Rows[0][1].ToString();
            textBox3.Text = dataset.Tables["tabel0"].Rows[0][2].ToString();
            textBox4.Text = dataset.Tables["tabel0"].Rows[0][3].ToString();
        }
        
    }
}
