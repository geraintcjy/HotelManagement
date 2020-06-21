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
using System.Linq.Expressions;

namespace 酒店信息管理系统
{
    public partial class checkinConfirm : Form
    {
        static string con = Program.connect;
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();

        //生成订单号
        public string generateDnum()
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string dnum = date.Substring(0, 4) + date.Substring(5, 2) + date.Substring(8, 2);
            string query2 = "select dnum from record";
            SqlDataAdapter adapter = new SqlDataAdapter(query2, HotelCon);
            dataset.Clear();
            adapter.Fill(dataset, "table0");

            bool[] flag = new bool[1000];

            for (int i = 0; i < dataset.Tables["table0"].Rows.Count; i++)
                if (dataset.Tables["table0"].Rows[i][0].ToString().Substring(0, 8) == dnum)
                    flag[Convert.ToInt32(dataset.Tables["table0"].Rows[i][0].ToString().Substring(8, 3))] = true;

            string num = "001";
            for (int i = 1; i < 1000; i++)
            {
                if (!flag[i])
                {
                    if (i < 10)
                        num = "00" + i.ToString();
                    else if (i < 100)
                        num = "0" + i.ToString();
                    else
                        num = i.ToString();
                    break;
                }
            }


            return (dnum + num);
        }

        private Form2_checkin f2;

        public checkinConfirm(Form2_checkin form2)
        {
            InitializeComponent();
            f2=form2;
        }

        private void checkinConfirm_Load(object sender, EventArgs e)
        {
            label9.Text = generateDnum();
            label2.Text = f2.textBox1.Text;
            label3.Text = f2.textBox2.Text;
            label5.Text = f2.textBox3.Text;
            int cost = Convert.ToInt32(f2.textBox4.Text) * Convert.ToInt32(f2.textBox5.Text);
            label7.Text = cost.ToString();
            label11.Text = (Convert.ToInt32(f2.textBox7.Text) - cost).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string com1, com2;
            if (f2.textBox9.Text != "")
                com1 = "'" + f2.textBox9.Text + "'";
            else
                com1 = "NULL";
            if (f2.textBox10.Text != "")
                com2 = "'" + f2.textBox10.Text + "'";
            else
                com2 = "NULL";

            string insert_guestInfo = "insert into guestInfo values ('" + f2.textBox2.Text + "','" + f2.textBox1.Text + "','" 
                                    + f2.comboBox1.Text + "','" + f2.textBox8.Text + "')";
            insert_guestInfo = "if not exists (select 1 from guestInfo where id='"+f2.textBox2.Text+"') " + insert_guestInfo;
            string insert_record = "insert into record (dnum, rnum, id, indate,outdate, days, price, pledge, companion1Id, companion2Id) values('"
                                    + label9.Text + "','" + label5.Text + "','" + f2.textBox2.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd")
                                    + "',NULL," + f2.textBox5.Text + "," + label7.Text + "," + label11.Text + "," + com1 + "," + com2 + ")";
            string update_roomInfo = "update roomInfo set state = 2 where rnum = " + label5.Text;

            SqlCommand cmd1 = new SqlCommand(insert_guestInfo, HotelCon);
            SqlCommand cmd2 = new SqlCommand(insert_record, HotelCon);
            SqlCommand cmd3 = new SqlCommand(update_roomInfo, HotelCon);

            HotelCon.Open();

            bool anomaly = false;
            try
            {
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                anomaly = true;
                MessageBox.Show(ex.ToString(), "警告");
            }
            if (!anomaly)
                MessageBox.Show("已完成", "成功");

            HotelCon.Close();
            Close();
        }
    }
}
