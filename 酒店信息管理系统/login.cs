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
    public partial class login : Form
    {
        public string currentId = "";
        public bool status = false;

        static string con = Program.connect;
        SqlConnection HotelCon = new SqlConnection(con);
        DataSet dataset = new DataSet();

        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool correct = false;
            for (int i = 0; i < dataset.Tables["employee"].Rows.Count; i++)
            {
                if (textBox1.Text == dataset.Tables["employee"].Rows[i][2].ToString().Trim() && textBox2.Text == dataset.Tables["employee"].Rows[i][3].ToString().Trim()) 
                {
                    currentId = dataset.Tables["employee"].Rows[i][0].ToString();
                    status = true;
                    correct = true;
                    break;
                }
            }
            if (correct)
            {
                
                MessageBox.Show("登录成功", "提示");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误", "提示");
                textBox1.Text = textBox2.Text = "";
            }
            
        }

        private void login_Load(object sender, EventArgs e)
        {
            string getEmployee = "select enum, position, username, password from employee";
            SqlDataAdapter adapter = new SqlDataAdapter(getEmployee, HotelCon);
            dataset.Clear();
            adapter.Fill(dataset, "employee");
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (status)
            {
                Program.currentId = currentId;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
            adminLogin am = new adminLogin(2);
            am.ShowDialog(this);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
