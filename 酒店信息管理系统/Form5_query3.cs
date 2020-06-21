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
    public partial class Form5_query3 : Form
    {
        public Form5_query3()
        {
            InitializeComponent();
        }

        static string con = Program.connect;
        SqlConnection HotelCon = new SqlConnection(con);

        private void Form5_query3_Load(object sender, EventArgs e)
        {
            string str1 = "select * from room_current";
            SqlDataAdapter adapter = new SqlDataAdapter(str1, HotelCon);
            DataTable table_room = new DataTable();
            adapter.Fill(table_room);
            dataGridView1.DataSource = table_room;
        }

    }
}
