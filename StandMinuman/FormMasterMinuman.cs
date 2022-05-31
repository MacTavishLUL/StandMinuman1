using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StandMinuman
{
	public partial class FormMasterMinuman : Form
	{
		public FormMasterMinuman()
		{
			InitializeComponent();
		}

		private void FormMasterMinuman_Load(object sender, EventArgs e)
		{
			comboBoxAktif.SelectedIndex = 0;
			try
			{
				MySqlCommand cmd = new MySqlCommand("SELECT m.id_minuman AS 'Id', m.nama AS 'Nama', m.stok AS 'Stok', FORMAT(m.harga,0,'id_ID') AS 'Harga', m.id_category_minuman AS 'Id_Category', c.nama AS 'Category', m.status AS 'Status' FROM minuman m, category_minuman c WHERE m.id_category_minuman = c.id_category_minuman order by 1", Koneksi.getConn());
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridViewMinuman.DataSource = null;
				dataGridViewMinuman.DataSource = dt;
				dataGridViewMinuman.Columns[4].Visible = false;
			}
			catch (Exception)
			{
				MessageBox.Show("Gagal Load Table Minuman!");
			}
			loadCategory();
		}

		public void loadCategory()
        {
            try
            {
				MySqlCommand cmd = new MySqlCommand("SELECT id_category_minuman AS 'member', nama AS 'display' FROM category_minuman WHERE STATUS = 1", Koneksi.getConn());
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				comboBoxCategory.DataSource = null;
				comboBoxCategory.DataSource = dt;
				comboBoxCategory.DisplayMember = "display";
				comboBoxCategory.ValueMember = "member";
				comboBoxCategory.SelectedIndex = 0;
			}
            catch (Exception)
            {
				MessageBox.Show("Gagal Load Category!");
			}
			
		}

		private void kembaliKeMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonClearSearch_Click(object sender, EventArgs e)
		{
			ClearSearch();
		}
		public void ClearSearch()
		{
			textBoxSearch.Text = "";
			comboBoxAktif.SelectedIndex = 0;
			loadMinuman();
		}
		public void loadMinuman()
		{
			string status;
			if (comboBoxAktif.SelectedIndex == 0)
			{
				status = "and m.status <> 2";
			}
			else if (comboBoxAktif.SelectedIndex == 1)
			{
				status = "and m.status = 1";
			}
			else
			{
				status = "and m.status = 0";
			}
			string query = "SELECT m.id_minuman AS 'Id', m.nama AS 'Nama', m.stok AS 'Stok', FORMAT(m.harga,0,'id_ID') AS 'Harga', m.id_category_minuman AS 'Id_Category', c.nama AS 'Category', m.status AS 'Status' FROM minuman m, category_minuman c WHERE m.id_category_minuman = c.id_category_minuman " + status;
			if (textBoxSearch.Text != "")
			{
				query += " and m.nama like '%" + textBoxSearch.Text + "%'";
			}
			query += " order by 1";
			try
			{
				MySqlCommand cmd = new MySqlCommand(query, Koneksi.getConn());
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridViewMinuman.DataSource = null;
				dataGridViewMinuman.DataSource = dt;
				dataGridViewMinuman.Columns[4].Visible = false;
			}
			catch (Exception)
			{
				MessageBox.Show("Gagal Load Table Minuman!");
			}
		}

		private void comboBoxAktif_SelectedIndexChanged(object sender, EventArgs e)
		{
			loadMinuman();
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			loadMinuman();
		}

		void AutogenIDMinuman() {
			if (btnInsert.Enabled)
			{
				MySqlCommand cmd = new MySqlCommand("select count(*) from minuman;",Koneksi.getConn());
				string count_data = cmd.ExecuteScalar().ToString();
				string newIDMinuman = (int.Parse(count_data)+1).ToString();
				tbidminuman.Text = newIDMinuman;
			}
		}

		private void tbnama_TextChanged(object sender, EventArgs e)
		{
			AutogenIDMinuman();
		}

		private void nUDStok_ValueChanged(object sender, EventArgs e)
		{
			AutogenIDMinuman();
		}

		private void nUPHarga_ValueChanged(object sender, EventArgs e)
		{
			AutogenIDMinuman();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}
		void Clear() {
			nUDStok.Value = 0;
			nUPHarga.Value = 0;
			comboBoxCategory.SelectedIndex = 0;
			tbnama.Text = "";
			btnInsert.Enabled = true;
			btnUpdate.Enabled = false;
			btnDelete.Enabled = false;
			btnClear.Enabled = true;
			loadMinuman();
			tbidminuman.Text = "";
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			if (tbidminuman.Text != "" || tbnama.Text != "")
			{
				if (nUDStok.Value > 0)
				{
					if (nUPHarga.Value > 0)
					{
						try
						{
							MySqlCommand cmd = new MySqlCommand($"INSERT INTO minuman(id_minuman,nama,stok,harga,id_category_minuman,status) VALUES ('{tbidminuman.Text}','{tbnama.Text}', '{nUDStok.Value}','{nUPHarga.Value}','{comboBoxCategory.SelectedValue}',1)", Koneksi.getConn());
							cmd.ExecuteNonQuery();
							MessageBox.Show("Insert berhasil!");
							Clear();
						}
						catch (Exception a)
						{
							MessageBox.Show(a.Message);
						}
					}
					else {
						MessageBox.Show("Harga harus lebih dari 0!");
					}
				}
				else {
					MessageBox.Show("Stok harus lebih dari 0!");
				}
			}
			else {
				MessageBox.Show("Field belum diisi!");
			}
		}

		private void dataGridViewMinuman_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex>-1)
			{
				btnUpdate.Enabled = true;
				btnInsert.Enabled = false;
				btnDelete.Enabled = true;
				tbidminuman.Text= dataGridViewMinuman.Rows[e.RowIndex].Cells[0].Value.ToString();
				tbnama.Text= dataGridViewMinuman.Rows[e.RowIndex].Cells[1].Value.ToString();
				nUDStok.Value= int.Parse(dataGridViewMinuman.Rows[e.RowIndex].Cells[2].Value.ToString());
				nUPHarga.Value= FormLogin.removeThousandSep(dataGridViewMinuman.Rows[e.RowIndex].Cells[3].Value.ToString());
				comboBoxCategory.SelectedValue = Convert.ToInt32(dataGridViewMinuman.Rows[e.RowIndex].Cells[4].Value.ToString());
				int status= int.Parse(dataGridViewMinuman.Rows[e.RowIndex].Cells[6].Value.ToString());
				if (status == 0)
				{
					btnDelete.Text = "Restore";
				}
				else {
					btnDelete.Text = "Delete";
				}

			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (tbidminuman.Text != "" || tbnama.Text != "")
			{
				if (nUDStok.Value > 0)
				{
					if (nUPHarga.Value > 0)
					{
						try
						{
							MySqlCommand cmd = new MySqlCommand($"Update minuman set nama='{tbnama.Text}',stok='{nUDStok.Value}',harga='{nUPHarga.Value}',id_category_minuman='{comboBoxCategory.SelectedValue}' where id_minuman='{tbidminuman.Text}';", Koneksi.getConn());
							cmd.ExecuteNonQuery();
							MessageBox.Show("Update berhasil!");
							Clear();
						}
						catch (Exception a)
						{
							MessageBox.Show(a.Message);
						}
					}
					else
					{
						MessageBox.Show("Harga harus lebih dari 0!");
					}
				}
				else
				{
					MessageBox.Show("Stok harus lebih dari 0!");
				}
			}
			else
			{
				MessageBox.Show("Field belum diisi!");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (btnDelete.Text.Equals("Delete"))
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand($"UPDATE minuman set status = 0 WHERE id_minuman = '{tbidminuman.Text}'", Koneksi.getConn());
					cmd.ExecuteNonQuery();
					MessageBox.Show("Minuman Berhasil Dihapus!");
					Clear();
				}
				catch (Exception a)
				{
					MessageBox.Show(a.Message);
				}
			}
			else {
				try
				{
					MySqlCommand cmd = new MySqlCommand($"UPDATE minuman set status = 1 WHERE id_minuman = '{tbidminuman.Text}'", Koneksi.getConn());
					cmd.ExecuteNonQuery();
					MessageBox.Show("Minuman Berhasil Dikembalikan!");
					Clear();
				}
				catch (Exception a)
				{
					MessageBox.Show(a.Message);
				}
			}
		}

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Easter Egg");
        }
    }
}
