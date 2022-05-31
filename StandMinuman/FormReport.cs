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
	public partial class FormReport : Form
	{
		int report = -1;
		public FormReport()
		{
			InitializeComponent();
		}

		private void kembaliKeMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        public void reportTopping()
        {
            if (dateTimePickerAwal.Value < dateTimePickerAkhir.Value)
            {
                CrystalReportBanyakTopping rpt = new CrystalReportBanyakTopping();
                rpt.SetParameterValue("TanggalAwal", dateTimePickerAwal.Value);
                rpt.SetParameterValue("TanggalAkhir", dateTimePickerAkhir.Value);
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = rpt;
            }
            else
            {
                MessageBox.Show("Tanggal akhir harus lebih besar dari tanggal awal!");
            }
        }

        public void reportSellerTertinggi()
        {
            if (dateTimePickerAwal.Value < dateTimePickerAkhir.Value)
            {
                CrystalReportSellerTinggi rpt = new CrystalReportSellerTinggi();
                rpt.SetParameterValue("TanggalAwal", dateTimePickerAwal.Value);
                rpt.SetParameterValue("TanggalAkhir", dateTimePickerAkhir.Value);
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = rpt;
            }
            else
            {
                MessageBox.Show("Tanggal akhir harus lebih besar dari tanggal awal!");
            }
        }

        public void reportSellerTerendah()
        {
            if (dateTimePickerAwal.Value < dateTimePickerAkhir.Value)
            {
                CrystalReportSellerTerendah rpt = new CrystalReportSellerTerendah();
                rpt.SetParameterValue("TanggalAwal", dateTimePickerAwal.Value);
                rpt.SetParameterValue("TanggalAkhir", dateTimePickerAkhir.Value);
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = rpt;
            }
            else
            {
                MessageBox.Show("Tanggal akhir harus lebih besar dari tanggal awal!");
            }
        }

        public void reportStokMinuman()
        {
            if (dateTimePickerAwal.Value < dateTimePickerAkhir.Value)
            {
                if (numericUpDownStok.Value > 0)
                {
                    CrystalReportStokMinuman rpt = new CrystalReportStokMinuman();
                    rpt.SetParameterValue("TanggalAwal", dateTimePickerAwal.Value);
                    rpt.SetParameterValue("TanggalAkhir", dateTimePickerAkhir.Value);
                    rpt.SetParameterValue("bawah", Convert.ToInt32(numericUpDownStok.Value));
                    crystalReportViewer1.ReportSource = null;
                    crystalReportViewer1.ReportSource = rpt;
                }
                else
                {
                    MessageBox.Show("Stok minuman harus lebih dari 0!");
                }
            }
            else
            {
                MessageBox.Show("Tanggal akhir harus lebih besar dari tanggal awal!");
            }
        }

        public void reportMinuman()
        {
            if (dateTimePickerAwal.Value < dateTimePickerAkhir.Value)
            {
                if (comboBoxMinuman.SelectedIndex == 0)
                {
                    CrystalReportMinumanTertinggi rpt = new CrystalReportMinumanTertinggi();
                    rpt.SetParameterValue("TanggalAwal", dateTimePickerAwal.Value);
                    rpt.SetParameterValue("TanggalAkhir", dateTimePickerAkhir.Value);
                    crystalReportViewer1.ReportSource = null;
                    crystalReportViewer1.ReportSource = rpt;
                }
                else
                {
                    CrystalReportMinumanTerendah rpt = new CrystalReportMinumanTerendah();
                    rpt.SetParameterValue("TanggalAwal", dateTimePickerAwal.Value);
                    rpt.SetParameterValue("TanggalAkhir", dateTimePickerAkhir.Value);
                    crystalReportViewer1.ReportSource = null;
                    crystalReportViewer1.ReportSource = rpt;
                }
            }
            else
            {
                MessageBox.Show("Tanggal akhir harus lebih besar dari tanggal awal!");
            }
        }

        private void toppingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report = 5;
            tampilToolStripMenuItem.Enabled = true;
            resetBold();
            toppingToolStripMenuItem.Font = new Font(toppingToolStripMenuItem.Font, FontStyle.Bold);
        }

        public void resetBold()
        {
            sellerpenjualanTertinggiToolStripMenuItem.Font = new Font(sellerpenjualanTertinggiToolStripMenuItem.Font, FontStyle.Regular);
            sellerpenjualanTerendahToolStripMenuItem.Font = new Font(sellerpenjualanTerendahToolStripMenuItem.Font, FontStyle.Regular);
            minumanToolStripMenuItem.Font = new Font(minumanToolStripMenuItem.Font, FontStyle.Regular);
            stokMinumanToolStripMenuItem.Font = new Font(stokMinumanToolStripMenuItem.Font, FontStyle.Regular);
            toppingToolStripMenuItem.Font = new Font(toppingToolStripMenuItem.Font, FontStyle.Regular);
            comboBoxMinuman.Enabled = false;
            numericUpDownStok.Enabled = false;
            comboBoxMinuman.SelectedIndex = -1;
        }

        private void tampilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (report != -1)
            {
                tampilToolStripMenuItem.Text = "Loading...";
                if (report == 1)
                {
                    reportSellerTertinggi();
                }
                else if (report == 2)
                {
                    reportSellerTerendah();
                }
                else if (report == 3)
                {
                    reportMinuman();
                }
                else if (report == 4)
                {
                    reportStokMinuman();
                }
                else
                {
                    reportTopping();
                }
                tampilToolStripMenuItem.Text = "Tampil";
            }
            else
            {
                MessageBox.Show("Test");
            }
        }



        private void sellerpenjualanTertinggiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report = 1;
            tampilToolStripMenuItem.Enabled = true;
            resetBold();
            sellerpenjualanTertinggiToolStripMenuItem.Font = new Font(sellerpenjualanTertinggiToolStripMenuItem.Font, FontStyle.Bold);

        }

        private void sellerpenjualanTerendahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report = 2;
            tampilToolStripMenuItem.Enabled = true;
            resetBold();
            sellerpenjualanTerendahToolStripMenuItem.Font = new Font(sellerpenjualanTerendahToolStripMenuItem.Font, FontStyle.Bold);

        }

        private void minumanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report = 3;
            tampilToolStripMenuItem.Enabled = true;
            resetBold();
            comboBoxMinuman.Enabled = true;
            comboBoxMinuman.SelectedIndex = 0;
            minumanToolStripMenuItem.Font = new Font(minumanToolStripMenuItem.Font, FontStyle.Bold);
        }

        private void stokMinumanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report = 4;
            tampilToolStripMenuItem.Enabled = true;
            resetBold();
            numericUpDownStok.Enabled = true;
            stokMinumanToolStripMenuItem.Font = new Font(stokMinumanToolStripMenuItem.Font, FontStyle.Bold);
        }
    }
}
