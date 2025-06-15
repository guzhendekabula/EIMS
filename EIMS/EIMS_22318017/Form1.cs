using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EIMS_22318017
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        //变量设置为公共全局静态变量
        public static string user_account = "";
        public static string user_password = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_login_Click(object sender, EventArgs e)
        {
            // 弹出确认对话框
            DialogResult result = MessageBox.Show("确定要退出程序吗?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 根据用户的选择执行相应操作
            if (result == DialogResult.Yes)
            {
                // 关闭所有窗体并终止应用程序
                Application.Exit();
            }
            // 如果用户选择“否”，则不执行任何操作，窗体保持打开状态
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string str = string.Format("SELECT *, CONCAT(first_name, last_name) AS em_name FROM employee WHERE emp_no='{0}' AND password='{1}'", txt_account.Text, txt_password.Text);
            MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            if (dt.Rows.Count > 0)
            {
                string em_name = dt.Rows[0]["em_name"].ToString();

                // 将用户名和密码设置为静态变量
                user_account = txt_account.Text;
                user_password = txt_password.Text;

                // 创建 Main_Form 实例并传递姓名
                Main_Form mf = new Main_Form(em_name);
                this.Hide();
                mf.Show();
            }
            else
            {
                MessageBox.Show("工号或者密码不正确，请检查并重新输入");
            }
        }
    }
}
