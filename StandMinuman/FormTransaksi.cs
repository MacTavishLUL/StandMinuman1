using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandMinuman
{
    public partial class FormTransaksi : Form
    {
        DataTable minuman, topping;
        int idxMinuman=-1, idxTopping=-1,idxKeranjang=-1;
        string nota;
        int total = 0;
        public FormTransaksi()
        {
            InitializeComponent();
        }

        public void getNota()
        {
            string query = "Select genNoNota()";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Koneksi.getConn());
                nota = cmd.ExecuteScalar().ToString();
                labelNota.Text = "Nomer Nota: " + nota;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadCategory()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT 0 AS 'member', 'All' AS 'display' UNION SELECT id_category_minuman AS 'member', nama AS 'display' FROM category_minuman WHERE STATUS = 1 order by 1", Koneksi.getConn());
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

        public void loadMinuman()
        {
            string query = "SELECT m.id_minuman AS 'Id', m.nama AS 'Nama', m.stok AS 'Stok', FORMAT(m.harga,0,'id_ID') AS 'Harga', c.nama AS 'Category' FROM minuman m, category_minuman c WHERE m.id_category_minuman = c.id_category_minuman AND m.status = 1";
            if (textBoxSearchMinuman.Text != "")
            {
                query += $" AND m.nama LIKE '%{textBoxSearchMinuman.Text}%'";
            }
            if (comboBoxCategory.SelectedIndex != 0)
            {
                query += $" AND m.id_category_minuman = {Convert.ToInt32(comboBoxCategory.SelectedValue.ToString())}";
            }
            query += " order by 1";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Koneksi.getConn());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                minuman = new DataTable();
                da.Fill(minuman);
                dataGridViewMinuman.DataSource = null;
                dataGridViewMinuman.DataSource = minuman;
                dataGridViewMinuman.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewMinuman.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewMinuman.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewMinuman.Columns[2].FillWeight = 75;
                dataGridViewMinuman.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewMinuman.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewMinuman.Columns[0].Width = 30;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadTopping()
        {
            string query = "SELECT id_topping AS 'Id', nama AS 'Nama Topping', FORMAT(harga,0,'id_ID') AS 'Harga' FROM topping where status = 1";
            if (textBoxSearchTopping.Text != "")
            {
                query += $" AND nama LIKE '%{textBoxSearchTopping.Text}%'";
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, Koneksi.getConn());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                topping = new DataTable();
                da.Fill(topping);
                dataGridViewTopping.DataSource = null;
                dataGridViewTopping.DataSource = topping;
                dataGridViewTopping.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewTopping.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewTopping.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewTopping.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewTopping.Columns[0].Width = 30;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewMinuman_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (idxKeranjang <= -1)
            {
                if (e.RowIndex > -1)
                {
                    idxMinuman = e.RowIndex;
                    labelNamaMinuman.Text = "Nama Minuman: " + dataGridViewMinuman.Rows[idxMinuman].Cells[1].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Dalam mode edit! Hapus seleksi dulu!");
            }
        }

        private void dataGridViewTopping_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (idxKeranjang <= -1)
            {
                if (e.RowIndex > -1)
                {
                    idxTopping = e.RowIndex;
                    labelNamaTopping.Text = "Nama Topping: " + dataGridViewTopping.Rows[idxTopping].Cells[1].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Dalam mode edit! Hapus seleksi dulu!");
            }
        }

        public int getIdk()
        {
            int id = -1;
            int idm = Convert.ToInt32(dataGridViewMinuman.Rows[idxMinuman].Cells[0].Value.ToString());
            int idt = Convert.ToInt32(dataGridViewTopping.Rows[idxTopping].Cells[0].Value.ToString());
            for (int i = 0; i < dataGridViewKeranjang.Rows.Count; i++)
            {
                if (dataGridViewMinuman.Rows[idxMinuman].Cells[0].Value.ToString() == dataGridViewKeranjang.Rows[i].Cells[1].Value.ToString())
                {
                    if (dataGridViewTopping.Rows[idxTopping].Cells[0].Value.ToString() == dataGridViewKeranjang.Rows[i].Cells[3].Value.ToString())
                    {
                        id = i;
                        break;
                    }
                }
            }

            return id;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (idxKeranjang <= -1)
            {
                if (idxMinuman > -1)
                {
                    if(idxTopping < 0)
                    {
                        textBoxSearchTopping.Text = "";
                        loadTopping();
                        idxTopping = 0;
                    }
                    int amount = Convert.ToInt32(numericUpDownJumlah.Value.ToString());
                    idxKeranjang = getIdk();
                    if (idxKeranjang > -1)
                    {
                        amount += FormLogin.removeThousandSep(dataGridViewKeranjang.Rows[idxKeranjang].Cells[5].Value.ToString());
                        if (amount <= FormLogin.removeThousandSep(dataGridViewMinuman.Rows[idxMinuman].Cells[2].Value.ToString()))
                        {
                            int subMin = FormLogin.removeThousandSep(dataGridViewMinuman.Rows[idxMinuman].Cells[3].Value.ToString()) * amount;
                            int subTop = FormLogin.removeThousandSep(dataGridViewTopping.Rows[idxTopping].Cells[2].Value.ToString()) * amount;
                            int subtotal = (FormLogin.removeThousandSep(dataGridViewMinuman.Rows[idxMinuman].Cells[3].Value.ToString()) + FormLogin.removeThousandSep(dataGridViewTopping.Rows[idxTopping].Cells[2].Value.ToString())) * amount;
                            dataGridViewKeranjang.Rows[idxKeranjang].Cells[5].Value = amount;
                            dataGridViewKeranjang.Rows[idxKeranjang].Cells[6].Value = FormLogin.thousandSep(subMin); 
                            dataGridViewKeranjang.Rows[idxKeranjang].Cells[7].Value = FormLogin.thousandSep(subTop); ;
                            dataGridViewKeranjang.Rows[idxKeranjang].Cells[8].Value = FormLogin.thousandSep(subtotal);
                            getNota();
                            hitungTotal();
                            clearSelection();
                            buttonHapusSemua.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Jumlah melebihi stok!");
                        }
                    }
                    else if (amount <= Convert.ToInt32(dataGridViewMinuman.Rows[idxMinuman].Cells[2].Value.ToString()))
                    {
                        int subMin = FormLogin.removeThousandSep(dataGridViewMinuman.Rows[idxMinuman].Cells[3].Value.ToString()) * amount;
                        int subTop = FormLogin.removeThousandSep(dataGridViewTopping.Rows[idxTopping].Cells[2].Value.ToString()) * amount;
                        int subtotal = (FormLogin.removeThousandSep(dataGridViewMinuman.Rows[idxMinuman].Cells[3].Value.ToString()) + FormLogin.removeThousandSep(dataGridViewTopping.Rows[idxTopping].Cells[2].Value.ToString())) * amount;
                        dataGridViewKeranjang.Rows.Add(dataGridViewKeranjang.Rows.Count + 1, Convert.ToInt32(dataGridViewMinuman.Rows[idxMinuman].Cells[0].Value.ToString()), dataGridViewMinuman.Rows[idxMinuman].Cells[1].Value.ToString(), Convert.ToInt32(dataGridViewTopping.Rows[idxTopping].Cells[0].Value.ToString()), dataGridViewTopping.Rows[idxTopping].Cells[1].Value.ToString(), amount, FormLogin.thousandSep(subMin), FormLogin.thousandSep(subTop), FormLogin.thousandSep(subtotal));
                        getNota();
                        hitungTotal();
                        clearSelection();
                        buttonHapusSemua.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Jumlah melebihi stok!");
                    }
                }
                else
                {
                    MessageBox.Show("Minuman belum terseleksi!");
                }
            }
            else
            {
                MessageBox.Show("Dalam mode edit! Hapus seleksi dulu!");
            }
                
        }

        public void clearSelection()
        {
            idxMinuman = -1;
            idxTopping = -1;
            idxKeranjang = -1;
            labelNamaMinuman.Text = "Nama Minuman: -";
            labelNamaTopping.Text = "Nama Topping: -";
            numericUpDownJumlah.Value = 1;
            textBoxSearchTopping.Text = "";
            loadTopping();
            textBoxSearchMinuman.Text = "";
            loadMinuman();
            buttonUpdate.Enabled = false;
            buttonHapus.Enabled = false;
            buttonTambah.Enabled = true;
            if (dataGridViewKeranjang.Rows.Count == 0)
            {
                buttonHapusSemua.Enabled = false;
                labelNota.Text = "No Nota: -";
            }
        }

        public void hitungTotal()
        {
            total = 0;
            for (int i = 0; i < dataGridViewKeranjang.Rows.Count; i++)
            {
                total += FormLogin.removeThousandSep(dataGridViewKeranjang.Rows[i].Cells[8].Value.ToString());
            }
            labelTotal.Text = "Total : Rp. " + FormLogin.thousandSep(total);
        }

        private void dataGridViewKeranjang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idxKeranjang = e.RowIndex;
                labelNamaMinuman.Text = "Nama Minuman: " + dataGridViewKeranjang.Rows[idxKeranjang].Cells[2].Value.ToString();
                labelNamaTopping.Text = "Nama Topping: " + dataGridViewKeranjang.Rows[idxKeranjang].Cells[4].Value.ToString();
                numericUpDownJumlah.Value = Convert.ToInt32(dataGridViewKeranjang.Rows[idxKeranjang].Cells[5].Value.ToString());
                buttonUpdate.Enabled = true;
                buttonHapus.Enabled = true;
                buttonTambah.Enabled = false;
            }
        }

        private void buttonClearSelection_Click(object sender, EventArgs e)
        {
            clearSelection();
        }

        public int getIdm()
        {
            int id = -1;
            textBoxSearchMinuman.Text = "";
            loadMinuman();
            for (int i = 0; i < dataGridViewMinuman.Rows.Count; i++)
            {
                if(dataGridViewMinuman.Rows[i].Cells[0].Value.ToString() == dataGridViewKeranjang.Rows[idxKeranjang].Cells[1].Value.ToString())
                {
                    id = i;
                    break;
                }
            }

            return id;
        }
        public int getIdt()
        {
            int id = -1;
            textBoxSearchTopping.Text = "";
            loadTopping();
            for (int i = 0; i < dataGridViewTopping.Rows.Count; i++)
            {
                if(dataGridViewTopping.Rows[i].Cells[0].Value.ToString() == dataGridViewKeranjang.Rows[idxKeranjang].Cells[3].Value.ToString())
                {
                    id = i;
                    break;
                }
            }

            return id;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (idxKeranjang > -1)
            {
                int amount = Convert.ToInt32(numericUpDownJumlah.Value.ToString());
                idxMinuman = getIdm();
                idxTopping = getIdt();

                if (amount <= Convert.ToInt32(dataGridViewMinuman.Rows[idxMinuman].Cells[2].Value.ToString()))
                {
                    int subMin = FormLogin.removeThousandSep(dataGridViewMinuman.Rows[idxMinuman].Cells[3].Value.ToString()) * amount;
                    int subTop = FormLogin.removeThousandSep(dataGridViewTopping.Rows[idxTopping].Cells[2].Value.ToString()) * amount;
                    int subtotal = (FormLogin.removeThousandSep(dataGridViewMinuman.Rows[idxMinuman].Cells[3].Value.ToString()) + FormLogin.removeThousandSep(dataGridViewTopping.Rows[idxTopping].Cells[2].Value.ToString())) * amount;
                    dataGridViewKeranjang.Rows[idxKeranjang].Cells[5].Value = amount;
                    dataGridViewKeranjang.Rows[idxKeranjang].Cells[6].Value = FormLogin.thousandSep(subMin);
                    dataGridViewKeranjang.Rows[idxKeranjang].Cells[7].Value = FormLogin.thousandSep(subTop); ;
                    dataGridViewKeranjang.Rows[idxKeranjang].Cells[8].Value = FormLogin.thousandSep(subtotal);
                    hitungTotal();
                    clearSelection();
                }
                else
                {
                    MessageBox.Show("Jumlah melebihi stok!");
                }
            }
            else
            {
                MessageBox.Show("Tidak dalam mode edit!");
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (idxKeranjang > -1)
            {
                dataGridViewKeranjang.Rows.RemoveAt(idxKeranjang);
                hitungTotal();
                clearSelection();
                reNo();
            }
            else
            {
                MessageBox.Show("Tidak dalam mode edit!");
            }
        }

        public void reNo()
        {
            for (int i = 0; i < dataGridViewKeranjang.Rows.Count; i++)
            {
                dataGridViewKeranjang.Rows[i].Cells[0].Value = (i + 1);
            }
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            toolStripMenuItemHello.Text = "Hello, " + FormLogin.user.ItemArray[3].ToString() + "!";
            loadCategory();
            loadMinuman();
            loadTopping();
        }

        private void buttonBeli_Click(object sender, EventArgs e)
        {
            if (dataGridViewKeranjang.Rows.Count > 0)
            {
                DialogResult ok = MessageBox.Show(labelNota.Text+"\n"+labelTotal.Text+"\n"+"Apakah kamu yakin atas pembelian ini?", "Confirmation", MessageBoxButtons.YesNo);
                if(ok == DialogResult.Yes)
                {
                    bool sukses = true;

                    using (MySqlTransaction obTrans = Koneksi.getConn().BeginTransaction())
                    {
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand();

                            cmd.Connection = Koneksi.getConn();

                            cmd.CommandText = "INSERT INTO htrans VALUES (@nota, now(), @total, @id, 1)";
                            cmd.Parameters.Add(new MySqlParameter("@nota", nota));
                            cmd.Parameters.Add(new MySqlParameter("@total", total));
                            cmd.Parameters.Add(new MySqlParameter("@id", Convert.ToInt32(FormLogin.user.ItemArray[0].ToString())));

                            cmd.ExecuteNonQuery();

                            for (int i = 0; i < dataGridViewKeranjang.RowCount; i++)
                            {
                                cmd.Parameters.Clear();

                                cmd.CommandText = "SELECT stok FROM minuman WHERE id_minuman = " + dataGridViewKeranjang.Rows[i].Cells[1].Value.ToString();
                                int cek = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                                if (Convert.ToInt32(dataGridViewKeranjang.Rows[i].Cells[5].Value.ToString()) <= cek)
                                {
                                    cmd.CommandText = "update minuman set stok = stok - " + dataGridViewKeranjang.Rows[i].Cells[5].Value.ToString() + " WHERE id_minuman = " + dataGridViewKeranjang.Rows[i].Cells[1].Value.ToString();
                                    cmd.ExecuteNonQuery();
                                    cmd.Parameters.Clear();
                                    cmd.CommandText = "INSERT INTO dtrans VALUES (@nota, @idm, @idt, @jumlah,@subMin,@subTop, @subtotal, 1)";
                                    cmd.Parameters.Add(new MySqlParameter("@nota", nota));
                                    cmd.Parameters.Add(new MySqlParameter("@idm", Convert.ToInt32(dataGridViewKeranjang.Rows[i].Cells[1].Value.ToString())));
                                    cmd.Parameters.Add(new MySqlParameter("@idt", Convert.ToInt32(dataGridViewKeranjang.Rows[i].Cells[3].Value.ToString())));
                                    cmd.Parameters.Add(new MySqlParameter("@jumlah", Convert.ToInt32(dataGridViewKeranjang.Rows[i].Cells[5].Value.ToString())));
                                    cmd.Parameters.Add(new MySqlParameter("@subMin", FormLogin.removeThousandSep(dataGridViewKeranjang.Rows[i].Cells[6].Value.ToString())));
                                    cmd.Parameters.Add(new MySqlParameter("@subTop", FormLogin.removeThousandSep(dataGridViewKeranjang.Rows[i].Cells[7].Value.ToString())));
                                    cmd.Parameters.Add(new MySqlParameter("@subtotal", FormLogin.removeThousandSep(dataGridViewKeranjang.Rows[i].Cells[8].Value.ToString())));
                                    cmd.ExecuteNonQuery();
                                }
                                else
                                {

                                    sukses = false;
                                    break;
                                }
                            }

                            if (sukses)
                            {
                                obTrans.Commit();
                                MessageBox.Show("TRANSAKSI SUKSES!");
                                dataGridViewKeranjang.Rows.Clear();
                                hitungTotal();
                                clearSelection();
                            }
                            else
                            {
                                MessageBox.Show("Stok tidak cukup!");
                                obTrans.Rollback();
                            }

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);

                            obTrans.Rollback();
                        }
                    }

                    
                }
            }
            else
            {
                MessageBox.Show("Tidak ada apa-apa di keranjang!");
            }
        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            comboBoxCategory.SelectedIndex = 0;
            textBoxSearchMinuman.Text = "";
            textBoxSearchTopping.Text = "";
            loadMinuman();
            loadTopping();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxCategory.SelectedValue.ToString());
            loadMinuman();
        }

        private void textBoxSearchTopping_TextChanged(object sender, EventArgs e)
        {
            if (idxTopping <= -1)
            {
                loadTopping();
            }
            
        }

        private void buttonHapusSemua_Click(object sender, EventArgs e)
        {
            if (dataGridViewKeranjang.Rows.Count > 0)
            {
                dataGridViewKeranjang.Rows.Clear();
                hitungTotal();
                clearSelection();
            }
            else
            {
                MessageBox.Show("Tidak ada apa-apa di keranjang!");
            }
        }

        private void textBoxSearchMinuman_TextChanged(object sender, EventArgs e)
        {
            if(idxMinuman <= -1)
            {
                loadMinuman();
            }
            
        }
    }
}
