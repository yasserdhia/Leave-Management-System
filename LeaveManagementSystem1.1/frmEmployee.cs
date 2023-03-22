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
    public partial class frmEmployee : Form
    {
        public frmEmployee(string id,string title)
        { 
            InitializeComponent();
            emptitle.Text = title ;
            if(title!= "Add New Employee")
            {
                txtcode.Text = id;
            }
        }
        SQLConfig SQL = new SQLConfig();
        usableFunction UF = new usableFunction();
        string query;
        int maxrow;

        private void btnClear_Click(object sender, EventArgs e)
        {
                emptitle.Text = "Add New Employee"; 

                UF.clearTxt(GroupBox9);
                UF.clearTxt(GroupBox10);

                query = "SELECT * FROM tbldepartment";
                SQL.fiil_CBO(query, cbodeaprtment);

                query = "SELECT * FROM `tblsettings`";
                SQL.fiil_CBO(query, txtposition);

                SQL.autonumber("employee", txtcode); 
          

           
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            if (emptitle.Text == "Add New Employee")
            {
                btnClear_Click(sender, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            foreach(Control txt in GroupBox9.Controls)
            {
                if(txt is TextBox)
                {
                    if(txt.Text == "")
                    {
                        MessageBox.Show("One of the box is empty. It needed to be filled up.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            foreach (Control txt in GroupBox10.Controls)
            {
                if (txt is TextBox)
                {
                    if (txt.Text == "")
                    {
                        MessageBox.Show("One of the box is empty. It needed to be filled up.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            foreach (Control txt in GroupBox9.Controls)
            {
                if (txt is ComboBox)
                {
                    if (txt.Text == "----Select-----")
                    {
                        MessageBox.Show("You have to set the correct information.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            foreach (Control txt in GroupBox10.Controls)
            {
                if (txt is ComboBox)
                {
                    if (txt.Text == "----Select-----")
                    {
                        MessageBox.Show("You have to set the correct information.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            int now = int.Parse(DateTime.Now.Year.ToString());
            int bday = int.Parse(dtpdbirth.Value.ToString("yyyy"));
            int bdate = now - bday;
            //MessageBox.Show(bdate.ToString());

            if(bdate < 18 )
            {
                MessageBox.Show("You must atleast 18 year old in order the save.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string rdo;

            if (rdomale.Checked)
            {
                rdo = "MALE";
            }
            else
            {
                rdo = "FEMALE";
            }

            query = "SELECT * FROM `employee` e, `employee_workinfo` ew " 
                + " WHERE e.`EMPID`=ew.`EMPID` AND e.EMPID ='" + txtcode.Text + "'";
            maxrow = SQL.maxrow(query);

            if(maxrow > 0)
            { 

                query = "UPDATE `employee_workinfo` SET  `d_rate`='" + txtdrate.Text 
                    + "', `p_method`='" + txtpmethod.Text + "', `position`='" + txtposition.Text 
                    + "', `d_hired`='" +  dtpdhired.Value.ToString("yyyy-MM-dd") +
                    "', `DEPARTMENT`='" + cbodeaprtment.Text +
                    "',`w_type`='" + cbowtype.Text + "' WHERE `EMPID`='" + txtcode.Text + "'";
                SQL.Execute_Query(query);


                query = "UPDATE `employee` SET  `emp_fname`='" + txtfname.Text 
                        + "', `emp_lname`='" + txtlname.Text + "', `emp_mname`='" + txtmname.Text 
                        + "', `address`='" + txtaddress.Text + "', `contact`='" + txtcontact.Text + "', `status`='" + txtstatus.Text 
                        + "', `birth_date`='" + dtpdbirth.Value.ToString("yyyy-MM-dd") + "', `birth_place`='" + txtbplace.Text + "', `emp_sex`='" + rdo
                        + "' , `emerg_contct`='" + txtemerg.Text
                        + "'  WHERE `EMPID`='" + txtcode.Text + "'";
                SQL.Execute_CUD(query, "error to execute the query", "Employee has been updated.");
            }
            else
            {
                query = "INSERT INTO `employee_workinfo` (`EMPID`, `d_rate`, `p_method`, `position`,   `d_hired`,DEPARTMENT,w_type)"
                         + " VALUES ('" + txtcode.Text + "','" + txtdrate.Text + "','" + txtpmethod.Text + "','" + txtposition.Text
                         + "', '" + dtpdhired.Value.ToString("yyyy-MM-dd") + "','" + cbodeaprtment.Text + "','" + cbowtype.Text + "')";
                SQL.Execute_Query(query);

                query = "INSERT INTO `employee` SET  `emp_fname`='" + txtfname.Text
                       + "', `emp_lname`='" + txtlname.Text + "', `emp_mname`='" + txtmname.Text
                       + "', `address`='" + txtaddress.Text + "', `contact`='" + txtcontact.Text + "', `status`='" + txtstatus.Text
                       + "', `birth_date`='" + dtpdbirth.Value.ToString("yyyy-MM-dd") + "', `birth_place`='" + txtbplace.Text + "', `emp_sex`='" + rdo
                       + "' , `emerg_contct`='" + txtemerg.Text
                       + "' , `EMPID`='" + txtcode.Text + "', REMAININGLEAVE = 30 , DEFAULTLEAVE=30";

                SQL.Execute_CUD(query,"error to execute the query","New Employee has been saved in the database.");


                query = "INSERT INTO `tblleaveinfo`  (`EMPID`, `LEAVEDAYS`, `REASONS`)"
                + " VALUES ('" + txtcode.Text + "',15,'SICK'),('" + txtcode.Text + "',15,'Vacation')";
                SQL.Execute_Query(query);

                SQL.update_Autonumber("employee"); 

                btnClear_Click(sender, e);

            }

        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {
            if(emptitle.Text != "Add New Employee")
            {
                query = "SELECT * FROM `employee` e, `employee_workinfo` ew "
                + " WHERE e.`EMPID`=ew.`EMPID` AND e.EMPID ='" + txtcode.Text + "'";
                maxrow = SQL.maxrow(query);

                if (maxrow > 0)
                {
                    foreach (DataRow r in SQL.dt.Rows)
                    {
                        txtdrate.Text = r.Field<double>("d_rate").ToString();
                        txtpmethod.Text = r.Field<string>("p_method");
                        txtposition.Text = r.Field<string>("position");
                        dtpdhired.Value = r.Field<DateTime>("d_hired");

                        txtfname.Text = r.Field<string>("emp_fname");
                        txtlname.Text = r.Field<string>("emp_lname");
                        txtmname.Text = r.Field<string>("emp_mname");
                        txtaddress.Text = r.Field<string>("address");
                        txtcontact.Text = r.Field<string>("contact");
                        txtstatus.Text = r.Field<string>("status");
                        dtpdbirth.Value = r.Field<DateTime>("birth_date");
                        txtbplace.Text = r.Field<string>("birth_place");
                        if (r.Field<string>("emp_sex") == "MALE")
                        {
                            rdomale.Checked = true;
                        }
                        else
                        {
                            rdofemale.Checked = true;
                        }

                        txtemerg.Text = r.Field<string>("emerg_contct");
                        cbodeaprtment.Text = r.Field<string>("DEPARTMENT");
                        cbowtype.Text = r.Field<string>("w_type");
                    }


                }



            }




            //    txtdrate.Text = dt.Rows(0).Item("d_rate")
            //    txtpmethod.Text = dt.Rows(0).Item("p_method")
            //    txtposition.Text = dt.Rows(0).Item("position")
            //    dtpdhired.Value = dt.Rows(0).Item("d_hired")

            //    txtfname.Text = dt.Rows(0).Item("emp_fname")
            //    txtlname.Text = dt.Rows(0).Item("emp_lname")
            //    txtmname.Text = dt.Rows(0).Item("emp_mname")
            //    txtaddress.Text = dt.Rows(0).Item("address")
            //    txtcontact.Text = dt.Rows(0).Item("contact")
            //    txtstatus.Text = dt.Rows(0).Item("status")
            //    dtpdbirth.Value = dt.Rows(0).Item("birth_date")
            //    txtbplace.Text = dt.Rows(0).Item("birth_place")
            //    If dt.Rows(0).Item("emp_sex") = "MALE" Then
            //        rdomale.Checked = True
            //    Else
            //        rdofemale.Checked = True
            //    End If
            //    txtemerg.Text = dt.Rows(0).Item("emerg_contct")
            //    cbodeaprtment.Text = dt.Rows(0).Item("DEPARTMENT")
            //    cbowtype.Text = dt.Rows(0).Item("w_type")
            //    'Else
            //    '    cleartext(GroupBox10)
            //    '    cleartext(GroupBox9)

            //End If
        }
    }
}
