using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIMS_22318017
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        // 新的构造函数，接受员工姓名
        public Main_Form(string em_name)
        {
            InitializeComponent();
            main_name_label.Text = "欢迎员工 "+em_name+" 登录"; // 设置标签的文本为员工姓名
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_main_cancel_Click(object sender, EventArgs e)
        {
            // 弹出确认对话框
            DialogResult result = MessageBox.Show("确定要退出并返回登录页面吗?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 根据用户的选择执行相应操作
            if (result == DialogResult.Yes)
            {
                // 关闭当前 Main_Form 窗体
                this.Close();

                // 显示登录窗体
                Login_Form loginForm = new Login_Form();
                loginForm.Show();
            }
            // 如果用户选择“否”，则不执行任何操作，窗体保持打开状态
        }

        private void btn_customer_management_Click(object sender, EventArgs e)
        {
            //this.Close();
            Customer_Management cm = new Customer_Management();
            cm.Show();
        }

        private void btn_employee_management_Click(object sender, EventArgs e)
        {
            Employee_Management cm = new Employee_Management();
            cm.Show();
        }

        private void btn_dept_management_Click(object sender, EventArgs e)
        {
            Department_Management cm = new Department_Management();
            cm.Show();
        }

        private void btn_emp_dept_management_Click(object sender, EventArgs e)
        {
            Employee_Department_Management cm = new Employee_Department_Management();
            cm.Show();
        }

        private void btn_employee_search_Click(object sender, EventArgs e)
        {
            Search_Employee cm = new Search_Employee();
            cm.Show();

        }
    }
}
