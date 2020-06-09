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
    public partial class Form_home : Form
    {
        static string con = @"Data Source=.\sqlexpress;Initial Catalog=Hotel;Integrated Security=True";
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();
        public Form_home()
        {
            InitializeComponent();
        }

        private void 入住登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                this.panel1.Controls.Clear();//点击按钮，先清空panel里的内容
                Form2_checkin form2 = new Form2_checkin { TopLevel = false, FormBorderStyle = FormBorderStyle.None };//要添加的Form不显示窗体头和边框
                this.panel1.Controls.Add(form2);//把form里的内容添到panel中
                form2.Show();//显示内容 
            }
        }

        private void 退房登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                this.panel1.Controls.Clear();
                Form3_checkout form3 = new Form3_checkout { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                this.panel1.Controls.Add(form3);
                form3.Show();
            }
        }

        private void 房态管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 入住记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                this.panel1.Controls.Clear();
                Form5_query1 form51 = new Form5_query1 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                this.panel1.Controls.Add(form51);
                form51.Show();
            }
        }

        private void 往期账目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                this.panel1.Controls.Clear();
                Form5_query2 form52 = new Form5_query2 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                this.panel1.Controls.Add(form52);
                form52.Show();
            }
        }

        private void 房间设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                this.panel1.Controls.Clear();
                Form6_roomset1 form61 = new Form6_roomset1 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                this.panel1.Controls.Add(form61);
                form61.Show();
            }
        }

        private void 房价设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                this.panel1.Controls.Clear();
                Form6_roomset2 form62 = new Form6_roomset2 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                this.panel1.Controls.Add(form62);
                form62.Show();
            }
        }

        private void 强制命令ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string getEmployee = "select enum, position, username, password from employee";
            SqlDataAdapter adapter = new SqlDataAdapter(getEmployee, HotelCon);
            dataset.Clear();
            adapter.Fill(dataset, "employee");

            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                bool admin = false;
                for (int i = 0; i < dataset.Tables["employee"].Rows.Count; i++)
                {
                    string num = dataset.Tables["employee"].Rows[i][0].ToString().Trim();
                    string position = dataset.Tables["employee"].Rows[i][1].ToString().Trim();
                    if (Program.currentId==num && (position == "总经理" || position == "管理员"))
                    {
                        admin = true;
                        panel1.Controls.Clear();
                        forceManage fm = new forceManage { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                        panel1.Controls.Add(fm);
                        fm.Show();
                        break;
                    }
                }
                if (!admin)
                {
                    this.panel1.Controls.Clear();
                    adminLogin al = new adminLogin();
                    al.ShowDialog(this);
                }
            }
        }

        private void 维修检修ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                this.panel1.Controls.Clear();
                Form4_roomstate form4 = new Form4_roomstate { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                this.panel1.Controls.Add(form4);
                form4.Show();
            }
        }

        private void Form_home_Load(object sender, EventArgs e)
        {
            if (Program.currentId != "") 
            {
                button1.Visible = false;
                button1.Enabled = false;
                button2.Visible = true;
                button2.Enabled = true;
                label1.Text = "工号：" + Program.currentId;
            }
            else
            {
                button1.Visible = true;
                button1.Enabled = true;
                button2.Visible = false;
                button2.Enabled = false;
                label1.Text = "状态：未登录";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login l = new login();
            if (l.ShowDialog() == DialogResult.OK)
                Form_home_Load(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.currentId = "";
            MessageBox.Show("退出登录成功");
            panel1.Controls.Clear();
            Form_home_Load(null, null);
        }

        private void 首页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form_home_Load(null, null);
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
