
namespace StandMinuman
{
    partial class FormTransaksi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemHello = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewMinuman = new System.Windows.Forms.DataGridView();
            this.dataGridViewTopping = new System.Windows.Forms.DataGridView();
            this.dataGridViewKeranjang = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMinuman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaMinuman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTopping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaTopping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalMinuman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalTopping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchMinuman = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearchTopping = new System.Windows.Forms.TextBox();
            this.labelNamaMinuman = new System.Windows.Forms.Label();
            this.labelNamaTopping = new System.Windows.Forms.Label();
            this.numericUpDownJumlah = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonHapusSemua = new System.Windows.Forms.Button();
            this.labelNota = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonBeli = new System.Windows.Forms.Button();
            this.buttonClearSelection = new System.Windows.Forms.Button();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHello,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemHello
            // 
            this.toolStripMenuItemHello.Name = "toolStripMenuItemHello";
            this.toolStripMenuItemHello.Size = new System.Drawing.Size(62, 23);
            this.toolStripMenuItemHello.Text = "Halo, -";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // dataGridViewMinuman
            // 
            this.dataGridViewMinuman.AllowUserToAddRows = false;
            this.dataGridViewMinuman.AllowUserToDeleteRows = false;
            this.dataGridViewMinuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMinuman.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewMinuman.Name = "dataGridViewMinuman";
            this.dataGridViewMinuman.ReadOnly = true;
            this.dataGridViewMinuman.RowHeadersVisible = false;
            this.dataGridViewMinuman.RowHeadersWidth = 62;
            this.dataGridViewMinuman.Size = new System.Drawing.Size(551, 194);
            this.dataGridViewMinuman.TabIndex = 1;
            this.dataGridViewMinuman.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMinuman_CellDoubleClick);
            // 
            // dataGridViewTopping
            // 
            this.dataGridViewTopping.AllowUserToAddRows = false;
            this.dataGridViewTopping.AllowUserToDeleteRows = false;
            this.dataGridViewTopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopping.Location = new System.Drawing.Point(569, 56);
            this.dataGridViewTopping.Name = "dataGridViewTopping";
            this.dataGridViewTopping.ReadOnly = true;
            this.dataGridViewTopping.RowHeadersVisible = false;
            this.dataGridViewTopping.RowHeadersWidth = 62;
            this.dataGridViewTopping.Size = new System.Drawing.Size(419, 194);
            this.dataGridViewTopping.TabIndex = 2;
            this.dataGridViewTopping.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTopping_CellDoubleClick);
            // 
            // dataGridViewKeranjang
            // 
            this.dataGridViewKeranjang.AllowUserToAddRows = false;
            this.dataGridViewKeranjang.AllowUserToDeleteRows = false;
            this.dataGridViewKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeranjang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.IdMinuman,
            this.NamaMinuman,
            this.IdTopping,
            this.NamaTopping,
            this.Jumlah,
            this.SubtotalMinuman,
            this.SubtotalTopping,
            this.Subtotal});
            this.dataGridViewKeranjang.Location = new System.Drawing.Point(12, 380);
            this.dataGridViewKeranjang.Name = "dataGridViewKeranjang";
            this.dataGridViewKeranjang.ReadOnly = true;
            this.dataGridViewKeranjang.RowHeadersVisible = false;
            this.dataGridViewKeranjang.RowHeadersWidth = 62;
            this.dataGridViewKeranjang.Size = new System.Drawing.Size(854, 259);
            this.dataGridViewKeranjang.TabIndex = 3;
            this.dataGridViewKeranjang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKeranjang_CellDoubleClick);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.No.FillWeight = 40F;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 8;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // IdMinuman
            // 
            this.IdMinuman.HeaderText = "IdMinuman";
            this.IdMinuman.MinimumWidth = 8;
            this.IdMinuman.Name = "IdMinuman";
            this.IdMinuman.ReadOnly = true;
            this.IdMinuman.Visible = false;
            this.IdMinuman.Width = 150;
            // 
            // NamaMinuman
            // 
            this.NamaMinuman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaMinuman.HeaderText = "Nama Minuman";
            this.NamaMinuman.MinimumWidth = 8;
            this.NamaMinuman.Name = "NamaMinuman";
            this.NamaMinuman.ReadOnly = true;
            // 
            // IdTopping
            // 
            this.IdTopping.HeaderText = "IdTopping";
            this.IdTopping.MinimumWidth = 8;
            this.IdTopping.Name = "IdTopping";
            this.IdTopping.ReadOnly = true;
            this.IdTopping.Visible = false;
            this.IdTopping.Width = 150;
            // 
            // NamaTopping
            // 
            this.NamaTopping.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaTopping.HeaderText = "Nama Topping";
            this.NamaTopping.MinimumWidth = 8;
            this.NamaTopping.Name = "NamaTopping";
            this.NamaTopping.ReadOnly = true;
            // 
            // Jumlah
            // 
            this.Jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Jumlah.DefaultCellStyle = dataGridViewCellStyle1;
            this.Jumlah.FillWeight = 80F;
            this.Jumlah.HeaderText = "Jumlah";
            this.Jumlah.MinimumWidth = 8;
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.ReadOnly = true;
            // 
            // SubtotalMinuman
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SubtotalMinuman.DefaultCellStyle = dataGridViewCellStyle2;
            this.SubtotalMinuman.HeaderText = "Subtotal Minuman";
            this.SubtotalMinuman.Name = "SubtotalMinuman";
            this.SubtotalMinuman.ReadOnly = true;
            // 
            // SubtotalTopping
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SubtotalTopping.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubtotalTopping.HeaderText = "Subtotal Topping";
            this.SubtotalTopping.Name = "SubtotalTopping";
            this.SubtotalTopping.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 8;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Daftar Minuman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(566, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Daftar Topping";
            // 
            // textBoxSearchMinuman
            // 
            this.textBoxSearchMinuman.Location = new System.Drawing.Point(390, 28);
            this.textBoxSearchMinuman.Name = "textBoxSearchMinuman";
            this.textBoxSearchMinuman.Size = new System.Drawing.Size(173, 24);
            this.textBoxSearchMinuman.TabIndex = 6;
            this.textBoxSearchMinuman.TextChanged += new System.EventHandler(this.textBoxSearchMinuman_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(321, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search :";
            // 
            // textBoxSearchTopping
            // 
            this.textBoxSearchTopping.Location = new System.Drawing.Point(815, 30);
            this.textBoxSearchTopping.Name = "textBoxSearchTopping";
            this.textBoxSearchTopping.Size = new System.Drawing.Size(173, 24);
            this.textBoxSearchTopping.TabIndex = 8;
            this.textBoxSearchTopping.TextChanged += new System.EventHandler(this.textBoxSearchTopping_TextChanged);
            // 
            // labelNamaMinuman
            // 
            this.labelNamaMinuman.AutoSize = true;
            this.labelNamaMinuman.Location = new System.Drawing.Point(15, 256);
            this.labelNamaMinuman.Name = "labelNamaMinuman";
            this.labelNamaMinuman.Size = new System.Drawing.Size(130, 18);
            this.labelNamaMinuman.TabIndex = 10;
            this.labelNamaMinuman.Text = "Nama Minuman : -";
            // 
            // labelNamaTopping
            // 
            this.labelNamaTopping.AutoSize = true;
            this.labelNamaTopping.Location = new System.Drawing.Point(15, 284);
            this.labelNamaTopping.Name = "labelNamaTopping";
            this.labelNamaTopping.Size = new System.Drawing.Size(130, 18);
            this.labelNamaTopping.TabIndex = 11;
            this.labelNamaTopping.Text = "Nama Topping   : -";
            // 
            // numericUpDownJumlah
            // 
            this.numericUpDownJumlah.Location = new System.Drawing.Point(141, 311);
            this.numericUpDownJumlah.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownJumlah.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownJumlah.Name = "numericUpDownJumlah";
            this.numericUpDownJumlah.Size = new System.Drawing.Size(161, 24);
            this.numericUpDownJumlah.TabIndex = 12;
            this.numericUpDownJumlah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Jumlah               :";
            // 
            // buttonTambah
            // 
            this.buttonTambah.AutoSize = true;
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(872, 380);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(116, 36);
            this.buttonTambah.TabIndex = 14;
            this.buttonTambah.Text = "Add";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(872, 422);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(116, 36);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.AutoSize = true;
            this.buttonHapus.Enabled = false;
            this.buttonHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.Location = new System.Drawing.Point(872, 464);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(116, 36);
            this.buttonHapus.TabIndex = 16;
            this.buttonHapus.Text = "Delete";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonHapusSemua
            // 
            this.buttonHapusSemua.AutoSize = true;
            this.buttonHapusSemua.Enabled = false;
            this.buttonHapusSemua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapusSemua.Location = new System.Drawing.Point(872, 507);
            this.buttonHapusSemua.Name = "buttonHapusSemua";
            this.buttonHapusSemua.Size = new System.Drawing.Size(116, 36);
            this.buttonHapusSemua.TabIndex = 18;
            this.buttonHapusSemua.Text = "Delete All";
            this.buttonHapusSemua.UseVisualStyleBackColor = true;
            this.buttonHapusSemua.Click += new System.EventHandler(this.buttonHapusSemua_Click);
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNota.Location = new System.Drawing.Point(14, 357);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(131, 20);
            this.labelNota.TabIndex = 19;
            this.labelNota.Text = "Nomor Nota      : -";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTotal.Location = new System.Drawing.Point(640, 357);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(94, 20);
            this.labelTotal.TabIndex = 20;
            this.labelTotal.Text = "Total : Rp. 0";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonBeli
            // 
            this.buttonBeli.AutoSize = true;
            this.buttonBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeli.Location = new System.Drawing.Point(872, 603);
            this.buttonBeli.Name = "buttonBeli";
            this.buttonBeli.Size = new System.Drawing.Size(116, 36);
            this.buttonBeli.TabIndex = 21;
            this.buttonBeli.Text = "BELI";
            this.buttonBeli.UseVisualStyleBackColor = true;
            this.buttonBeli.Click += new System.EventHandler(this.buttonBeli_Click);
            // 
            // buttonClearSelection
            // 
            this.buttonClearSelection.AutoSize = true;
            this.buttonClearSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearSelection.Location = new System.Drawing.Point(872, 549);
            this.buttonClearSelection.Name = "buttonClearSelection";
            this.buttonClearSelection.Size = new System.Drawing.Size(116, 36);
            this.buttonClearSelection.TabIndex = 22;
            this.buttonClearSelection.Text = "Clear";
            this.buttonClearSelection.UseVisualStyleBackColor = true;
            this.buttonClearSelection.Click += new System.EventHandler(this.buttonClearSelection_Click);
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonClearSearch.Location = new System.Drawing.Point(872, 256);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(116, 36);
            this.buttonClearSearch.TabIndex = 53;
            this.buttonClearSearch.Text = "Clear Search";
            this.buttonClearSearch.UseVisualStyleBackColor = true;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Semua",
            "Aktif",
            "Tidak Aktif"});
            this.comboBoxCategory.Location = new System.Drawing.Point(141, 26);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(161, 26);
            this.comboBoxCategory.TabIndex = 55;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::StandMinuman.Properties.Resources.icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(992, 647);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonClearSearch);
            this.Controls.Add(this.buttonClearSelection);
            this.Controls.Add(this.buttonBeli);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelNota);
            this.Controls.Add(this.buttonHapusSemua);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownJumlah);
            this.Controls.Add(this.labelNamaTopping);
            this.Controls.Add(this.labelNamaMinuman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSearchTopping);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSearchMinuman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKeranjang);
            this.Controls.Add(this.dataGridViewTopping);
            this.Controls.Add(this.dataGridViewMinuman);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormTransaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMinuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHello;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewMinuman;
        private System.Windows.Forms.DataGridView dataGridViewTopping;
        private System.Windows.Forms.DataGridView dataGridViewKeranjang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearchMinuman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearchTopping;
        private System.Windows.Forms.Label labelNamaMinuman;
        private System.Windows.Forms.Label labelNamaTopping;
        private System.Windows.Forms.NumericUpDown numericUpDownJumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonHapusSemua;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonBeli;
        private System.Windows.Forms.Button buttonClearSelection;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMinuman;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaMinuman;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTopping;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaTopping;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalMinuman;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalTopping;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}