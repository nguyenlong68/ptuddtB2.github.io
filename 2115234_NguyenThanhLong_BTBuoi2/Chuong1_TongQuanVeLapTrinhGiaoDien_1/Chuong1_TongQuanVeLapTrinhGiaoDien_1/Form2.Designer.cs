namespace Chuong1_TongQuanVeLapTrinhGiaoDien_1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.bàiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTrang35 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTrang42 = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Location = new System.Drawing.Point(0, 36);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuStrip2
			// 
			this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiTậpToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(800, 36);
			this.menuStrip2.TabIndex = 1;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// bàiTậpToolStripMenuItem
			// 
			this.bàiTậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTrang35,
            this.tsmiTrang42});
			this.bàiTậpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.bàiTậpToolStripMenuItem.Name = "bàiTậpToolStripMenuItem";
			this.bàiTậpToolStripMenuItem.Size = new System.Drawing.Size(86, 32);
			this.bàiTậpToolStripMenuItem.Text = "Bài tập";
			// 
			// tsmiTrang35
			// 
			this.tsmiTrang35.Name = "tsmiTrang35";
			this.tsmiTrang35.Size = new System.Drawing.Size(224, 26);
			this.tsmiTrang35.Text = "Trang 35";
			this.tsmiTrang35.Click += new System.EventHandler(this.tsmiTrang35_Click);
			// 
			// tsmiTrang42
			// 
			this.tsmiTrang42.Name = "tsmiTrang42";
			this.tsmiTrang42.Size = new System.Drawing.Size(224, 26);
			this.tsmiTrang42.Text = "Trang 42";
			this.tsmiTrang42.Click += new System.EventHandler(this.tsmiTrang42_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Slides không có teang 52 - 60";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip2);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form2";
			this.Text = "Form2";
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem bàiTậpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiTrang35;
		private System.Windows.Forms.ToolStripMenuItem tsmiTrang42;
		private System.Windows.Forms.Label label1;
	}
}