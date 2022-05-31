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
	public partial class FormMasterSeller : Form
	{
		DataTable dt;
		public FormMasterSeller()
		{
			InitializeComponent();
			
		}

		private void FormMasterSeller_Load(object sender, EventArgs e)
		{
			comboBoxAktif.SelectedIndex = 0;
			loadUsers();
		}

		public void loadUsers()
        {
			string query = "SELECT id_users AS 'ID',username AS 'Username',PASSWORD AS 'Password',nama AS 'Nama', STATUS AS 'Status' from users where privilege = 1 ";
			if (comboBoxAktif.SelectedIndex == 0)
			{
				query += "and status <> 2";
			}
			else if (comboBoxAktif.SelectedIndex == 1)
			{
				query += "and status = 1";
			}
			else
			{
				query += "and status = 0";
			}

			if (textBoxSearch.Text != "")
			{
				query += $" AND (nama LIKE '%{textBoxSearch.Text}%' or username LIKE '%{textBoxSearch.Text}%')";
			}
			try
			{
				MySqlCommand cmd = new MySqlCommand(query, Koneksi.getConn());
				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				dt = new DataTable();
				da.Fill(dt);
				dataGridViewUser.DataSource = null;
				dataGridViewUser.DataSource = dt;
			}
			catch (Exception)
			{
				MessageBox.Show("Gagal Load Table Seller!");
			}
		}

		private void kembaliKeMenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void comboBoxAktif_SelectedIndexChanged(object sender, EventArgs e)
        {
			loadUsers();
        }

        private void comboBoxFilterPrivilege_SelectedIndexChanged(object sender, EventArgs e)
        {
			loadUsers();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
			loadUsers();
        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
			clearSearch();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
			if (btnInsert.Enabled == true)
			{
				if (textBoxNama.Text != "" && textBoxUsername.Text != "" && textBoxPassword.Text != "")
				{
					try
					{
						MySqlCommand cmd = new MySqlCommand();

						cmd.Connection = Koneksi.getConn();

						cmd.CommandText = "INSERT INTO users VALUES (@id, @username, @password, @nama, 1, 1)";
						cmd.Parameters.Add(new MySqlParameter("@id", Convert.ToInt32(textBoxId.Text)));
						cmd.Parameters.Add(new MySqlParameter("@username", textBoxUsername.Text));
						cmd.Parameters.Add(new MySqlParameter("@password", FormLogin.getHash(textBoxPassword.Text)));
						cmd.Parameters.Add(new MySqlParameter("@nama", textBoxNama.Text));
						

						cmd.ExecuteNonQuery();

						MessageBox.Show("Insert berhasil!");
						Clear();
						clearSearch();
					}
					catch (Exception a)
					{
						MessageBox.Show(a.Message);
					}

				}
				else
				{
					MessageBox.Show("Isikan semua field!");
				}
			}
			else
			{
				MessageBox.Show("Dalam mode edit! Hapus seleksi dulu!");
			}
		}

		public void Clear()
		{
			textBoxNama.Text = "";
			textBoxSearch.Text = "";
			buttonDelete.Text = "Delete";
			textBoxPassword.Text = "";
			textBoxUsername.Text = "";
			buttonDelete.Enabled = false;
			buttonUpdate.Enabled = false;
			btnInsert.Enabled = true;
			textBoxId.Text = ""; 
			labelPass.Visible = true;
			labelNewPass.Visible = false;
		}

		public void clearSearch()
        {
			textBoxSearch.Text = "";
			comboBoxAktif.SelectedIndex = 0;
			loadUsers();
		}

        private void buttonClear_Click(object sender, EventArgs e)
        {
			Clear();
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

						cmd.CommandText = "UPDATE users set status = 0 WHERE id_users = " + textBoxId.Text;

						cmd.ExecuteNonQuery();

						MessageBox.Show("User dihapus!");
						Clear();
						clearSearch();
					}
					catch (Exception a)
					{
						MessageBox.Show(a.Message);

					}
				}
				else
				{
					MessageBox.Show("admin tidak boleh di delete!");
				}
			}
			else
			{
				try
				{
					MySqlCommand cmd = new MySqlCommand();

					cmd.Connection = Koneksi.getConn();

					cmd.CommandText = "UPDATE users set status = 1 WHERE id_users = " + textBoxId.Text;

					cmd.ExecuteNonQuery();

					MessageBox.Show("User dikembalikan!");
					Clear();
					clearSearch();
				}
				catch (Exception a)
				{
					MessageBox.Show(a.Message);

				}
			}
		}

		void AutogenID()
		{
			if (btnInsert.Enabled)
			{
				MySqlCommand cmd = new MySqlCommand("select count(*) from users;", Koneksi.getConn());
				string count_data = cmd.ExecuteScalar().ToString();
				string newID = (int.Parse(count_data) + 1).ToString();
				textBoxId.Text = newID;
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
        {
			if (buttonUpdate.Enabled == true)
			{
				if (textBoxNama.Text != "" && textBoxUsername.Text != "")
				{
					if (textBoxId.Text != "1")
					{
                        if (textBoxPassword.Text != "")
                        {
							try
							{
								MySqlCommand cmd = new MySqlCommand();

								cmd.Connection = Koneksi.getConn();

								cmd.CommandText = "UPDATE users set username = @username, password = @password, nama = @nama WHERE id_users = " + textBoxId.Text;
								cmd.Parameters.Add(new MySqlParameter("@username", textBoxUsername.Text));
								cmd.Parameters.Add(new MySqlParameter("@password", FormLogin.getHash(textBoxPassword.Text)));
								cmd.Parameters.Add(new MySqlParameter("@nama", textBoxNama.Text));
								cmd.ExecuteNonQuery();

								MessageBox.Show("Update berhasil!");
								Clear();
								clearSearch();
							}
							catch (Exception a)
							{
								MessageBox.Show(a.Message);

							}
						}
                        else
                        {
							try
							{
								MySqlCommand cmd = new MySqlCommand();

								cmd.Connection = Koneksi.getConn();

								cmd.CommandText = "UPDATE users set username = @username, nama = @nama WHERE id_users = " + textBoxId.Text;
								cmd.Parameters.Add(new MySqlParameter("@username", textBoxUsername.Text));
								cmd.Parameters.Add(new MySqlParameter("@nama", textBoxNama.Text));
								cmd.ExecuteNonQuery();

								MessageBox.Show("Update berhasil!");
								Clear();
								clearSearch();
							}
							catch (Exception a)
							{
								MessageBox.Show(a.Message);

							}
						}
					}
					else
					{
						MessageBox.Show("admin tidak boleh di edit!");
					}
				}
				else
				{
					MessageBox.Show("Isikan semua field!");
				}
			}
			else
			{
				MessageBox.Show("Dalam mode tambah! Pilih user dulu!");
			}
		}

        private void dataGridViewUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			if (e.RowIndex > -1)
			{
				buttonDelete.Enabled = true;
				buttonUpdate.Enabled = true;
				btnInsert.Enabled = false;
				textBoxId.Text = dataGridViewUser.Rows[e.RowIndex].Cells[0].Value.ToString();
				textBoxUsername.Text = dataGridViewUser.Rows[e.RowIndex].Cells[1].Value.ToString();
				labelPass.Visible = false;
				labelNewPass.Visible = true;
				//textBoxPassword.Text = dataGridViewUser.Rows[e.RowIndex].Cells[2].Value.ToString();
				textBoxNama.Text = dataGridViewUser.Rows[e.RowIndex].Cells[3].Value.ToString();

				int status = Convert.ToInt32(dataGridViewUser.Rows[e.RowIndex].Cells[4].Value.ToString());
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

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
			AutogenID();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
			AutogenID();
		}

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {
			AutogenID();
		}
    }
}
