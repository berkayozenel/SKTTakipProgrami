using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SktTakipProgrami
{
    public partial class frmYiyecekler : Form
    {
        public frmYiyecekler()
        {
            InitializeComponent();
            dtpSkt.ValueChanged += new EventHandler(dtpSkt_ValueChanged);
            dtpSkt.KeyPress += new KeyPressEventHandler(dtpSkt_KeyPress);
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public void UrunEkle()
        {
            if (string.IsNullOrEmpty(txtUrunAd.Text) || string.IsNullOrEmpty(dtpSkt.Text))
            {
                MessageBox.Show("Lütfen tüm 'zorunlu' alanları doldurun!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Yiyecekler (urunAdi, urunTuru, sktTett) values (@p1, @p2, @p3)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut.Parameters.AddWithValue("@p2", txtUrunTur.Text);
                komut.Parameters.AddWithValue("@p3", dtpSkt.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Ürün Ekleme İşleminiz Gerçekleşmiştir!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUrunAd.Text = "";
                txtUrunTur.Text = "";
                dtpSkt.Text = "";
            }
        }
        public void UrunGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select secim,urunAdi, urunTuru, sktTett from Tbl_Yiyecekler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void IadeGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select urunAdi, urunTuru, sktTett from Tbl_YiyecekIade", bgl.baglanti());
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            UrunEkle();
            UrunGetir();
        }
        private void frmYiyecekler_Load(object sender, EventArgs e)
        {
            UrunGetir();
            IadeGetir();
            sktGelenler();
            dataGridView1.Columns["urunAdi"].HeaderText = "Ürün Adı";
            dataGridView1.Columns["urunTuru"].HeaderText = "Ürün Türü";
            dataGridView1.Columns["sktTett"].HeaderText = "SKT - TETT";
            dataGridView1.Columns["secim"].HeaderText = "İadeye Ayrıldı";
            dataGridView3.Columns["urunAdi"].HeaderText = "Ürün Adı";
            dataGridView3.Columns["urunTuru"].HeaderText = "Ürün Türü";
            dataGridView3.Columns["sktTett"].HeaderText = "SKT - TETT";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["secim"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                string value1 = selectedRow.Cells["urunAdi"].Value.ToString();
                string value2 = selectedRow.Cells["urunTuru"].Value.ToString();
                string value3 = selectedRow.Cells["sktTett"].Value.ToString();
                DateTime sktTett;
                string formattedValue3;
                if (DateTime.TryParse(value3, out sktTett))
                {
                    formattedValue3 = sktTett.ToString("MM/dd/yyyy");

                    SqlCommand komut = new SqlCommand("insert into Tbl_YiyecekIade (urunAdi, urunTuru, sktTett) values (@p1, @p2, @p3)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", value1);
                    komut.Parameters.AddWithValue("@p2", value2);
                    komut.Parameters.AddWithValue("@p3", formattedValue3);
                    komut.ExecuteNonQuery();
                    IadeGetir();

                    SqlCommand komut2 = new SqlCommand("delete from Tbl_Yiyecekler where urunAdi = @p1", bgl.baglanti());
                    komut2.Parameters.AddWithValue("@p1", value1);
                    komut2.ExecuteNonQuery();

                    if (dataGridView1.Rows.Count > 1)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                    else
                    {
                        MessageBox.Show("Hiç İade Kalmadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SqlCommand komut3 = new SqlCommand("delete from Tbl_YiyecekIade where sktTett = '1900-01-01'", bgl.baglanti());
                        komut3.ExecuteNonQuery();
                        IadeGetir();
                    }
                }
                else
                {
                    MessageBox.Show("Hiç İade Kalmadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void sktGelenler()
        {
            DateTime bugun = DateTime.Today;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DateTime skt = Convert.ToDateTime(row.Cells["sktTett"].Value);

                if (skt.Date == bugun)
                {
                    dataGridView2.Rows.Add(row.Cells["urunAdi"].Value, row.Cells["urunTuru"].Value, skt);
                }
            }
            dataGridView2.Refresh();
        }

        private void dtpSkt_ValueChanged(object sender, EventArgs e)
        {
            if(dtpSkt.Value != null)
            {
                txtUrunAd.Enabled = true;
                txtUrunTur.Enabled = true;
            }
            else
            {
                txtUrunAd.Enabled = false;
                txtUrunTur.Enabled = false;
            }
        }

        private void dtpSkt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
