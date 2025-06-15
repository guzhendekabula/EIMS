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
    public partial class Search_Employee : Form
    {
        public Search_Employee()
        {
            InitializeComponent();
            nudown_id.Value = 0;
            nudown_id.Text = null; // 假设 nudown_id 是 NumericUpDown 控件
            txt_FName.Text = string.Empty;
            txt_LName.Text = string.Empty;
            txt_Address.Text = string.Empty;
            txt_Telephone.Text = string.Empty;
            hire_date_picker.Value = new DateTime(1980, 12, 31);// 将日期选择器设置为 null，表示没有选择日期
            end_hire_date_picker.Value = new DateTime(2100, 12, 31);
            birthday_picker.Value = new DateTime(1980, 12, 31);
            end_birthday_picker.Value = new DateTime(2100, 12, 31);
            btn_search_department.Enabled = false;
        }
        string employeeid = ""; //定义全局变量，用于存储员工编号
        string em_name = "";
        private void btn_return_Click(object sender, EventArgs e)
        {
            // 弹出确认对话框
            DialogResult result = MessageBox.Show("确定要退出并返回主页面吗?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 根据用户的选择执行相应操作
            if (result == DialogResult.Yes)
            {
                // 关闭当前 Main_Form 窗体
                this.Close();

                //返回到主页面
            }
            // 如果用户选择“否”，则不执行任何操作，窗体保持打开状态
        }

        private void Search_Employee_Load(object sender, EventArgs e)
        {
            DataBind_Employee(); //加载客户信息
        }
        protected void DataBind_Employee()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
            conn.Open();
            string str = "select * from Employee";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Employee.Items.Clear(); //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["emp_no"].ToString()); // 创 建 一 个ListViewItem 项，并为第 1 列赋值，客户编号
                myitem.SubItems.Add(dr["first_name"].ToString()); //第 2 列，姓名
                myitem.SubItems.Add(dr["last_name"].ToString()); //第 3 列，单位
                myitem.SubItems.Add(dr["gender"].ToString() == "1" ? "男" : "女"); //第 4 列，性别
                myitem.SubItems.Add(dr["hire_date"].ToString()); //第 5 列，入职日期
                myitem.SubItems.Add(dr["birthday"].ToString()); //第 6 列，出生日期
                myitem.SubItems.Add(dr["Address"].ToString()); //第 7 列，地址
                myitem.SubItems.Add(dr["Telephone"].ToString()); //第 8 列，电话
                myitem.SubItems.Add(dr["password"].ToString()); //第 9 列，密码
                lv_Employee.Items.Add(myitem); //将新建项添加到 ListView 控件中
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // 构建查询条件
            string query = "SELECT * FROM Employee WHERE 1=1"; // 使用 1=1 作为查询的起始条件，方便后续添加其他条件

            // 根据用户输入构建查询条件
            if (!string.IsNullOrEmpty(nudown_id.Text))
            {
                query += " AND emp_no LIKE '%" + nudown_id.Text + "%'";
            }
            if (!string.IsNullOrEmpty(txt_FName.Text))
            {
                query += " AND first_name LIKE '%" + txt_FName.Text + "%'";
            }
            if (!string.IsNullOrEmpty(txt_LName.Text))
            {
                query += " AND last_name LIKE '%" + txt_LName.Text + "%'";
            }
            if (rbtn_Sex1.Checked)
            {
                query += " AND gender = '1'";
            }
            else if (rbtn_Sex2.Checked)
            {
                query += " AND gender = '0'";
            }
            if (hire_date_picker.Value != null && end_hire_date_picker.Value != null && hire_date_picker.Value <= end_hire_date_picker.Value)
            {
                query += " AND hire_date BETWEEN '" + hire_date_picker.Value.ToString("yyyy-MM-dd") + "' AND '" + end_hire_date_picker.Value.ToString("yyyy-MM-dd") + "'";
            }
            if (birthday_picker.Value != null && end_birthday_picker.Value != null && birthday_picker.Value <= end_birthday_picker.Value)
            {
                query += " AND birthday BETWEEN '" + birthday_picker.Value.ToString("yyyy-MM-dd") + "' AND '" + end_birthday_picker.Value.ToString("yyyy-MM-dd") + "'";
            }
            if (!string.IsNullOrEmpty(txt_Address.Text))
            {
                query += " AND Address LIKE '%" + txt_Address.Text + "%'";
            }
            if (!string.IsNullOrEmpty(txt_Telephone.Text))
            {
                query += " AND Telephone LIKE '%" + txt_Telephone.Text + "%'";
            }

            // 执行查询并绑定数据到 ListView
            BindDataToListView(query);
        }
        private void BindDataToListView(string query)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306"))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lv_Employee.Items.Clear(); // 先清空列表视图控件中现有行
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem myitem = new ListViewItem(dr["emp_no"].ToString());
                    myitem.SubItems.Add(dr["first_name"].ToString());
                    myitem.SubItems.Add(dr["last_name"].ToString());
                    myitem.SubItems.Add(dr["gender"].ToString() == "1" ? "男" : "女");
                    myitem.SubItems.Add(dr["hire_date"].ToString());
                    myitem.SubItems.Add(dr["birthday"].ToString());
                    myitem.SubItems.Add(dr["Address"].ToString());
                    myitem.SubItems.Add(dr["Telephone"].ToString());
                    myitem.SubItems.Add(dr["password"].ToString());
                    lv_Employee.Items.Add(myitem);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            nudown_id.Value = 0;
            nudown_id.Text = null; // 假设 nudown_id 是 NumericUpDown 控件
            txt_FName.Text = string.Empty;
            txt_LName.Text = string.Empty;
            txt_Address.Text = string.Empty;
            txt_Telephone.Text = string.Empty;
            hire_date_picker.Value = new DateTime(1980, 12, 31);// 将日期选择器设置为 null，表示没有选择日期
            end_hire_date_picker.Value = new DateTime(2100, 12, 31);
            birthday_picker.Value = new DateTime(1980, 12, 31);
            end_birthday_picker.Value = new DateTime(2100, 12, 31);
            rbtn_Sex1.Checked = false;
            rbtn_Sex2.Checked = false;
        }

        private void btn_search_department_Click(object sender, EventArgs e)
        {
            int empId = int.Parse(employeeid);
            Specific_Department mf = new Specific_Department(em_name, empId);
            mf.Show();
        }

        private void lv_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Employee.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem = lv_Employee.SelectedItems[0]; //获取选中的第一行（一次只能选一行）
                employeeid = myitem.SubItems[0].Text; //将选中行第 1 列的值赋值全局变量，客户编号
                em_name = myitem.SubItems[1].Text + myitem.SubItems[2].Text;
                btn_search_department.Enabled = true;
            }
            else
            {
                btn_search_department.Enabled = false;
            }
        }
    }
}
