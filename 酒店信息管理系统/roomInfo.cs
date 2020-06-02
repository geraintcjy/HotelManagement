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
    public partial class roomInfo : Form
    {
        public Dictionary<string, bool> roomStatus = new Dictionary<string, bool>();//记录房间状态
        static string con = @"Data Source=.\sqlexpress;Initial Catalog=Hotel;Integrated Security=True";
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();
        public roomInfo()
        {
            InitializeComponent();
            string query = "select rnum as 房间号,type as 类型, (case state when 1 then '可用' else '不可用' end) as 状态 from roomInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(query, HotelCon);
            adapter.Fill(dataset, "table0");
            dataGridView1.DataSource = dataset.Tables["table0"];
            for (int i = 0; i < dataset.Tables["table0"].Rows.Count; i++)
            {
                if (dataset.Tables["table0"].Rows[i][2].ToString() == "可用")
                    roomStatus.Add(dataset.Tables["table0"].Rows[i][0].ToString(), true);
                else
                    roomStatus.Add(dataset.Tables["table0"].Rows[i][0].ToString(), false);
            }
        }

        private void roomInfo_Load(object sender, EventArgs e)
        {
           
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 单人间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "select rnum as 房间号,type as 类型, (case state when 1 then '可用' else '不可用' end) as 状态 from roomInfo where type = '" + sender.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, HotelCon);
            dataset.Clear();
            adapter.Fill(dataset, "table0");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataset.Tables["table0"];
        }

        private void 双人间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            单人间ToolStripMenuItem_Click(sender, e);
        }

        private void 大床房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            单人间ToolStripMenuItem_Click(sender, e);
        }

        private void 亲子房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            单人间ToolStripMenuItem_Click(sender, e);
        }
    }
}
