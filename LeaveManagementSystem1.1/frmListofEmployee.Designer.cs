namespace LeaveManagementSystem1._1
{
    partial class frmListofEmployee
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
            this.Label7 = new System.Windows.Forms.Label();
            this.txtempsearch = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.dtgemplist = new System.Windows.Forms.DataGridView();
            this.dtgremain_List = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrintStud = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgremain_List)).BeginInit();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Bernard MT Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(12, 4);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(266, 41);
            this.Label7.TabIndex = 55;
            this.Label7.Text = "List of Employees";
            // 
            // txtempsearch
            // 
            this.txtempsearch.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempsearch.Location = new System.Drawing.Point(582, 19);
            this.txtempsearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtempsearch.Multiline = true;
            this.txtempsearch.Name = "txtempsearch";
            this.txtempsearch.Size = new System.Drawing.Size(247, 28);
            this.txtempsearch.TabIndex = 53;
            this.txtempsearch.TextChanged += new System.EventHandler(this.txtempsearch_TextChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(515, 25);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(61, 16);
            this.Label6.TabIndex = 54;
            this.Label6.Text = "Search :";
            // 
            // dtgemplist
            // 
            this.dtgemplist.AllowUserToAddRows = false;
            this.dtgemplist.AllowUserToDeleteRows = false;
            this.dtgemplist.AllowUserToResizeColumns = false;
            this.dtgemplist.AllowUserToResizeRows = false;
            this.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgemplist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgemplist.Location = new System.Drawing.Point(6, 57);
            this.dtgemplist.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtgemplist.Name = "dtgemplist";
            this.dtgemplist.RowHeadersVisible = false;
            this.dtgemplist.RowTemplate.Height = 24;
            this.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgemplist.Size = new System.Drawing.Size(825, 390);
            this.dtgemplist.StandardTab = true;
            this.dtgemplist.TabIndex = 51;
            // 
            // dtgremain_List
            // 
            this.dtgremain_List.AllowUserToAddRows = false;
            this.dtgremain_List.AllowUserToDeleteRows = false;
            this.dtgremain_List.AllowUserToResizeColumns = false;
            this.dtgremain_List.AllowUserToResizeRows = false;
            this.dtgremain_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgremain_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgremain_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgremain_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgremain_List.Location = new System.Drawing.Point(393, 113);
            this.dtgremain_List.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtgremain_List.Name = "dtgremain_List";
            this.dtgremain_List.RowHeadersVisible = false;
            this.dtgremain_List.RowTemplate.Height = 24;
            this.dtgremain_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgremain_List.ShowCellToolTips = false;
            this.dtgremain_List.Size = new System.Drawing.Size(21, 18);
            this.dtgremain_List.TabIndex = 52;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(255, 455);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 56;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(351, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrintStud
            // 
            this.btnPrintStud.Location = new System.Drawing.Point(12, 455);
            this.btnPrintStud.Name = "btnPrintStud";
            this.btnPrintStud.Size = new System.Drawing.Size(111, 32);
            this.btnPrintStud.TabIndex = 58;
            this.btnPrintStud.Text = "Print Leave";
            this.btnPrintStud.UseVisualStyleBackColor = true;
            this.btnPrintStud.Click += new System.EventHandler(this.btnPrintStud_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Location = new System.Drawing.Point(129, 455);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(120, 32);
            this.btnPrintAll.TabIndex = 59;
            this.btnPrintAll.Text = "Print All";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // frmListofEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 495);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.btnPrintStud);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtempsearch);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dtgemplist);
            this.Controls.Add(this.dtgremain_List);
            this.Name = "frmListofEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Employee\'s";
            this.Load += new System.EventHandler(this.frmListofEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgremain_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtempsearch;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DataGridView dtgemplist;
        internal System.Windows.Forms.DataGridView dtgremain_List;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrintStud;
        private System.Windows.Forms.Button btnPrintAll;
    }
}