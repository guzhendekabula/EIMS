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
    public partial class Employee_Management : Form
    {
        public Employee_Management()
        {
            InitializeComponent();
        }
        string employeeid = ""; //定义全局变量，用于存储员工编号
        private void btn_Save_Click(object sender, EventArgs e)
        {
            int eid = (int)nudown_id.Value;//工号
            string first_name = txt_FName.Text.Trim(); //姓
            string last_name = txt_LName.Text.Trim(); //名
            DateTime hire_date = hire_date_picker.Value.Date; // 入职日期
            DateTime birthday = birthday_picker.Value.Date; // 出生日期
            int gender = rbtn_Sex1.Checked == true ? 1 : 0; //性别
            string telephone = txt_Telephone.Text.Trim(); //电话
            string address = txt_Address.Text.Trim(); //地址
            string password = txt_password.Text.Trim();//密码
            if (first_name == "") //姓名为空
            {
                lbl_Note.Text = "姓不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_FName.Focus();
            }
            if (last_name == "") //姓名为空
            {
                lbl_Note.Text = "名不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_LName.Focus();
            }
            else if (telephone == "") //电话为空
            {
                lbl_Note.Text = "电话不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_Telephone.Focus();
            }
            else if (address == "") //地址为空
            {
                lbl_Note.Text = "地址不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_Address.Focus();
            }
            else if (password == "") //密码为空
            {
                lbl_Note.Text = "密码不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_password.Focus();
            }
            else if (lbl_Status.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
                conn.Open();
                string str = string.Format("insert into employee values({0},'{1}','{2}',{3},'{4}','{5}','{6}','{7}','{8}')", eid, first_name, last_name, gender, hire_date.ToString("yyyy-MM-dd"), birthday.ToString("yyyy-MM-dd"), address, telephone, password);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，客户信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTexBox(); //调用函数，清空各控件
                    DataBind_Employee(); //重新加载客户信息
                }
                else
                {
                    lbl_Note.Text = "对不起，客户信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
                conn.Open();
                string str = string.Format("update Employee set emp_no='{0}',first_name='{1}',last_name='{2}',gender={3},hire_date='{4}',birthday='{5}', Address='{6}', Telephone='{7}', password='{8}' where emp_no={9}", eid, first_name, last_name, gender, hire_date.ToString("yyyy-MM-dd"), birthday.ToString("yyyy-MM-dd"), address, telephone, password, employeeid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，员工信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTexBox(); //调用函数，清空各控件
                    DataBind_Employee(); //重新加载客户信息
                }
                else
                {
                    lbl_Note.Text = "对不起，员工信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTexBox()
        {
            txt_FName.Text = "";
            txt_LName.Text = "";
            txt_Telephone.Text = "";
            txt_Address.Text = "";
            txt_password.Text = "";

            // 重置日期选择器
            hire_date_picker.Value = DateTime.Now; // 或者设置为 DateTime.MinValue
            birthday_picker.Value = DateTime.Now;
            rbtn_Sex1.Checked = true;
            lbl_Status.Text = "添加";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_FName.Text = "";
            txt_LName.Text = "";
            txt_Telephone.Text = "";
            txt_Address.Text = "";
            txt_password.Text = "";

            // 重置日期选择器
            hire_date_picker.Value = DateTime.Now; // 或者设置为 DateTime.MinValue
            birthday_picker.Value = DateTime.Now;
            rbtn_Sex1.Checked = true;
            lbl_Status.Text = "添加";
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

        private void Employee_Management_Load(object sender, EventArgs e)
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

        private void lv_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Employee.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem = lv_Employee.SelectedItems[0]; //获取选中的第一行（一次只能选一行）
                employeeid = myitem.SubItems[0].Text; //将选中行第 1 列的值赋值全局变量，客户编号
                txt_FName.Text = myitem.SubItems[1].Text; //第 2 列，名
                txt_LName.Text = myitem.SubItems[2].Text; //第 3 列，名
                rbtn_Sex1.Checked = myitem.SubItems[3].Text == "男" ? true : false; //性别
                rbtn_Sex2.Checked = myitem.SubItems[3].Text == "女" ? true : false; //性别 
                //入职日期                                                           
                DateTime hireDate;
                if (DateTime.TryParse(myitem.SubItems[4].Text, out hireDate))
                {
                    hire_date_picker.Value = hireDate;
                }
                // 出生日期
                DateTime birthDate;
                if (DateTime.TryParse(myitem.SubItems[5].Text, out birthDate))
                {
                    birthday_picker.Value = birthDate;
                }
                nudown_id.Value = decimal.Parse(myitem.SubItems[0].Text); //工号
                txt_Address.Text = myitem.SubItems[6].Text; //地址
                txt_Telephone.Text = myitem.SubItems[7].Text; //电话
                txt_password.Text = myitem.SubItems[8].Text; //电话
                lbl_Status.Text = "修改"; //当前状态
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (employeeid == "") //如果没有选中要删除的员工信息
            {
                MessageBox.Show("请先选择要删除的员工信息");
            }
            else
            {
                //弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的员工信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)//如果确定删除
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
                    conn.Open();
                    string str = string.Format("delete from employee where emp_no={0}", employeeid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，员工信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTexBox(); //调用函数，清空各控件
                        DataBind_Employee(); //重新加载客户信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void txt_Telephone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
