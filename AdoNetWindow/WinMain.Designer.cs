﻿namespace AdoNetWindow
{
    partial class WinMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tm학생관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.mb학생등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.mb수강신청 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm과목관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.mb과목등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm종료 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tm학생관리,
            this.tm과목관리,
            this.tm종료});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tm학생관리
            // 
            this.tm학생관리.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb학생등록,
            this.mb수강신청});
            this.tm학생관리.Name = "tm학생관리";
            this.tm학생관리.Size = new System.Drawing.Size(67, 20);
            this.tm학생관리.Text = "학생관리";
            // 
            // mb학생등록
            // 
            this.mb학생등록.Name = "mb학생등록";
            this.mb학생등록.Size = new System.Drawing.Size(180, 22);
            this.mb학생등록.Text = "학생등록";
            this.mb학생등록.Click += new System.EventHandler(this.mb학생등록_Click);
            // 
            // mb수강신청
            // 
            this.mb수강신청.Name = "mb수강신청";
            this.mb수강신청.Size = new System.Drawing.Size(180, 22);
            this.mb수강신청.Text = "수강신청";
            this.mb수강신청.Click += new System.EventHandler(this.mb수강신청_Click);
            // 
            // tm과목관리
            // 
            this.tm과목관리.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb과목등록});
            this.tm과목관리.Name = "tm과목관리";
            this.tm과목관리.Size = new System.Drawing.Size(67, 20);
            this.tm과목관리.Text = "과목관리";
            // 
            // mb과목등록
            // 
            this.mb과목등록.Name = "mb과목등록";
            this.mb과목등록.Size = new System.Drawing.Size(122, 22);
            this.mb과목등록.Text = "과목등록";
            this.mb과목등록.Click += new System.EventHandler(this.mb과목등록_Click);
            // 
            // tm종료
            // 
            this.tm종료.Name = "tm종료";
            this.tm종료.Size = new System.Drawing.Size(43, 20);
            this.tm종료.Text = "종료";
            this.tm종료.Click += new System.EventHandler(this.tm종료_Click);
            // 
            // WinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 558);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WinMain";
            this.Text = "학생 수강신청 관리";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tm학생관리;
        private System.Windows.Forms.ToolStripMenuItem mb학생등록;
        private System.Windows.Forms.ToolStripMenuItem mb수강신청;
        private System.Windows.Forms.ToolStripMenuItem tm과목관리;
        private System.Windows.Forms.ToolStripMenuItem tm종료;
        private System.Windows.Forms.ToolStripMenuItem mb과목등록;
    }
}