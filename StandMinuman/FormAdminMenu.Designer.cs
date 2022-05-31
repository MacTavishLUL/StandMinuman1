
namespace StandMinuman
{
	partial class FormAdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterMinumanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToppingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterSellerToolStripMenuItem,
            this.masterMinumanToolStripMenuItem,
            this.masterToppingToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.masterCategoryToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterSellerToolStripMenuItem
            // 
            this.masterSellerToolStripMenuItem.Name = "masterSellerToolStripMenuItem";
            this.masterSellerToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.masterSellerToolStripMenuItem.Text = "Master Seller";
            this.masterSellerToolStripMenuItem.Click += new System.EventHandler(this.masterSellerToolStripMenuItem_Click);
            // 
            // masterMinumanToolStripMenuItem
            // 
            this.masterMinumanToolStripMenuItem.Name = "masterMinumanToolStripMenuItem";
            this.masterMinumanToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.masterMinumanToolStripMenuItem.Text = "Master Minuman";
            this.masterMinumanToolStripMenuItem.Click += new System.EventHandler(this.masterMinumanToolStripMenuItem_Click);
            // 
            // masterToppingToolStripMenuItem
            // 
            this.masterToppingToolStripMenuItem.Name = "masterToppingToolStripMenuItem";
            this.masterToppingToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.masterToppingToolStripMenuItem.Text = "Master Topping";
            this.masterToppingToolStripMenuItem.Click += new System.EventHandler(this.masterToppingToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // masterCategoryToolStripMenuItem
            // 
            this.masterCategoryToolStripMenuItem.Name = "masterCategoryToolStripMenuItem";
            this.masterCategoryToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.masterCategoryToolStripMenuItem.Text = "Master Category Minuman";
            this.masterCategoryToolStripMenuItem.Click += new System.EventHandler(this.masterCategoryToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.laporanToolStripMenuItem.Text = "Laporan";
            this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stand <Name Placeholder>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem masterSellerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem masterMinumanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem masterToppingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem masterCategoryToolStripMenuItem;
	}
}