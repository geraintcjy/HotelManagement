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
    public partial class checkoutConfirm : Form
    {

        private Form3_checkout f3;
        public checkoutConfirm(Form3_checkout form3)
        {
            InitializeComponent();
            f3=form3;
        }

        static string con = Program.connect;
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();

        private void checkoutConfirm_Load(object sender, EventArgs e)
        {
            dataset.Clear();
            string sql = "select CONVERT(varchar(100), indate, 23), CONVERT(varchar(100), GETDATE(), 23), DATEDIFF(DAY,record.indate,getdate()) as 居住天数, price";
            sql += " from record where record.id='" + f3.textBox2.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(dataset, "table0");
            label7.Text = f3.comboBox1.Text;
            label8.Text = f3.textBox1.Text;
            label9.Text = f3.textBox2.Text;
            label10.Text = f3.textBox3.Text;
            label11.Text = dataset.Tables["table0"].Rows[0][0].ToString();
            label12.Text = dataset.Tables["table0"].Rows[0][1].ToString();
            int room_fee = int.Parse(dataset.Tables["table0"].Rows[0][3].ToString());
            string sql2 = "select sum(price) from service where rnum='" + label7.Text + "' and";
            sql2 += " DATEDIFF(DAY," + label11.Text + ",time) >=0";
            sql2 += " and DATEDIFF(DAY,time,"+label12.Text+") <=0";
            adapter = new SqlDataAdapter(sql2, con);
            adapter.Fill(dataset, "table1");
            int service_fee=0;
            if (dataset.Tables["table1"].Rows[0][0].ToString() != "")
                service_fee = int.Parse(dataset.Tables["table1"].Rows[0][0].ToString());

            label14.Text = room_fee.ToString();
            label16.Text = service_fee.ToString();
            label18.Text = (room_fee + service_fee).ToString();

           // label14.Text =;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //将 record 中 outdate  upadte
            //将 roominfo 中 房间状态进行 更改
            //删除 顾客信息string delete_cus = "delete from guestInfo where id='" + label9.Text + "'";
            string update_rec="update record set outdate = GETDATE() where rnum='"+label7.Text+"'";
            update_rec += " and dnum=(select max(dnum) from record where rnum='" + label7.Text + "')";
            string update_room = "update roomInfo set state = 3 where rnum='" + label7.Text + "'";

            //SqlCommand cmd1 = new SqlCommand(delete_cus, HotelCon);
            SqlCommand cmd2 = new SqlCommand(update_rec, HotelCon);
            SqlCommand cmd3 = new SqlCommand(update_room, HotelCon);

            HotelCon.Open();

            try
            {
                //cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "警告");
            }

            HotelCon.Close();

            MessageBox.Show("已完成", "成功");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
