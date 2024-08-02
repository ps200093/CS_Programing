namespace CS_11월_14일_과제
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
            this.동작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폰트대화상자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색대화상자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.위치문자열대화상자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.동작ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 동작ToolStripMenuItem
            // 
            this.동작ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폰트대화상자ToolStripMenuItem,
            this.색대화상자ToolStripMenuItem,
            this.위치문자열대화상자ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.동작ToolStripMenuItem.Name = "동작ToolStripMenuItem";
            this.동작ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.동작ToolStripMenuItem.Text = "동작";
            // 
            // 폰트대화상자ToolStripMenuItem
            // 
            this.폰트대화상자ToolStripMenuItem.Name = "폰트대화상자ToolStripMenuItem";
            this.폰트대화상자ToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.폰트대화상자ToolStripMenuItem.Text = "폰트대화상자";
            this.폰트대화상자ToolStripMenuItem.Click += new System.EventHandler(this.폰트대화상자ToolStripMenuItem_Click);
            // 
            // 색대화상자ToolStripMenuItem
            // 
            this.색대화상자ToolStripMenuItem.Name = "색대화상자ToolStripMenuItem";
            this.색대화상자ToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.색대화상자ToolStripMenuItem.Text = "색대화상자";
            this.색대화상자ToolStripMenuItem.Click += new System.EventHandler(this.색대화상자ToolStripMenuItem_Click);
            // 
            // 위치문자열대화상자ToolStripMenuItem
            // 
            this.위치문자열대화상자ToolStripMenuItem.Name = "위치문자열대화상자ToolStripMenuItem";
            this.위치문자열대화상자ToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.위치문자열대화상자ToolStripMenuItem.Text = "위치-문자열대화상자";
            this.위치문자열대화상자ToolStripMenuItem.Click += new System.EventHandler(this.위치문자열대화상자ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ToolStripMenuItem 동작ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폰트대화상자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색대화상자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 위치문자열대화상자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

