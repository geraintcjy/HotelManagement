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
        //static string con = @"Data Source=.\sqlexpress;Initial Catalog=Hotel;Integrated Security=True";
        static string con = @"Data Source=.;Initial Catalog=Hotel;Integrated Security=True";
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();
        private void checkoutConfirm_Load(object sender, EventArgs e)
        {
            dataset.Clear();
            string sql = "select CONVERT(varchar(100), indate, 23), CONVERT(varchar(100), GETDATE(), 23),DATEDIFF(DAY,record.indate,getdate()) as 居住天数,price";
            sql += " from record where record.rnum='" + f3.comboBox1.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(dataset, "table0");
            label7.Text=f3.comboBox1.Text;
            label8.Text=f3.textBox1.Text;
            label9.Text=f3.textBox2.Text;
            label10.Text=f3.textBox3.Text;
            label11.Text = dataset.Tables["table0"].Rows[0][0].ToString();
            label12.Text = dataset.Tables["table0"].Rows[0][1].ToString();
            label14.Text = (int.Parse(dataset.Tables["table0"].Rows[0][2].ToString()) * int.Parse(dataset.Tables["table0"].Rows[0][3].ToString())).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //删除 顾客信息
            //将 record 中 outdate 和 days upadte
            //将 roominfo 中 房间状态进行 更改
            string delete_cus = "delete from guestInfo where id='" + label9.Text + "'";
            string update_rec="update record set outdate=GETDATE(),days=DATEDIFF(day,indate,GETDATE()) where rnum='"+label7.Text+"'";
            string update_room = "update roomInfo set state=1 where rnum='" + label7.Text + "'";


            SqlCommand cmd1 = new SqlCommand(delete_cus, HotelCon);
            SqlCommand cmd2 = new SqlCommand(update_rec, HotelCon);
            SqlCommand cmd3 = new SqlCommand(update_room, HotelCon);

            HotelCon.Open();

            try
            {
                cmd1.ExecuteNonQuery();
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
