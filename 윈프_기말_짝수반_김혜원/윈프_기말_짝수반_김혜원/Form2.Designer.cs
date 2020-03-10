namespace WindowsFormsApp1
{
    partial class Form2
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_locker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_house = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_registrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.사물함관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.헬스장물품관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_current_member = new System.Windows.Forms.Label();
            this.lb_total_member = new System.Windows.Forms.Label();
            this.lb_current = new System.Windows.Forms.Label();
            this.회원등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.반납ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.결제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 43);
            this.button2.TabIndex = 21;
            this.button2.Text = "회원 삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "회원 등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_sex,
            this.col_age,
            this.col_locker,
            this.col_phone,
            this.col_house,
            this.col_registrate});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(57, 135);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(720, 157);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // col_name
            // 
            this.col_name.Text = "이름";
            this.col_name.Width = 99;
            // 
            // col_sex
            // 
            this.col_sex.Text = "성별";
            this.col_sex.Width = 99;
            // 
            // col_age
            // 
            this.col_age.Text = "나이";
            this.col_age.Width = 99;
            // 
            // col_locker
            // 
            this.col_locker.Text = "사물함 번호";
            this.col_locker.Width = 101;
            // 
            // col_phone
            // 
            this.col_phone.Text = "전화 번호";
            this.col_phone.Width = 120;
            // 
            // col_house
            // 
            this.col_house.Text = "집주소";
            this.col_house.Width = 99;
            // 
            // col_registrate
            // 
            this.col_registrate.Text = "등록 기간";
            this.col_registrate.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(36, 102);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(757, 202);
            this.label1.TabIndex = 18;
            this.label1.Text = "회원 목록";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.사물함관리ToolStripMenuItem,
            this.헬스장물품관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원등록ToolStripMenuItem,
            this.회원삭제ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItem1.Text = "회원관리";
            // 
            // 사물함관리ToolStripMenuItem
            // 
            this.사물함관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.등록ToolStripMenuItem,
            this.반납ToolStripMenuItem});
            this.사물함관리ToolStripMenuItem.Name = "사물함관리ToolStripMenuItem";
            this.사물함관리ToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.사물함관리ToolStripMenuItem.Text = "사물함 관리";
            // 
            // 헬스장물품관리ToolStripMenuItem
            // 
            this.헬스장물품관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.결제ToolStripMenuItem,
            this.취소ToolStripMenuItem});
            this.헬스장물품관리ToolStripMenuItem.Name = "헬스장물품관리ToolStripMenuItem";
            this.헬스장물품관리ToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.헬스장물품관리ToolStripMenuItem.Text = "수영장 물품 관리";
            this.헬스장물품관리ToolStripMenuItem.Click += new System.EventHandler(this.헬스장물품관리ToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "현 회원수:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(33, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "회원 현황";
            // 
            // lb_current_member
            // 
            this.lb_current_member.AutoSize = true;
            this.lb_current_member.Location = new System.Drawing.Point(116, 87);
            this.lb_current_member.Name = "lb_current_member";
            this.lb_current_member.Size = new System.Drawing.Size(0, 15);
            this.lb_current_member.TabIndex = 24;
            this.lb_current_member.Click += new System.EventHandler(this.label4_Click);
            // 
            // lb_total_member
            // 
            this.lb_total_member.AutoSize = true;
            this.lb_total_member.Location = new System.Drawing.Point(220, 87);
            this.lb_total_member.Name = "lb_total_member";
            this.lb_total_member.Size = new System.Drawing.Size(0, 15);
            this.lb_total_member.TabIndex = 26;
            // 
            // lb_current
            // 
            this.lb_current.AutoSize = true;
            this.lb_current.Location = new System.Drawing.Point(106, 87);
            this.lb_current.Name = "lb_current";
            this.lb_current.Size = new System.Drawing.Size(15, 15);
            this.lb_current.TabIndex = 27;
            this.lb_current.Text = "0";
            // 
            // 회원등록ToolStripMenuItem
            // 
            this.회원등록ToolStripMenuItem.Name = "회원등록ToolStripMenuItem";
            this.회원등록ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.회원등록ToolStripMenuItem.Text = "회원등록";
            // 
            // 회원삭제ToolStripMenuItem
            // 
            this.회원삭제ToolStripMenuItem.Name = "회원삭제ToolStripMenuItem";
            this.회원삭제ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.회원삭제ToolStripMenuItem.Text = "회원삭제";
            // 
            // 등록ToolStripMenuItem
            // 
            this.등록ToolStripMenuItem.Name = "등록ToolStripMenuItem";
            this.등록ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.등록ToolStripMenuItem.Text = "등록";
            // 
            // 반납ToolStripMenuItem
            // 
            this.반납ToolStripMenuItem.Name = "반납ToolStripMenuItem";
            this.반납ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.반납ToolStripMenuItem.Text = "반납";
            // 
            // 결제ToolStripMenuItem
            // 
            this.결제ToolStripMenuItem.Name = "결제ToolStripMenuItem";
            this.결제ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.결제ToolStripMenuItem.Text = "결제";
            // 
            // 취소ToolStripMenuItem
            // 
            this.취소ToolStripMenuItem.Name = "취소ToolStripMenuItem";
            this.취소ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.취소ToolStripMenuItem.Text = "취소";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 409);
            this.Controls.Add(this.lb_current);
            this.Controls.Add(this.lb_total_member);
            this.Controls.Add(this.lb_current_member);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_sex;
        private System.Windows.Forms.ColumnHeader col_age;
        private System.Windows.Forms.ColumnHeader col_locker;
        private System.Windows.Forms.ColumnHeader col_phone;
        private System.Windows.Forms.ColumnHeader col_house;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 사물함관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 헬스장물품관리ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader col_registrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_current_member;
        private System.Windows.Forms.Label lb_total_member;
        public System.Windows.Forms.ListView listView2;
        public System.Windows.Forms.Label lb_current;
        private System.Windows.Forms.ToolStripMenuItem 회원등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 반납ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 결제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 취소ToolStripMenuItem;
    }
}