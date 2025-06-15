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
    public partial class Specific_Department : Form
    {
        public Specific_Department()
        {
            InitializeComponent();
        }
        int eid = 0;
        public Specific_Department(string em_name, int employeeid)
        {
            InitializeComponent();
            lbl_name.Text = em_name; // 设置标签的文本为员工姓名
            eid = employeeid;
        }
        private void lbl_count_Click(object sender, EventArgs e)
        {

        }

        private void Specific_Department_Load(object sender, EventArgs e)
        {
            //获得员工的部门信息
            MySqlConnection conn = new MySqlConnection("server=localhost; database=eims_22318017; UID=root; PWD=Kbl10303; port=3306");
            conn.Open();

            // 获取员工的部门编号  
            string str = string.Format("SELECT dept_no FROM employee_department WHERE emp_no={0} AND Ed_Status=1", eid);
            MySqlCommand cmd = new MySqlCommand(str, conn);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // 清空现有的 ListView 项  
            lv_department.Items.Clear();

            // 遍历部门编号，获取部门名称  
            foreach (DataRow dr in dt.Rows)
            {
                int deptNo = Convert.ToInt32(dr["dept_no"]);

                // 使用正确的列名 dept_no 来查询部门名称  
                string deptStr = string.Format("SELECT dept_name FROM department WHERE dept_no={0}", deptNo);
                MySqlCommand deptCmd = new MySqlCommand(deptStr, conn);

                string deptName = deptCmd.ExecuteScalar() as string;

                if (deptName != null)
                {
                    // 创建 ListViewItem，并添加部门 ID 和名称  
                    ListViewItem myitem = new ListViewItem(deptNo.ToString()); // 部门 ID  
                    myitem.SubItems.Add(deptName); // 部门名称  
                    lv_department.Items.Add(myitem); // 添加到 ListView  
                }
            }
            MySqlCommand countCmd = new MySqlCommand("GetEmployeeDepartmentCount", conn);
            countCmd.CommandType = CommandType.StoredProcedure;
            countCmd.Parameters.AddWithValue("@emp_id", eid); // 添加参数  

            // 执行存储过程并获取结果  
            int departmentCount = Convert.ToInt32(countCmd.ExecuteScalar());

            // 将结果赋值给标签  
            lbl_count.Text = departmentCount.ToString(); // 更新标签  
            conn.Close(); // 关闭连接
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 弹出确认对话框
            DialogResult result = MessageBox.Show("确定要退出并返回员工信息查询页面吗?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
