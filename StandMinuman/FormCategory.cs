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
	public partial class FormCategory : Form
	{
		public FormCategory()
		{
			InitializeComponent();
		}

		private void kembaliKeMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormCategory_Load(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand("SELECT id_category_minuman AS 'Id', nama AS 'Nama', STATUS AS 'Status' FROM category_minuman WHERE id_category_minuman <> 1;", Koneksi.getConn());
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridViewCategory.DataSource = null;
				dataGridViewCategory.DataSource = dt;
			}
			catch (Exception)
			{
				MessageBox.Show("Gagal Load Table Category Minuman!");
			}
			comboBoxAktif.SelectedIndex = 0;
		}

		private void textBoxUsername_TextChanged(object sender, EventArgs e)
		{
			AutogenIDCategory();
		}
		void AutogenIDCategory()
		{
			if (btnInsert.Enabled)
			{
				MySqlCommand cmd = new MySqlCommand("select count(*) from category_minuman;", Koneksi.getConn());
				string count_data = cmd.ExecuteScalar().ToString();
				string newID = (int.Parse(count_data) + 1).ToString();
				textBoxId.Text = newID;
			}
		}
		void Clear() {
			try
			{
				MySqlCommand cmd = new MySqlCommand("SELECT id_category_minuman AS 'Id', nama AS 'Nama', STATUS AS 'Status' FROM category_minuman WHERE id_category_minuman <> 1;", Koneksi.getConn());
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridViewCategory.DataSource = null;
				dataGridViewCategory.DataSource = dt;
			}
			catch (Exception)
			{
				MessageBox.Show("Gagal Load Table Category Minuman!");
			}
			textBoxSearch.Text = "";
			comboBoxAktif.SelectedIndex = 0;
			textBoxId.Text = "";
			tbnamaCategory.Text = "";
			btnInsert.Enabled = true;
			buttonClearSearch.Enabled = true;
			buttonUpdate.Enabled = false;
			buttonDelete.Enabled = false;
		}
		private void btnInsert_Click(object sender, EventArgs e)
		{
			if (!tbnamaCategory.Text.Equals(""))
			{
				MySqlCommand cmd = new MySqlCommand($"INSERT INTO category_minuman(id_category_minuman,nama,status) VALUES ('{textBoxId.Text}','{tbnamaCategory.Text}',1)", Koneksi.getConn());
				cmd.ExecuteNonQuery();
				MessageBox.Show("Insert berhasil!");
				Clear();
			}
			else
			{
				MessageBox.Show("Semua Field Harus terisi!");
			}
		}

		private void dataGridViewCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				buttonUpdate.Enabled = true;
				btnInsert.Enabled = false;
				buttonDelete.Enabled = true;
				textBoxId.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
				tbnamaCategory.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
				int status = int.Parse(dataGridViewCategory.Rows[e.RowIndex].Cells[2].Value.ToString());
				if (status == 0)
				{
					buttonDelete.Text = "Restore";
				}
				else
				{
					buttonDelete.Text = "Delete";
				}

			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (tbnamaCategory.Text != "")
			{
				if (textBoxId.Text != "1")
				{
					try
					{
						MySqlCommand cmd = new MySqlCommand();

						cmd.Connection = Koneksi.getConn();

						cmd.CommandText = "UPDATE category_minuman set nama = @nama WHERE id_category_minuman= " + textBoxId.Text;
						cmd.Parameters.Add(new MySqlParameter("@nama", tbnamaCategory.Text));
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
					MessageBox.Show("No Topping tidak boleh di edit!");
				}
			}
			else
			{
				MessageBox.Show("Isikan nama Category Minuman!");
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (buttonDelete.Text == "Delete")
			{
				if (textBoxId.Text != "1")
				{
					try
					{
						MySqlCommand cmd = new MySqlCommand();

						cmd.Connection = Koneksi.getConn();

						cmd.CommandText = "UPDATE category_minuman set status = 0 WHERE id_category_minuman = " + textBoxId.Text;

						cmd.ExecuteNonQuery();

						cmd = new MySqlCommand();

						cmd.Connection = Koneksi.getConn();

						cmd.CommandText = "UPDATE minuman set id_category_minuman = 1 WHERE id_category_minuman = " + textBoxId.Text;

						cmd.ExecuteNonQuery();

						MessageBox.Show("Category dihapus!");
						Clear();
					}
					catch (Exception a)
					{
						MessageBox.Show(a.Message);

					}
				}
				else
				{
					MessageBox.Show("No Category tidak boleh di delete!");
				}
			}
			else
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand();

					cmd.Connection = Koneksi.getConn();

					cmd.CommandText = "UPDATE category_minuman set status = 1 WHERE id_category_minuman =  " + textBoxId.Text;

					cmd.ExecuteNonQuery();

					MessageBox.Show("Category dikembalikan!");
					Clear();
				}
				catch (Exception a)
				{
					MessageBox.Show(a.Message);

				}
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void buttonClearSearch_Click(object sender, EventArgs e)
		{
			textBoxSearch.Text = "";
			comboBoxAktif.SelectedIndex = 0;
		}

		public void loadCategory()
		{
			string status;
			if (comboBoxAktif.SelectedIndex == 0)
			{
				status = "and status <> 2";
			}
			else if (comboBoxAktif.SelectedIndex == 1)
			{
				status = "and status = 1";
			}
			else
			{
				status = "and status = 0";
			}
			string query = "SELECT id_category_minuman AS 'Id', nama AS 'Nama', STATUS AS 'Status' FROM category_minuman WHERE id_category_minuman <> 1 " + status;
			if (textBoxSearch.Text != "")
			{
				query += " and nama like '%" + textBoxSearch.Text + "%'";
			}
			try
			{
				MySqlCommand cmd = new MySqlCommand(query, Koneksi.getConn());
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridViewCategory.DataSource = null;
				dataGridViewCategory.DataSource = dt;
			}
			catch (Exception)
			{
				MessageBox.Show("Gagal Load Table Category!");
			}
		}


		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			loadCategory();	
		}

		private void comboBoxAktif_SelectedIndexChanged(object sender, EventArgs e)
		{
			loadCategory();
		}
	}
}
