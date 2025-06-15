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
    public partial class Employee_Department_Management : Form
    {
        public Employee_Department_Management()
        {
            InitializeComponent();
            leave_date_picker.Value = new DateTime(2099, 12, 31);
        }
        string employeeid = ""; //定义全局变量，用于存储员工编号
        string departmentid = ""; //定义全局变量，用于存储部门编号
        string em_deptid = ""; //定义全局变量，用于存储隶属关系编号
        private void Employee_Department_Management_Load(object sender, EventArgs e)
        {
            DataBind_Information(); //加载信息
        }
        protected void DataBind_Information()
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
                myitem.SubItems.Add(dr["hire_date"].ToString()); //第 4 列，入职日期
                lv_Employee.Items.Add(myitem); //将新建项添加到 ListView 控件中
            }
            conn.Open();
            string sstr = "select * from Department";
            MySqlDataAdapter daa = new MySqlDataAdapter(sstr, conn);
            DataTable dtt = new DataTable();
            daa.Fill(dtt);
            conn.Close();
            lv_department.Items.Clear(); //先清空列表视图控件中现有行
            foreach (DataRow dr in dtt.Rows)
            {
                ListViewItem myitem_1 = new ListViewItem(dr["dept_no"].ToString()); // 创 建 一 个ListViewItem 项，并为第 1 列赋值，部门编号
                myitem_1.SubItems.Add(dr["dept_name"].ToString()); //第 2 列，部门名
                myitem_1.SubItems.Add(dr["dept_peoplecount"].ToString()); //第 3 列，部门人数
                lv_department.Items.Add(myitem_1); //将新建项添加到 ListView 控件中
            }
            conn.Open();
            string ssstr = "select * from employee_department";
            MySqlDataAdapter daaa = new MySqlDataAdapter(ssstr, conn);
            DataTable dttt = new DataTable();
            daaa.Fill(dttt);
            conn.Close();
            lv_em_dept.Items.Clear(); //先清空列表视图控件中现有行
            foreach (DataRow dr in dttt.Rows)
            {
                ListViewItem myitem_2 = new ListViewItem(dr["ed_id"].ToString()); // 创 建 一 个ListViewItem 项，并为第 1 列赋值，部门编号
                myitem_2.SubItems.Add(dr["emp_no"].ToString()); //第 2 列，部门名
                myitem_2.SubItems.Add(dr["dept_no"].ToString()); //第 3 列，部门编号
                myitem_2.SubItems.Add(dr["Ed_entrydate"].ToString()); //第 4 列，入职日期
                myitem_2.SubItems.Add(dr["Ed_leavedate"].ToString()); //第 4 列，入职日期
                myitem_2.SubItems.Add(dr["Ed_Status"].ToString() == "1" ? "隶属" : "离开"); //第 5 列，当前状态
                lv_em_dept.Items.Add(myitem_2); //将新建项添加到 ListView 控件中
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int eid = (int)nudown_eid.Value;//部门编号
            int did = (int)nudown_did.Value;//部门编号
            DateTime hire_date = hire_date_picker.Value.Date; // 入职日期
            DateTime leave_date = leave_date_picker.Value.Date; // 离职日期
            int status = rbtn_belong.Checked == true ? 1 : 2; //当前状态
            if (eid == 0) //员工编号为0
            {
                lbl_Note.Text = "员工编号不能为0！";
                lbl_Note.ForeColor = Color.Red;
                nudown_eid.Focus();
            }
            if (did == 0) //部门编号为0
            {
                lbl_Note.Text = "部门编号不能为0！";
                lbl_Note.ForeColor = Color.Red;
                nudown_did.Focus();
            }
            else if (lbl_Status.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM employee_department WHERE emp_no = @emp_no AND dept_no = @dept_no";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@emp_no", eid);
                checkCmd.Parameters.AddWithValue("@dept_no", did);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    lbl_Note.Text = "该员工与该部门的关联信息已存在！";
                    lbl_Note.ForeColor = Color.Red;
                    conn.Close();
                    return; // 退出方法  
                }
                string str = string.Format("insert into employee_department (emp_no, dept_no, Ed_entrydate, Ed_leavedate, Ed_Status) values({0},{1},'{2}','{3}',{4})", eid, did, hire_date.ToString("yyyy-MM-dd"), leave_date.ToString("yyyy-MM-dd"), status);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，员工部门隶属信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTexBox(); //调用函数，清空各控件
                    DataBind_Information(); //重新加载员工部门隶属信息
                }
                else
                {
                    lbl_Note.Text = "对不起，员工部门隶属信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
                conn.Open();
                string str = string.Format("update employee_department set emp_no={0},dept_no={1},Ed_entrydate='{2}',Ed_leavedate='{3}',Ed_Status={4} where ed_id={5}", eid, did, hire_date, leave_date, status, em_deptid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，员工部门隶属信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTexBox(); //调用函数，清空各控件
                    DataBind_Information(); //重新加载员工部门隶属信息
                }
                else
                {
                    lbl_Note.Text = "对不起，员工部门隶属信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTexBox()
        {
            nudown_eid.Value = 0;
            nudown_did.Value = 0;
            // 重置日期选择器
            hire_date_picker.Value = DateTime.Now; // 或者设置为 DateTime.MinValue
            leave_date_picker.Value = new DateTime(2099, 12, 31);
            rbtn_belong.Checked = true;
            lbl_Status.Text = "添加";
        }

        private void lv_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Employee.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem = lv_Employee.SelectedItems[0]; //获取选中的第一行（一次只能选一行）
                employeeid = myitem.SubItems[0].Text; //将选中行第 1 列的值赋值全局变量，客户编号
                //入职日期                                                           
                DateTime hireDate;
                if (DateTime.TryParse(myitem.SubItems[3].Text, out hireDate))
                {
                    hire_date_picker.Value = hireDate;
                }
                nudown_eid.Value = decimal.Parse(myitem.SubItems[0].Text); //工号
            }
        }

        private void lv_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_department.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem = lv_department.SelectedItems[0]; //获取选中的第一行（一次只能选一行）
                departmentid = myitem.SubItems[0].Text; //将选中行第 1 列的值赋值全局变量，部门编号
                nudown_did.Value = decimal.Parse(myitem.SubItems[0].Text);
            }
        }

        private void lv_em_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_em_dept.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem = lv_em_dept.SelectedItems[0]; //获取选中的第一行（一次只能选一行）
                em_deptid = myitem.SubItems[0].Text; //将选中行第 1 列的值赋值全局变量，部门编号
                nudown_eid.Value = decimal.Parse(myitem.SubItems[1].Text);
                nudown_did.Value = decimal.Parse(myitem.SubItems[2].Text);
                DateTime hireDate;
                if (DateTime.TryParse(myitem.SubItems[3].Text, out hireDate))
                {
                    hire_date_picker.Value = hireDate;
                }
                // 出生日期
                DateTime leaveDate;
                if (DateTime.TryParse(myitem.SubItems[4].Text, out leaveDate))
                {
                    leave_date_picker.Value = leaveDate;
                }
                rbtn_belong.Checked = myitem.SubItems[5].Text == "隶属" ? true : false; //状态
                rbtn_leave.Checked = myitem.SubItems[5].Text == "离开" ? true : false; //状态 
                lbl_Status.Text = "修改"; //当前状态
            }
        }

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
    }
}
