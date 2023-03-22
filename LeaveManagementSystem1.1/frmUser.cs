using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveManagementSystem1._1
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        SQLConfig SQL = new SQLConfig();
        usableFunction UF = new usableFunction();
        string query;
        int maxrow;
        private void tstripList_Click(object sender, EventArgs e)
        {
            Panel1.BringToFront();
            Panel1.Dock = DockStyle.Fill;
            Panel2.SendToBack();
            Panel2.Dock = DockStyle.None;
            query = "SELECT user_id as Id,name as Name,username as Username, type as Type FROM  tbluser  ";
            SQL.Load_DTG(query, dtglist);

            UF.clearTxt(GroupBox1);
            SQL.autonumber("user", txtId);

            txtId.Enabled = false; 
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            tstripList_Click(sender, e);
        }

        private void tstripAdd_Click(object sender, EventArgs e)
        {
            Panel2.BringToFront();
            Panel2.Dock = DockStyle.Fill;
            Panel1.SendToBack();
            Panel1.Dock = DockStyle.None;


            UF.clearTxt(GroupBox1);
            SQL.autonumber("user", txtId);

            lblTitle.Text = "Add New User";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in GroupBox1.Controls)
            {
                if(ctrl is TextBox)
                {
                    if(ctrl.Text == "")
                    {
                        MessageBox.Show("One of the box is empty. It needed to be filled up.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            foreach (Control ctrl in GroupBox1.Controls)
            {
                if (ctrl is ComboBox)
                {
                    if (ctrl.Text == "----Select-----")
                    {
                        MessageBox.Show("You have to set the correct information.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            } 
            if(txtpass.Text != txtrpass.Text)
            {
                MessageBox.Show("Password does not match.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            query = "SELECT * FROM tbluser WHERE user_id=" + txtId.Text ;
            maxrow = SQL.maxrow(query);

            if(maxrow > 0)
            {
                query = "UPDATE tbluser SET name='" + txtname.Text + "' ,username='" + txtusername.Text + "',pass=sha1('" + txtpass.Text + "'),type='" + cboType.Text + "'  WHERE user_id =" + txtId.Text;
                SQL.Execute_CUD(query, "error to execute the query", "User has been updated in the database.");

            }
            else
            {
                query = "INSERT INTO tbluser (user_id,name,username,pass,type)" +
                        " VALUES (" + txtId.Text + ",'" + txtname.Text + "','" + txtusername.Text + "',sha1('" + txtpass.Text + "'),'" + cboType.Text + "')";
                SQL.Execute_CUD(query, "error to execute the query", "New User has been saved in the database.");
                SQL.update_Autonumber("user");

                UF.clearTxt(GroupBox1);
                SQL.autonumber("user", txtId);

                lblTitle.Text = "Add New User";


            }
             
         
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Panel2.BringToFront();
            Panel2.Dock = DockStyle.Fill;
            Panel1.SendToBack();
            Panel1.Dock = DockStyle.None;
            txtId.Text = dtglist.CurrentRow.Cells[0].Value.ToString();
            query = "SELECT * FROM tbluser WHERE user_id ='" + txtId.Text + "'";
            maxrow = SQL.maxrow(query);
            if(maxrow > 0)
            {
                txtname.Text = SQL.dt.Rows[0].Field<string>("name");
                txtusername.Text = SQL.dt.Rows[0].Field<string>("username");
            }
            lblTitle.Text = "Update User";
          
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM tbluser WHERE user_id ='" + dtglist.CurrentRow.Cells[0].Value + "'";
            SQL.Execute_CUD(query, "error to execute the query", "User has been deleted in the database.");

            tstripList_Click(sender, e);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT user_id as Id,name as Name, username as Username, type as Type" +
                     " FROM  tbluser  WHERE user_id Like '%" + txtsearch.Text + "%'";
            SQL.Load_DTG(query, dtglist);
        }
    }
}
