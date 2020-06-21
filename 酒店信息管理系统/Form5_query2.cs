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
    public partial class Form5_query2 : Form
    {
        public Form5_query2()
        {
            InitializeComponent();
        }

        static string con = Program.connect;
        SqlConnection HotelCon = new SqlConnection(con);
        bool flag = false;

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                string str1 = "select * from income where 日期='" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(str1, HotelCon);
                DataTable table_account = new DataTable();
                adapter.Fill(table_account);
                dataGridView1.DataSource = table_account;
                flag = false;
            }
        }

        private void button_accounts_Click(object sender, EventArgs e)
        {
            string str2 = "select 日期 ,SUM(总金额) '总金额',SUM(收取房费) '收取房费',SUM(收取押金) '收取押金',SUM(退还押金) '退还押金',SUM(退返房费) '退返房费' from income group by 日期";
            SqlDataAdapter adapter = new SqlDataAdapter(str2, HotelCon);
            DataTable table_account = new DataTable();
            adapter.Fill(table_account);
            dataGridView1.DataSource = table_account;
            flag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //利用视图
            /*string str3 = "select * from income where 日期='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(str3, HotelCon);
            DataTable table_account = new DataTable();
            adapter.Fill(table_account);
            dataGridView1.DataSource = table_account;*/

            //以下是用建立PROC存储过程，用sqlcommand方法获取数据
            SqlCommand cmd = new SqlCommand("get_acc_eachday", HotelCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter date = new SqlParameter("@_date", SqlDbType.Date);
            cmd.Parameters.Add(date);
            date.Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            DataTable table_dailyacc = new DataTable();
            SqlDataReader reader;
            HotelCon.Open();
            {
                reader = cmd.ExecuteReader();
                for (int j=0; j < reader.FieldCount; j++)
                {
                    table_dailyacc.Columns.Add(reader.GetName(j),reader.GetFieldType(j));
                }
                table_dailyacc.BeginLoadData();
                object[] values = new object[reader.FieldCount];
                while (reader.Read())
                {
                    reader.GetValues(values);
                    table_dailyacc.LoadDataRow(values, true);
                }
                reader.Close();
                table_dailyacc.EndLoadData();
            }
            HotelCon.Close();
            dataGridView1.DataSource = table_dailyacc;
        }
    }
}
