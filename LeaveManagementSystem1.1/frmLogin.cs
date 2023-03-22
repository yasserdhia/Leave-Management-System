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
    public partial class frmLogin : Form
    {
        Form1 frm;
        public frmLogin(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        SQLConfig SQL = new SQLConfig();
        usableFunction UF = new usableFunction();
        string query;
        int maxrow;
        private void OK_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbluser WHERE username= '" + UsernameTextBox.Text + "' and pass = sha1('" + PasswordTextBox.Text + "')";
            maxrow = SQL.maxrow(query);
            if(maxrow > 0)
            {
                MessageBox.Show("Welcom user");
                this.Close();

                frm.enabled_menu();

            }
            else
            {
                MessageBox.Show("Account does not exist. Please contact administrator.","Invalid account",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
