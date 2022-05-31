using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandMinuman
{
	public partial class FormAdminMenu : Form
	{
		public FormAdminMenu()
		{
			InitializeComponent();
		}

		private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void masterSellerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormMasterSeller frm = new FormMasterSeller();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		private void masterMinumanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormMasterMinuman frm = new FormMasterMinuman();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		private void masterToppingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormMasterTopping frm = new FormMasterTopping();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormReport frm = new FormReport();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}

		private void masterCategoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormCategory frm = new FormCategory();
			this.Hide();
			frm.ShowDialog();
			this.Show();
		}
	}
}
