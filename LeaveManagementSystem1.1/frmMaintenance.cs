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
    public partial class frmMaintenance : Form
    {
        public frmMaintenance()
        {
            InitializeComponent();
        }

        SQLConfig SQL = new SQLConfig();
        usableFunction UF = new usableFunction();
        string query;
        int maxrow, positionID, departmentid;

        private void frmMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void btnpositionload_Click(object sender, EventArgs e)
        {
            query = "SELECT ID,`DESCRIPTION` as Position FROM `tblsettings` WHERE `FORTHE`='Position'";
            SQL.Load_DTG(query, dtglistposition);
            txtposition.Clear();
            dtglistposition.Columns[0].Visible = false;
        }

        private void npositionsave_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO `tblsettings` (`DESCRIPTION`, `FORTHE`) VALUES ('" + txtposition.Text + "','Position')";
            SQL.Execute_CUD(query, "error to execute the query", "New Position has been saved in the database.");
            btnpositionload_Click(sender, e);
        }

        private void npositionupdate_Click(object sender, EventArgs e)
        {
            query = "UPDATE `tblsettings` SET `DESCRIPTION`='" + txtposition.Text + "' WHERE  `ID`=" + positionID;
            SQL.Execute_CUD(query, "error to execute the query", "Position has been updated in the database.");
            btnpositionload_Click(sender, e);
        }
        private void npositiondelete_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM `tblsettings` WHERE `ID`=" + dtglistposition.CurrentRow.Cells[0].Value;
            SQL.Execute_CUD(query, "error to execute the query", "Position has been deleted in the database.");
            btnpositionload_Click(sender, e);
        }

        private void dtglistposition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                positionID = int.Parse( dtglistposition.CurrentRow.Cells[0].Value.ToString());
                txtposition.Text = dtglistposition.CurrentRow.Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndeptSave_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO `tbldepartment` (`DEPARTMENT`) VALUES ('" + txtdepartment.Text + "')";
            SQL.Execute_CUD(query, "error to execute the query", "New Department has been saved in the database.");
            btndeptLoad_Click(sender, e);
        }

        private void btndeptDelete_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM `tbldepartment` WHERE `ID`='" + dtgdeptlist.CurrentRow.Cells[0].Value + "'";
            SQL.Execute_CUD(query, "error to execute the query", "Department has been deleted in the database.");
            btndeptLoad_Click(sender, e);
        }

        private void dtgdeptlist_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            try
            {
                departmentid = int.Parse(dtgdeptlist.CurrentRow.Cells[0].Value.ToString());
                txtdepartment.Text = dtgdeptlist.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btndeptUpdate_Click(object sender, EventArgs e)
        {
            query = "UPDATE `tbldepartment`  SET `DEPARTMENT`='" + txtdepartment.Text + "' WHERE `ID`=" + departmentid;
            SQL.Execute_CUD(query, "error to execute the query", "Department has been updated in the database.");
            btndeptLoad_Click(sender, e);
        }

        private void btndeptLoad_Click(object sender, EventArgs e)
        {
            query = "SELECT ID,`DEPARTMENT` FROM `tbldepartment` ";
            SQL.Load_DTG(query, dtgdeptlist);
            txtdepartment.Clear();
            dtgdeptlist.Columns[0].Visible = false;
        }

    }
}
