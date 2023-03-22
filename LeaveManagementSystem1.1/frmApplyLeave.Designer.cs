namespace LeaveManagementSystem1._1
{
    partial class frmApplyLeave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblcode = new System.Windows.Forms.Label();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.dtpApplied = new System.Windows.Forms.DateTimePicker();
            this.rdoAcidentOnDuty = new System.Windows.Forms.RadioButton();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.rdoWithoutPay = new System.Windows.Forms.RadioButton();
            this.btnsearch = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtemid = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoFuneral = new System.Windows.Forms.RadioButton();
            this.rdoMaternity = new System.Windows.Forms.RadioButton();
            this.rdoPaternity = new System.Windows.Forms.RadioButton();
            this.rdoVacation = new System.Windows.Forms.RadioButton();
            this.rdoSick = new System.Windows.Forms.RadioButton();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.rdowithPay = new System.Windows.Forms.RadioButton();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.Label13 = new System.Windows.Forms.Label();
            this.dtpdatestart = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtreasons = new System.Windows.Forms.RichTextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.dtpNotfallWeekened = new System.Windows.Forms.DateTimePicker();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.txtnoDays = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(391, 69);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(57, 16);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Salary :";
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcode.Location = new System.Drawing.Point(609, 109);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(125, 16);
            this.lblcode.TabIndex = 13;
            this.lblcode.Text = "HR Form-011 (ALA)";
            // 
            // txtdepartment
            // 
            this.txtdepartment.Enabled = false;
            this.txtdepartment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartment.Location = new System.Drawing.Point(135, 59);
            this.txtdepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdepartment.Multiline = true;
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.ReadOnly = true;
            this.txtdepartment.Size = new System.Drawing.Size(240, 26);
            this.txtdepartment.TabIndex = 10;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(14, 37);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(91, 16);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Employee Id:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(14, 69);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(90, 16);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Department :";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmployeeId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmployeeId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Location = new System.Drawing.Point(135, 27);
            this.txtEmployeeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(240, 26);
            this.txtEmployeeId.TabIndex = 4;
            this.txtEmployeeId.TextChanged += new System.EventHandler(this.txtEmployeeId_TextChanged);
            // 
            // dtpApplied
            // 
            this.dtpApplied.Location = new System.Drawing.Point(12, 9);
            this.dtpApplied.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpApplied.Name = "dtpApplied";
            this.dtpApplied.Size = new System.Drawing.Size(266, 20);
            this.dtpApplied.TabIndex = 42;
            // 
            // rdoAcidentOnDuty
            // 
            this.rdoAcidentOnDuty.AutoSize = true;
            this.rdoAcidentOnDuty.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAcidentOnDuty.Location = new System.Drawing.Point(460, 67);
            this.rdoAcidentOnDuty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoAcidentOnDuty.Name = "rdoAcidentOnDuty";
            this.rdoAcidentOnDuty.Size = new System.Drawing.Size(135, 20);
            this.rdoAcidentOnDuty.TabIndex = 7;
            this.rdoAcidentOnDuty.Text = "Accident On Duty";
            this.rdoAcidentOnDuty.UseVisualStyleBackColor = true;
            // 
            // txtsalary
            // 
            this.txtsalary.Enabled = false;
            this.txtsalary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.Location = new System.Drawing.Point(479, 59);
            this.txtsalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsalary.Multiline = true;
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.ReadOnly = true;
            this.txtsalary.Size = new System.Drawing.Size(239, 26);
            this.txtsalary.TabIndex = 12;
            // 
            // txtposition
            // 
            this.txtposition.Enabled = false;
            this.txtposition.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposition.Location = new System.Drawing.Point(479, 25);
            this.txtposition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtposition.Multiline = true;
            this.txtposition.Name = "txtposition";
            this.txtposition.ReadOnly = true;
            this.txtposition.Size = new System.Drawing.Size(239, 26);
            this.txtposition.TabIndex = 8;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(391, 37);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(67, 16);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Position :";
            // 
            // rdoWithoutPay
            // 
            this.rdoWithoutPay.AutoSize = true;
            this.rdoWithoutPay.Location = new System.Drawing.Point(40, 48);
            this.rdoWithoutPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoWithoutPay.Name = "rdoWithoutPay";
            this.rdoWithoutPay.Size = new System.Drawing.Size(103, 20);
            this.rdoWithoutPay.TabIndex = 0;
            this.rdoWithoutPay.Text = "Without Pay";
            this.rdoWithoutPay.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsearch.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(394, 132);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(74, 28);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Find";
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(77, 138);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(95, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Employee Id :";
            // 
            // txtemid
            // 
            this.txtemid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemid.Location = new System.Drawing.Point(187, 132);
            this.txtemid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtemid.Multiline = true;
            this.txtemid.Name = "txtemid";
            this.txtemid.Size = new System.Drawing.Size(188, 28);
            this.txtemid.TabIndex = 2;
            this.txtemid.Tag = "Employee Id";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.rdoAcidentOnDuty);
            this.GroupBox2.Controls.Add(this.rdoFuneral);
            this.GroupBox2.Controls.Add(this.rdoMaternity);
            this.GroupBox2.Controls.Add(this.rdoPaternity);
            this.GroupBox2.Controls.Add(this.rdoVacation);
            this.GroupBox2.Controls.Add(this.rdoSick);
            this.GroupBox2.Controls.Add(this.GroupBox3);
            this.GroupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(26, 156);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Size = new System.Drawing.Size(742, 106);
            this.GroupBox2.TabIndex = 44;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Leave Applied For";
            // 
            // rdoFuneral
            // 
            this.rdoFuneral.AutoSize = true;
            this.rdoFuneral.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFuneral.Location = new System.Drawing.Point(460, 39);
            this.rdoFuneral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoFuneral.Name = "rdoFuneral";
            this.rdoFuneral.Size = new System.Drawing.Size(75, 20);
            this.rdoFuneral.TabIndex = 6;
            this.rdoFuneral.Text = "Funeral";
            this.rdoFuneral.UseVisualStyleBackColor = true;
            // 
            // rdoMaternity
            // 
            this.rdoMaternity.AutoSize = true;
            this.rdoMaternity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMaternity.Location = new System.Drawing.Point(354, 67);
            this.rdoMaternity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoMaternity.Name = "rdoMaternity";
            this.rdoMaternity.Size = new System.Drawing.Size(85, 20);
            this.rdoMaternity.TabIndex = 5;
            this.rdoMaternity.Text = "Maternity";
            this.rdoMaternity.UseVisualStyleBackColor = true;
            // 
            // rdoPaternity
            // 
            this.rdoPaternity.AutoSize = true;
            this.rdoPaternity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPaternity.Location = new System.Drawing.Point(255, 67);
            this.rdoPaternity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoPaternity.Name = "rdoPaternity";
            this.rdoPaternity.Size = new System.Drawing.Size(83, 20);
            this.rdoPaternity.TabIndex = 4;
            this.rdoPaternity.Text = "Paternity";
            this.rdoPaternity.UseVisualStyleBackColor = true;
            // 
            // rdoVacation
            // 
            this.rdoVacation.AutoSize = true;
            this.rdoVacation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVacation.Location = new System.Drawing.Point(357, 39);
            this.rdoVacation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoVacation.Name = "rdoVacation";
            this.rdoVacation.Size = new System.Drawing.Size(81, 20);
            this.rdoVacation.TabIndex = 3;
            this.rdoVacation.Text = "Vacation";
            this.rdoVacation.UseVisualStyleBackColor = true;
            // 
            // rdoSick
            // 
            this.rdoSick.AutoSize = true;
            this.rdoSick.Checked = true;
            this.rdoSick.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSick.Location = new System.Drawing.Point(255, 39);
            this.rdoSick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoSick.Name = "rdoSick";
            this.rdoSick.Size = new System.Drawing.Size(53, 20);
            this.rdoSick.TabIndex = 2;
            this.rdoSick.TabStop = true;
            this.rdoSick.Text = "Sick";
            this.rdoSick.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.rdoWithoutPay);
            this.GroupBox3.Controls.Add(this.rdowithPay);
            this.GroupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(17, 19);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox3.Size = new System.Drawing.Size(215, 80);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Option";
            // 
            // rdowithPay
            // 
            this.rdowithPay.AutoSize = true;
            this.rdowithPay.Checked = true;
            this.rdowithPay.Location = new System.Drawing.Point(40, 20);
            this.rdowithPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdowithPay.Name = "rdowithPay";
            this.rdowithPay.Size = new System.Drawing.Size(83, 20);
            this.rdowithPay.TabIndex = 0;
            this.rdowithPay.TabStop = true;
            this.rdowithPay.Text = "With Pay";
            this.rdowithPay.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtsalary);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.lblcode);
            this.GroupBox1.Controls.Add(this.txtdepartment);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.txtEmployeeId);
            this.GroupBox1.Controls.Add(this.txtposition);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.btnsearch);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtemid);
            this.GroupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(26, 39);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Size = new System.Drawing.Size(740, 109);
            this.GroupBox1.TabIndex = 43;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Employee\'s Details";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.dtpenddate);
            this.GroupBox5.Controls.Add(this.Label13);
            this.GroupBox5.Controls.Add(this.dtpdatestart);
            this.GroupBox5.Controls.Add(this.dtpTimeTo);
            this.GroupBox5.Controls.Add(this.Label8);
            this.GroupBox5.Controls.Add(this.Label9);
            this.GroupBox5.Controls.Add(this.dtpTimeFrom);
            this.GroupBox5.Controls.Add(this.Label10);
            this.GroupBox5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.Location = new System.Drawing.Point(26, 269);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(740, 108);
            this.GroupBox5.TabIndex = 46;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "                              From                                               " +
    "                              To";
            // 
            // dtpenddate
            // 
            this.dtpenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpenddate.Location = new System.Drawing.Point(443, 27);
            this.dtpenddate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(161, 22);
            this.dtpenddate.TabIndex = 30;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(364, 31);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(73, 16);
            this.Label13.TabIndex = 29;
            this.Label13.Text = "End Date :";
            // 
            // dtpdatestart
            // 
            this.dtpdatestart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdatestart.Location = new System.Drawing.Point(146, 28);
            this.dtpdatestart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpdatestart.Name = "dtpdatestart";
            this.dtpdatestart.Size = new System.Drawing.Size(201, 22);
            this.dtpdatestart.TabIndex = 28;
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeTo.Location = new System.Drawing.Point(443, 61);
            this.dtpTimeTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.Size = new System.Drawing.Size(161, 22);
            this.dtpTimeTo.TabIndex = 22;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(84, 65);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(48, 16);
            this.Label8.TabIndex = 19;
            this.Label8.Text = "Time :";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(389, 66);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(48, 16);
            this.Label9.TabIndex = 21;
            this.Label9.Text = "Time :";
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeFrom.Location = new System.Drawing.Point(146, 62);
            this.dtpTimeFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.Size = new System.Drawing.Size(201, 22);
            this.dtpTimeFrom.TabIndex = 20;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(36, 32);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(88, 16);
            this.Label10.TabIndex = 27;
            this.Label10.Text = "Leave Date :";
            // 
            // txtreasons
            // 
            this.txtreasons.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreasons.Location = new System.Drawing.Point(6, 22);
            this.txtreasons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtreasons.Name = "txtreasons";
            this.txtreasons.Size = new System.Drawing.Size(727, 63);
            this.txtreasons.TabIndex = 0;
            this.txtreasons.Text = "";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNew.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(371, 27);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 42);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(28, 40);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(426, 16);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "Please specify DAY-OFF schedule if it does not fall on a weekened";
            // 
            // dtpNotfallWeekened
            // 
            this.dtpNotfallWeekened.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNotfallWeekened.Location = new System.Drawing.Point(469, 34);
            this.dtpNotfallWeekened.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNotfallWeekened.Name = "dtpNotfallWeekened";
            this.dtpNotfallWeekened.Size = new System.Drawing.Size(265, 22);
            this.dtpNotfallWeekened.TabIndex = 17;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.txtreasons);
            this.GroupBox4.Controls.Add(this.btnNew);
            this.GroupBox4.Controls.Add(this.Label7);
            this.GroupBox4.Controls.Add(this.dtpNotfallWeekened);
            this.GroupBox4.Controls.Add(this.txtnoDays);
            this.GroupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(20, 376);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox4.Size = new System.Drawing.Size(740, 93);
            this.GroupBox4.TabIndex = 45;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Tag = "Reasons";
            this.GroupBox4.Text = "Other Reasons";
            // 
            // txtnoDays
            // 
            this.txtnoDays.Location = new System.Drawing.Point(469, 34);
            this.txtnoDays.Name = "txtnoDays";
            this.txtnoDays.Size = new System.Drawing.Size(100, 26);
            this.txtnoDays.TabIndex = 8;
            // 
            // Label12
            // 
            this.Label12.Font = new System.Drawing.Font("Bernard MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(12, 4);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(389, 32);
            this.Label12.TabIndex = 47;
            this.Label12.Text = "Add Leave of Absence";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(36, 13);
            this.Label1.TabIndex = 41;
            this.Label1.Text = "Date :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 26);
            this.button1.TabIndex = 48;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(135, 482);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(103, 26);
            this.btn_new.TabIndex = 49;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(244, 482);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(103, 26);
            this.btnHistory.TabIndex = 50;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // frmApplyLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 514);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dtpApplied);
            this.Name = "frmApplyLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply Leave Form";
            this.Load += new System.EventHandler(this.frmApplyLeave_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label lblcode;
        internal System.Windows.Forms.TextBox txtdepartment;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtEmployeeId;
        internal System.Windows.Forms.DateTimePicker dtpApplied;
        internal System.Windows.Forms.RadioButton rdoAcidentOnDuty;
        internal System.Windows.Forms.TextBox txtsalary;
        internal System.Windows.Forms.TextBox txtposition;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.RadioButton rdoWithoutPay;
        internal System.Windows.Forms.Button btnsearch;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtemid;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.RadioButton rdoFuneral;
        internal System.Windows.Forms.RadioButton rdoMaternity;
        internal System.Windows.Forms.RadioButton rdoPaternity;
        internal System.Windows.Forms.RadioButton rdoVacation;
        internal System.Windows.Forms.RadioButton rdoSick;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.RadioButton rdowithPay;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.DateTimePicker dtpenddate;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.DateTimePicker dtpdatestart;
        internal System.Windows.Forms.DateTimePicker dtpTimeTo;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.DateTimePicker dtpTimeFrom;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.RichTextBox txtreasons;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DateTimePicker dtpNotfallWeekened;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TextBox txtnoDays;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btnHistory;
    }
}