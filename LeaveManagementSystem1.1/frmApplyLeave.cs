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
    public partial class frmApplyLeave : Form
    {
        public frmApplyLeave()
        {
            InitializeComponent();
        }

        SQLConfig SQL = new SQLConfig();
        usableFunction UF = new usableFunction();
        string query;
        int maxrow;


        private void btn_new_Click(object sender, EventArgs e)
        { 

            UF.clearTxt(GroupBox1); 
            UF.clearTxt(GroupBox2);
            UF.clearTxt(GroupBox3);
            UF.clearTxt(GroupBox4);
            UF.clearTxt(GroupBox5);
            UF.clearTxt(this);

            //foreach(Control rdo in GroupBox2.Controls)
            //{
            //    if(rdo is RadioButton)
            //    {
            //        rdo.Enabled = false; 
            //    }
                
            //} 
            //rdoWithoutPay.Checked = false;
            //rdowithPay.Checked = false;

            dtpTimeFrom.Format = DateTimePickerFormat.Time;
            dtpTimeFrom.ShowUpDown = true;
            dtpTimeTo.Format = DateTimePickerFormat.Time;
            dtpTimeTo.ShowUpDown = true;

            SQL.trans_autonumber("applicationcode", lblcode);

            
        }

        private void frmApplyLeave_Load(object sender, EventArgs e)
        {

            query = "SELECT EMPID FROM `tblleaveinfo` WHERE `LEAVEDAYS` > 0 GROUP BY `EMPID`";
            SQL.autocomplete(query, txtEmployeeId);

            SQL.trans_autonumber("applicationcode", lblcode);
             
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //  If rdoAcidentOnDuty.Checked = False And rdoPaternity.Checked = False And rdoMaternity.Checked = False _
            //And rdoVacation.Checked = False And rdoFuneral.Checked = False And rdoSick.Checked = False Then
            //      MessageBox.Show("Please choose your leave applied for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            //      Exit Sub
            //  End If

            //  ''----------------------------------

            //  Dim rdoleaveformat As String = ""
            //  Dim rdoleaveapplied As String = ""

            string rdoleaveformat ="", rdoleaveapplied = "";


            if( rdoWithoutPay.Checked)
            {
                rdoleaveformat = "Without Pay";
            }
            else if(rdowithPay.Checked)
            {
                rdoleaveformat = "With Pay";
            }


            //  ' --------------------------
            if (rdoSick.Checked) {
                rdoleaveapplied = "Sick";
            } else if (rdoVacation.Checked) {
                rdoleaveapplied = "Vacation";
            } else if (rdoFuneral.Checked) {
                rdoleaveapplied = "Funeral";
            } else if (rdoPaternity.Checked) {
                rdoleaveapplied = "Paternity";
            } else if (rdoMaternity.Checked) {
                rdoleaveapplied = "Maternity";
            } else if (rdoAcidentOnDuty.Checked) {
                rdoleaveapplied = "AccidentOnDuty";
            }


            //  ''----------------------------------------------------
            Double day;
            int numdays, numtime;

            numtime = int.Parse(dtpTimeFrom.Value.ToString("hh")) - int.Parse( dtpTimeTo.Value.ToString("hh"));
            //MsgBox(numtime)
            numdays = int.Parse(dtpdatestart.Value.ToString("dd")) - int.Parse(dtpenddate.Value.ToString("dd"));
             //MsgBox(numdays)
            if( numdays >= 0)
            {
                day = 0.5;
            }
            else if(numtime==12)
            {
                day = 1;
            }
            else
            {
                day = numdays;
            }


            //  ''------------------------------------------
            query = "INSERT INTO `leave` (`EMPID`,`LEAVECODE`,`LEAVEFORMAT`, `LEAVEAPPLIED`, `DATEFROM`, `DATETO`,`LEAVEDATE`,`LEAVEENDDATE`, `NODAYS`, `REASON`,  `DAYOFFSCHEDULE`,`REMARKS`,`APPLIED`,`STATUS`) " 
            + "VALUES ('" + txtEmployeeId.Text + "','" + lblcode.Text + "','" + rdoleaveformat + "','" + rdoleaveapplied + "','" + dtpTimeFrom.Value.ToString("yyyy-MM-dd hh:mm:ss tt") +
            "','" + dtpTimeTo.Value.ToString("yyyy-MM-dd hh:mm:ss tt") + "','" + dtpdatestart.Value.ToString("yyyy-MM-dd hh:mm:ss tt") + "','" + dtpenddate.Value.ToString("yyyy-MM-dd hh:mm:ss tt") + "'," + day +
            ",'" + txtreasons.Text + "','" + dtpNotfallWeekened.Value.ToString("yyyy-MM-dd hh:mm:ss tt") + "','Approved',1,'Approved')";
            SQL.Execute_CUD(query, "error to execute the query", "New leave of absence has saved in the database.");


            //  ''------------------------------------------
            query = "UPDATE `employee` set `ONLEAVE`=1 ,`REMAININGLEAVE` =`REMAININGLEAVE`- " + day + " WHERE `EMPID`='" + txtemid.Text + "'";
            SQL.Execute_Query(query);
            //  '-----------------------------------------
            SQL.update_Autonumber("applicationcode");

            btn_new_Click(sender, e);
        }

        private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT `d_rate`, `position`, `DEPARTMENT` FROM `employee` e ,`employee_workinfo` ew WHERE e.`EMPID`=ew.`EMPID` AND e.`EMPID`='" + txtEmployeeId.Text + "'";
            maxrow = SQL.maxrow(query);
            if (maxrow > 0)
            {
                foreach (DataRow r in SQL.dt.Rows)
                {
                    txtposition.Text = r.Field<string>("position");
                    txtsalary.Text = r.Field<double>("d_rate").ToString();
                    txtdepartment.Text = r.Field<string>("DEPARTMENT");
                } 

                query = "SELECT * FROM `employee_workinfo` WHERE `EMPID` ='" + txtEmployeeId.Text + "'";
                maxrow = SQL.maxrow(query);
                if (maxrow > 0)
                {
                    foreach (DataRow r in SQL.dt.Rows)
                    {
                        if (r.Field<string>("w_type") == "Regular")
                        {
                            rdowithPay.Enabled = true;
                        }
                        else
                        {
                            rdowithPay.Enabled = false;
                        }
                    }
                }



            }
            else
            { 
                txtposition.Clear();
                txtsalary.Clear();
                txtdepartment.Clear();
            }

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form frm = new  frmHistory();
            frm.ShowDialog();
        }
    }
}
