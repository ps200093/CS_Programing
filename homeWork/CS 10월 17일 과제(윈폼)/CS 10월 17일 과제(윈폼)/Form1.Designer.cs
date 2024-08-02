namespace CS_10월_17일_과제_윈폼_
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.취소ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙이기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자르기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.찾ㅇ바꾸기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.취소ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 취소ToolStripMenuItem
            // 
            this.취소ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.취소ToolStripMenuItem1,
            this.복사ToolStripMenuItem,
            this.붙이기ToolStripMenuItem,
            this.자르기ToolStripMenuItem,
            this.모두선택ToolStripMenuItem,
            this.toolStripSeparator1,
            this.찾ㅇ바꾸기ToolStripMenuItem});
            this.취소ToolStripMenuItem.Name = "취소ToolStripMenuItem";
            this.취소ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.취소ToolStripMenuItem.Text = "편집";
            // 
            // 취소ToolStripMenuItem1
            // 
            this.취소ToolStripMenuItem1.Name = "취소ToolStripMenuItem1";
            this.취소ToolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
            this.취소ToolStripMenuItem1.Text = "취소";
            this.취소ToolStripMenuItem1.Click += new System.EventHandler(this.취소ToolStripMenuItem1_Click);
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.복사ToolStripMenuItem.Text = "복사";
            this.복사ToolStripMenuItem.Click += new System.EventHandler(this.복사ToolStripMenuItem_Click);
            // 
            // 붙이기ToolStripMenuItem
            // 
            this.붙이기ToolStripMenuItem.Name = "붙이기ToolStripMenuItem";
            this.붙이기ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.붙이기ToolStripMenuItem.Text = "붙이기";
            this.붙이기ToolStripMenuItem.Click += new System.EventHandler(this.붙이기ToolStripMenuItem_Click);
            // 
            // 자르기ToolStripMenuItem
            // 
            this.자르기ToolStripMenuItem.Name = "자르기ToolStripMenuItem";
            this.자르기ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.자르기ToolStripMenuItem.Text = "자르기";
            this.자르기ToolStripMenuItem.Click += new System.EventHandler(this.자르기ToolStripMenuItem_Click);
            // 
            // 모두선택ToolStripMenuItem
            // 
            this.모두선택ToolStripMenuItem.Name = "모두선택ToolStripMenuItem";
            this.모두선택ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.모두선택ToolStripMenuItem.Text = "모두선택";
            this.모두선택ToolStripMenuItem.Click += new System.EventHandler(this.모두선택ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // 찾ㅇ바꾸기ToolStripMenuItem
            // 
            this.찾ㅇ바꾸기ToolStripMenuItem.Name = "찾ㅇ바꾸기ToolStripMenuItem";
            this.찾ㅇ바꾸기ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.찾ㅇ바꾸기ToolStripMenuItem.Text = "찾아바꾸기";
            this.찾ㅇ바꾸기ToolStripMenuItem.Click += new System.EventHandler(this.찾ㅇ바꾸기ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(682, 397);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "우리나라 대한민국 우리나라 대한민국\r\n우리나라 대한민국 우리나라 대한민국\r\n우리나라 대한민국 우리나라 대한민국\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 취소ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙이기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자르기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 찾ㅇ바꾸기ToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox1;
    }
}

