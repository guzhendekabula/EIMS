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
    public partial class Department_Management : Form
    {
        public Department_Management()
        {
            InitializeComponent();
        }
        string departmentid = ""; //定义全局变量，用于存储部门编号
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            int did = (int)nudown_id.Value;//部门编号
            string name = txt_Name.Text.Trim(); //部门名
            int deptCount = int.Parse(lbl_count.Text);//部门人数，默认为0
            if (name == "") //姓名为空
            {
                lbl_Note.Text = "姓名不能为空！";
                lbl_Note.ForeColor = Color.Red;
                nudown_id.Focus();
            }
            if (did == 0) //姓名为空
            {
                lbl_Note.Text = "编号不能为0！";
                lbl_Note.ForeColor = Color.Red;
                txt_Name.Focus();
            }
            else if (lbl_Status.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
                conn.Open();
                string str = string.Format("insert into department values({0},'{1}',{2})", did, name, deptCount);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，部门信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTexBox(); //调用函数，清空各控件
                    DataBind_Department(); //重新加载部门信息
                }
                else
                {
                    lbl_Note.Text = "对不起，部门信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
                conn.Open();
                string str = string.Format("update Department set dept_no={0},dept_name='{1}',dept_peoplecount='{2}' where dept_no={3}", did, name, deptCount, departmentid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，部门信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTexBox(); //调用函数，清空各控件
                    DataBind_Department(); //重新加载客户信息
                }
                else
                {
                    lbl_Note.Text = "对不起，部门信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTexBox()
        {
            txt_Name.Text = "";
            nudown_id.Value = 0;
            lbl_Status.Text = "添加";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_Name.Text = "";
            nudown_id.Value = 0;
            lbl_Status.Text = "添加";
        }

        private void Department_Management_Load(object sender, EventArgs e)
        {
            DataBind_Department(); //加载部门信息
        }
        protected void DataBind_Department()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
            conn.Open();
            string str = "select * from Department";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_department.Items.Clear(); //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["dept_no"].ToString()); // 创 建 一 个ListViewItem 项，并为第 1 列赋值，部门编号
                myitem.SubItems.Add(dr["dept_name"].ToString()); //第 2 列，部门名
                myitem.SubItems.Add(dr["dept_peoplecount"].ToString()); //第 3 列，部门人数
                lv_department.Items.Add(myitem); //将新建项添加到 ListView 控件中
            }
        }

        private void lv_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_department.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem = lv_department.SelectedItems[0]; //获取选中的第一行（一次只能选一行）
                departmentid = myitem.SubItems[0].Text; //将选中行第 1 列的值赋值全局变量，部门编号
                nudown_id.Value = decimal.Parse(myitem.SubItems[0].Text);
                txt_Name.Text = myitem.SubItems[1].Text; //第 2 列，部门名
                lbl_count.Text = myitem.SubItems[2].Text; //第 3 列，部门人数
                lbl_Status.Text = "修改"; //当前状态
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (departmentid == "") //如果没有选中要删除的员工信息
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
                    string str = string.Format("delete from Department where dept_no={0}", departmentid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，部门信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTexBox(); //调用函数，清空各控件
                        DataBind_Department(); //重新加载客户信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，部门信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
