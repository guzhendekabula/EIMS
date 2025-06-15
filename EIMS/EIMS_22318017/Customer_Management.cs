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
    public partial class Customer_Management : Form
    {
        public Customer_Management()
        {
            InitializeComponent();
        }
        string customerid = ""; //定义全局变量，用于存储客户编号
        private void Customer_Management_Load(object sender, EventArgs e)
        {
            DataBind_Customer(); //加载客户信息
        }
        protected void DataBind_Customer()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
            conn.Open();
            string str = "select * from Customer";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Customer.Items.Clear(); //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["CustomerID"].ToString()); // 创 建 一 个ListViewItem 项，并为第 1 列赋值，客户编号
                myitem.SubItems.Add(dr["CustomerName"].ToString()); //第 2 列，姓名
                myitem.SubItems.Add(dr["Company"].ToString()); //第 3 列，单位
                myitem.SubItems.Add(dr["Sex"].ToString()); //第 4 列，性别
                myitem.SubItems.Add(dr["Telephone"].ToString()); //第 5 列，电话
                myitem.SubItems.Add(dr["Address"].ToString()); //第 6 列，地址
                myitem.SubItems.Add(dr["Age"].ToString()); //第 7 列，年龄
                lv_Customer.Items.Add(myitem); //将新建项添加到 ListView 控件中
            }
        }
        private void btn_Save1_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text.Trim(); //姓名
            string company = txt_Company.Text.Trim(); //公司
            string sex = rbtn_Sex1.Checked == true ? "男" : "女"; //性别
            string age = nudown_Age.Value.ToString(); //年龄
            string telephone = txt_Telephone.Text.Trim(); //电话
            string address = txt_Address.Text.Trim(); //地址
            if (name == "") //姓名为空
            {
                lbl_Note.Text = "姓名不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_Name.Focus();
            }
            else if (company == "") //单位为空
            {
                lbl_Note.Text = "单位不能为空！没有则填无";
                lbl_Note.ForeColor = Color.Red;
                txt_Company.Focus();
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
            else if (lbl_Status.Text == "添加")
            {
                MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
                conn.Open();
                string str = string.Format("insert into Customer (CustomerName, Company, Sex, Age, Telephone, Address) values('{0}','{1}','{2}',{3},'{4}','{5}')", name, company, sex, age, telephone, address);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，客户信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTexBox(); //调用函数，清空各控件
                    DataBind_Customer(); //重新加载客户信息
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
                string str = string.Format("update Customer set CustomerName='{0}',Company='{1}',Sex='{2}',Age={3},Telephone='{4}',Address='{5}' where CustomerID={6}", name, company, sex, age, telephone, address, customerid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，客户信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTexBox(); //调用函数，清空各控件
                    DataBind_Customer(); //重新加载客户信息
                }
                else
                {
                    lbl_Note.Text = "对不起，客户信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTexBox()
        {
            txt_Name.Text = "";
            txt_Company.Text = "";
            txt_Telephone.Text = "";
            txt_Address.Text = "";
            rbtn_Sex1.Checked = true;
            nudown_Age.Value = 0;
            lbl_Status.Text = "添加";
            customerid = "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Name.Text = "";
            txt_Company.Text = "";
            txt_Telephone.Text = "";
            txt_Address.Text = "";
            rbtn_Sex1.Checked = true;
            nudown_Age.Value = 0;
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

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem = lv_Customer.SelectedItems[0]; //获取选中的第一行（一次只能选一行）
                customerid = myitem.SubItems[0].Text; //将选中行第 1 列的值赋值全局变量，客户编号
                txt_Name.Text = myitem.SubItems[1].Text; //第 2 列，姓名
                txt_Company.Text = myitem.SubItems[2].Text; //单位
                rbtn_Sex1.Checked = myitem.SubItems[3].Text == "男" ? true : false; //性别
                rbtn_Sex2.Checked = myitem.SubItems[3].Text == "女" ? true : false; //性别
                nudown_Age.Value = decimal.Parse(myitem.SubItems[6].Text); //年龄
                txt_Telephone.Text = myitem.SubItems[4].Text; //电话
                txt_Address.Text = myitem.SubItems[5].Text; //地址
                lbl_Status.Text = "修改"; //当前状态
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (customerid == "") //如果没有选中要删除的客户信息
            {
                MessageBox.Show("请先选择要删除的客户信息");
            }
            else
            {
                //弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的客户信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)//如果确定删除
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
                    conn.Open();
                    string str = string.Format("delete from Customer where CustomerID={0}", customerid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，客户信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTexBox(); //调用函数，清空各控件
                        DataBind_Customer(); //重新加载客户信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，客户信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
