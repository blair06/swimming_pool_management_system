namespace WindowsFormsApp1
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.회원등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.반납ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.결제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 91);
            this.button1.TabIndex = 1;
            this.button1.Text = "결제";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(51, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "합계:";
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(56, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(264, 201);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "상품명";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "가격";
            this.columnHeader2.Width = 199;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 91);
            this.button2.TabIndex = 7;
            this.button2.Text = "선택상품 취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(53, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "수영장 물품 구매";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 63);
            this.button3.TabIndex = 8;
            this.button3.Tag = "30000";
            this.button3.Text = "수영복\r\n(원피스형)\r\n30000";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(445, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 63);
            this.button4.TabIndex = 9;
            this.button4.Text = "물안경\r\n15000";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(326, 163);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 63);
            this.button5.TabIndex = 10;
            this.button5.Text = "수영복\r\n(남성용)\r\n27000";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(445, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 63);
            this.button6.TabIndex = 11;
            this.button6.Text = "수영복\r\n(투피스형)\r\n32000";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(444, 332);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 91);
            this.button7.TabIndex = 12;
            this.button7.Text = "전체상품 취소";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(326, 232);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 63);
            this.button8.TabIndex = 13;
            this.button8.Text = "수영모\r\n5000원";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(445, 232);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(113, 63);
            this.button9.TabIndex = 14;
            this.button9.Text = "스포츠백\r\n35000";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(592, 28);
            this.menuStrip2.TabIndex = 20;
            this.menuStrip2.Text = "menuStrip2";
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.등록ToolStripMenuItem,
            this.반납ToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(101, 24);
            this.toolStripMenuItem2.Text = "사물함 관리";
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
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.결제ToolStripMenuItem,
            this.취소ToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(136, 24);
            this.toolStripMenuItem3.Text = "수영장 물품 관리";
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 454);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "w";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 회원등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 반납ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 결제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 취소ToolStripMenuItem;
    }
}