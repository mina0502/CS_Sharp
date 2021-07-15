namespace AdoNetWindow
{
    partial class frmCourseRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourseRegistration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.grdCourseRegistration = new System.Windows.Forms.DataGridView();
            this.grdSubject = new System.Windows.Forms.DataGridView();
            this.btnCourseRegistration = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCourseRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.cbStudent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "학생선택:";
            // 
            // cbStudent
            // 
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(118, 31);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(114, 23);
            this.cbStudent.TabIndex = 2;
            this.cbStudent.SelectionChangeCommitted += new System.EventHandler(this.cbStudent_SelectionChangeCommitted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCourseRegistration});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // grdCourseRegistration
            // 
            this.grdCourseRegistration.AllowUserToAddRows = false;
            this.grdCourseRegistration.AllowUserToDeleteRows = false;
            this.grdCourseRegistration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdCourseRegistration.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdCourseRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCourseRegistration.Dock = System.Windows.Forms.DockStyle.Left;
            this.grdCourseRegistration.Location = new System.Drawing.Point(0, 67);
            this.grdCourseRegistration.MultiSelect = false;
            this.grdCourseRegistration.Name = "grdCourseRegistration";
            this.grdCourseRegistration.ReadOnly = true;
            this.grdCourseRegistration.RowTemplate.Height = 27;
            this.grdCourseRegistration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCourseRegistration.Size = new System.Drawing.Size(344, 409);
            this.grdCourseRegistration.TabIndex = 1;
            // 
            // grdSubject
            // 
            this.grdSubject.AllowUserToAddRows = false;
            this.grdSubject.AllowUserToDeleteRows = false;
            this.grdSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdSubject.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSubject.Location = new System.Drawing.Point(344, 67);
            this.grdSubject.Name = "grdSubject";
            this.grdSubject.ReadOnly = true;
            this.grdSubject.RowTemplate.Height = 27;
            this.grdSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSubject.Size = new System.Drawing.Size(394, 409);
            this.grdSubject.TabIndex = 2;
            // 
            // btnCourseRegistration
            // 
            this.btnCourseRegistration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCourseRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseRegistration.Image")));
            this.btnCourseRegistration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCourseRegistration.Name = "btnCourseRegistration";
            this.btnCourseRegistration.Size = new System.Drawing.Size(73, 24);
            this.btnCourseRegistration.Text = "수강신청";
            this.btnCourseRegistration.Click += new System.EventHandler(this.btnCourseRegistration_Click);
            // 
            // frmCourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 476);
            this.Controls.Add(this.grdSubject);
            this.Controls.Add(this.grdCourseRegistration);
            this.Controls.Add(this.panel1);
            this.Name = "frmCourseRegistration";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmCourseRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCourseRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView grdCourseRegistration;
        private System.Windows.Forms.ToolStripButton btnCourseRegistration;
        private System.Windows.Forms.DataGridView grdSubject;
    }
}