namespace LeaveManagementSystem1._1
{
    partial class frmMaintenance
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
            this.dtgdeptlist = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpositionload = new System.Windows.Forms.Button();
            this.dtglistposition = new System.Windows.Forms.DataGridView();
            this.npositiondelete = new System.Windows.Forms.Button();
            this.npositionupdate = new System.Windows.Forms.Button();
            this.npositionsave = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btndeptLoad = new System.Windows.Forms.Button();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btndeptDelete = new System.Windows.Forms.Button();
            this.btndeptUpdate = new System.Windows.Forms.Button();
            this.btndeptSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdeptlist)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistposition)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgdeptlist
            // 
            this.dtgdeptlist.AllowUserToAddRows = false;
            this.dtgdeptlist.AllowUserToDeleteRows = false;
            this.dtgdeptlist.AllowUserToResizeColumns = false;
            this.dtgdeptlist.AllowUserToResizeRows = false;
            this.dtgdeptlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgdeptlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgdeptlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdeptlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgdeptlist.Location = new System.Drawing.Point(6, 61);
            this.dtgdeptlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgdeptlist.Name = "dtgdeptlist";
            this.dtgdeptlist.Size = new System.Drawing.Size(247, 290);
            this.dtgdeptlist.TabIndex = 1;
            this.dtgdeptlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdeptlist_CellClick);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnpositionload);
            this.GroupBox1.Controls.Add(this.dtglistposition);
            this.GroupBox1.Controls.Add(this.npositiondelete);
            this.GroupBox1.Controls.Add(this.npositionupdate);
            this.GroupBox1.Controls.Add(this.npositionsave);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtposition);
            this.GroupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 13);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox1.Size = new System.Drawing.Size(318, 359);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Position of the Employee";
            // 
            // btnpositionload
            // 
            this.btnpositionload.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnpositionload.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpositionload.Location = new System.Drawing.Point(237, 109);
            this.btnpositionload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnpositionload.Name = "btnpositionload";
            this.btnpositionload.Size = new System.Drawing.Size(75, 40);
            this.btnpositionload.TabIndex = 6;
            this.btnpositionload.Text = "Load";
            this.btnpositionload.UseVisualStyleBackColor = false;
            this.btnpositionload.Click += new System.EventHandler(this.btnpositionload_Click);
            // 
            // dtglistposition
            // 
            this.dtglistposition.AllowUserToAddRows = false;
            this.dtglistposition.AllowUserToDeleteRows = false;
            this.dtglistposition.AllowUserToResizeColumns = false;
            this.dtglistposition.AllowUserToResizeRows = false;
            this.dtglistposition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtglistposition.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtglistposition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistposition.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtglistposition.Location = new System.Drawing.Point(6, 61);
            this.dtglistposition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtglistposition.Name = "dtglistposition";
            this.dtglistposition.Size = new System.Drawing.Size(225, 290);
            this.dtglistposition.TabIndex = 1;
            this.dtglistposition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistposition_CellClick);
            // 
            // npositiondelete
            // 
            this.npositiondelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.npositiondelete.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npositiondelete.Location = new System.Drawing.Point(237, 205);
            this.npositiondelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.npositiondelete.Name = "npositiondelete";
            this.npositiondelete.Size = new System.Drawing.Size(75, 40);
            this.npositiondelete.TabIndex = 5;
            this.npositiondelete.Text = "Delete";
            this.npositiondelete.UseVisualStyleBackColor = false;
            this.npositiondelete.Click += new System.EventHandler(this.npositiondelete_Click);
            // 
            // npositionupdate
            // 
            this.npositionupdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.npositionupdate.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npositionupdate.Location = new System.Drawing.Point(237, 157);
            this.npositionupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.npositionupdate.Name = "npositionupdate";
            this.npositionupdate.Size = new System.Drawing.Size(75, 40);
            this.npositionupdate.TabIndex = 4;
            this.npositionupdate.Text = "Update";
            this.npositionupdate.UseVisualStyleBackColor = false;
            this.npositionupdate.Click += new System.EventHandler(this.npositionupdate_Click);
            // 
            // npositionsave
            // 
            this.npositionsave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.npositionsave.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npositionsave.Location = new System.Drawing.Point(237, 61);
            this.npositionsave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.npositionsave.Name = "npositionsave";
            this.npositionsave.Size = new System.Drawing.Size(75, 40);
            this.npositionsave.TabIndex = 3;
            this.npositionsave.Text = "Save";
            this.npositionsave.UseVisualStyleBackColor = false;
            this.npositionsave.Click += new System.EventHandler(this.npositionsave_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(6, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Position :";
            // 
            // txtposition
            // 
            this.txtposition.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposition.Location = new System.Drawing.Point(79, 27);
            this.txtposition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtposition.Multiline = true;
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(233, 26);
            this.txtposition.TabIndex = 2;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btndeptLoad);
            this.GroupBox2.Controls.Add(this.dtgdeptlist);
            this.GroupBox2.Controls.Add(this.txtdepartment);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.btndeptDelete);
            this.GroupBox2.Controls.Add(this.btndeptUpdate);
            this.GroupBox2.Controls.Add(this.btndeptSave);
            this.GroupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(346, 13);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox2.Size = new System.Drawing.Size(340, 359);
            this.GroupBox2.TabIndex = 11;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Department of the Employee";
            // 
            // btndeptLoad
            // 
            this.btndeptLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btndeptLoad.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeptLoad.Location = new System.Drawing.Point(259, 109);
            this.btndeptLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndeptLoad.Name = "btndeptLoad";
            this.btndeptLoad.Size = new System.Drawing.Size(75, 40);
            this.btndeptLoad.TabIndex = 6;
            this.btndeptLoad.Text = "Load";
            this.btndeptLoad.UseVisualStyleBackColor = false;
            this.btndeptLoad.Click += new System.EventHandler(this.btndeptLoad_Click);
            // 
            // txtdepartment
            // 
            this.txtdepartment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartment.Location = new System.Drawing.Point(114, 27);
            this.txtdepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdepartment.Multiline = true;
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(211, 26);
            this.txtdepartment.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(18, 30);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(90, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Department :";
            // 
            // btndeptDelete
            // 
            this.btndeptDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btndeptDelete.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeptDelete.Location = new System.Drawing.Point(259, 205);
            this.btndeptDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndeptDelete.Name = "btndeptDelete";
            this.btndeptDelete.Size = new System.Drawing.Size(75, 40);
            this.btndeptDelete.TabIndex = 5;
            this.btndeptDelete.Text = "Delete";
            this.btndeptDelete.UseVisualStyleBackColor = false;
            this.btndeptDelete.Click += new System.EventHandler(this.btndeptDelete_Click);
            // 
            // btndeptUpdate
            // 
            this.btndeptUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btndeptUpdate.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeptUpdate.Location = new System.Drawing.Point(259, 157);
            this.btndeptUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndeptUpdate.Name = "btndeptUpdate";
            this.btndeptUpdate.Size = new System.Drawing.Size(75, 40);
            this.btndeptUpdate.TabIndex = 4;
            this.btndeptUpdate.Text = "Update";
            this.btndeptUpdate.UseVisualStyleBackColor = false;
            this.btndeptUpdate.Click += new System.EventHandler(this.btndeptUpdate_Click);
            // 
            // btndeptSave
            // 
            this.btndeptSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btndeptSave.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeptSave.Location = new System.Drawing.Point(259, 61);
            this.btndeptSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndeptSave.Name = "btndeptSave";
            this.btndeptSave.Size = new System.Drawing.Size(75, 40);
            this.btndeptSave.TabIndex = 3;
            this.btndeptSave.Text = "Save";
            this.btndeptSave.UseVisualStyleBackColor = false;
            this.btndeptSave.Click += new System.EventHandler(this.btndeptSave_Click);
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 386);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Name = "frmMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance Form";
            this.Load += new System.EventHandler(this.frmMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdeptlist)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistposition)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtgdeptlist;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnpositionload;
        internal System.Windows.Forms.DataGridView dtglistposition;
        internal System.Windows.Forms.Button npositiondelete;
        internal System.Windows.Forms.Button npositionupdate;
        internal System.Windows.Forms.Button npositionsave;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtposition;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btndeptLoad;
        internal System.Windows.Forms.TextBox txtdepartment;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btndeptDelete;
        internal System.Windows.Forms.Button btndeptUpdate;
        internal System.Windows.Forms.Button btndeptSave;
    }
}