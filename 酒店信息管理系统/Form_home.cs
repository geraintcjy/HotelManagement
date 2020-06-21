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
        bool initial = true;
        static string con = Program.connect;
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();

        int off;//off：偏移量
        int timer2count = 0;
        bool reverse = true;//播放顺序

        public Form_home()
        {
            InitializeComponent();
        }

        private void Form_home_Load(object sender, EventArgs e)
        {
            if (initial)
            {
                MessageBox.Show("程序使用的数据库版本默认为非Express版本，若您使用Express版，可以在Program.cs中更改链接设置", "提示");
                initial = false;
            }
            //测试时设置为true，实际运行时设置为false//
            menuStrip1.Visible =true ;
            if (Program.currentId != "")
            {
                button1.Visible = false;
                button1.Enabled = false;
                button2.Visible = true;
                button2.Enabled = true;
                label1.Text = "工号：" + Program.currentId;
                label1.ForeColor = Color.Black;
            }
            else
            {
                button1.Visible = true;
                button1.Enabled = true;
                button2.Visible = false;
                button2.Enabled = false;
                label1.Text = "状态：未登录";
                label1.ForeColor = Color.Red;
            }
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height) / 2);
            Point p4 = new Point(0, 0);
            pictureBox4.Location = p4;
            pictureBox2.Location = new Point(p4.X - 1000, p4.Y);
            pictureBox3.Location = new Point(p4.X - 500, p4.Y);
            pictureBox5.Location = new Point(p4.X + 500, p4.Y);
            pictureBox6.Location = new Point(p4.X + 1000, p4.Y);
            timer1.Enabled = true;
            timer1.Interval = 1;
            panel2.Visible = true;
            panel2.Enabled = true;
            pictureBox1.Visible = true;
            label2.Visible = true;
        }

        public void changestyle()
        {
            timer1.Enabled = false;
            panel2.Visible = false;
            panel2.Enabled = false;
            pictureBox1.Visible = false;
            label2.Visible = false;
        }

        private void 入住登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                changestyle();
                BackgroundImage = Properties.Resources.big;
                panel1.Controls.Clear();//点击按钮，先清空panel里的内容
                Form2_checkin form2 = new Form2_checkin { TopLevel = false, FormBorderStyle = FormBorderStyle.None };//要添加的Form不显示窗体头和边框
                panel1.Controls.Add(form2);//把form里的内容添到panel中
                panel1.BackColor = Color.Transparent;
                form2.Show();//显示内容 
            }
           
        }

        private void 退房登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                changestyle();
                BackgroundImage = Properties.Resources.big;
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
                changestyle();
                BackgroundImage = Properties.Resources.big;
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
                changestyle();
                BackgroundImage = Properties.Resources.big;
                this.panel1.Controls.Clear();
                Form5_query2 form52 = new Form5_query2 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                this.panel1.Controls.Add(form52);
                form52.Show();
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
                        changestyle();
                        BackgroundImage = Properties.Resources.big;
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
                    adminLogin al = new adminLogin(1);
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
                changestyle();
                BackgroundImage = Properties.Resources.big;
                this.panel1.Controls.Clear();
                Form4_roomstate form4 = new Form4_roomstate { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                this.panel1.Controls.Add(form4);
                form4.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login l = new login();
            if (l.ShowDialog(this) == DialogResult.OK)
            {
                Form_home_Load(null, null);
                menuStrip1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.currentId = "";
            MessageBox.Show("退出登录成功","提示");
            panel1.Controls.Clear();
            Form_home_Load(null, null);
        }

        public void 首页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.big;
            BackgroundImage = Properties.Resources.timg2;
            panel1.Controls.Clear();
            Form_home_Load(sender, e);
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 客房设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                changestyle();
                BackgroundImage = Properties.Resources.big;
                this.panel1.Controls.Clear();
                Form6_roomset1 form61 = new Form6_roomset1 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                this.panel1.Controls.Add(form61);
                form61.Show();
            }
        }

        private void 当前房间及住客信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                changestyle();
                BackgroundImage = Properties.Resources.big;
                this.panel1.Controls.Clear();
                Form5_query3 form53 = new Form5_query3 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
                this.panel1.Controls.Add(form53);
                form53.Show();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2count++;
            if (timer2count==20)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
                timer2count = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int d = 4; //步长
            if (off == -500 || off == 0 || off == 500)
            {
                timer2.Enabled = true;
                timer1.Enabled = false;
                if (!reverse) off += d;
                else off -= d;
            }
            else if (off < 1000 && !reverse)
            {
                off += d;
                pictureBox4.Location = new Point(off, 0);
                pictureBox2.Location = new Point(off - 1000, 0);
                pictureBox3.Location = new Point(off - 500, 0);
                pictureBox5.Location = new Point(off + 500, 0);
                pictureBox6.Location = new Point(off + 1000, 0);
            }
            else if (off > -1000 && reverse) 
            {
                off -= d;
                pictureBox4.Location = new Point(off, 0);
                pictureBox2.Location = new Point(off - 1000, 0);
                pictureBox3.Location = new Point(off - 500, 0);
                pictureBox5.Location = new Point(off + 500, 0);
                pictureBox6.Location = new Point(off + 1000, 0);
            }
            else if (off == 1000 || off == -1000)
            {
                timer2.Enabled = true;
                timer1.Enabled = false;
                reverse = !reverse;
                if (off == 1000) off -= d;
                else off += d;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void 添加记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                changestyle();
                BackgroundImage = Properties.Resources.big;
                panel1.Controls.Clear();//点击按钮，先清空panel里的内容
                Form8_addservice form8 = new Form8_addservice { TopLevel = false, FormBorderStyle = FormBorderStyle.None };//要添加的Form不显示窗体头和边框
                panel1.Controls.Add(form8);//把form里的内容添到panel中
                panel1.BackColor = Color.Transparent;
                form8.Show();//显示内容 
            }
        }

        private void 历史记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.currentId == "")
                MessageBox.Show("请先登录", "提示");
            else
            {
                changestyle();
                BackgroundImage = Properties.Resources.big;
                panel1.Controls.Clear();//点击按钮，先清空panel里的内容
                Form8_getservice form8 = new Form8_getservice { TopLevel = false, FormBorderStyle = FormBorderStyle.None };//要添加的Form不显示窗体头和边框
                panel1.Controls.Add(form8);//把form里的内容添到panel中
                panel1.BackColor = Color.Transparent;
                form8.Show();//显示内容
            }
        }
    }
}
