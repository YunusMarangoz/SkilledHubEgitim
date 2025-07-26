using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppAdoNet;

namespace WindowsFormsAppEntitiyFramework
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        UrunDbModel context = new UrunDbModel();
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvKategoriler.DataSource = context.Categories.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;

            txtKategoriAdi.Text=string.Empty;
            txtKategoriAciklamasi.Text = "";
            cbDurum.Checked = false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category
                {
                    Name = txtKategoriAdi.Text,
                    Description = txtKategoriAciklamasi.Text,
                    CreateDate = DateTime.Now,
                    Durum = cbDurum.Checked,
                };
                context.Categories.Add(category);
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    Yukle();                   
                    MessageBox.Show("Kayıt Başarılı");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız ! Lütfen Tüm alanları doldurunuz");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu");
            }
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvKategoriler.CurrentRow.Cells[0].Value;//seçili satırdaki kaydın idsini yakaladık
            var kayit = context.Categories.Find(id);//id yi ef nin find metoduna verip eşleşen kategoriye getirdik.

            #region db den gelen kaydı ekrana doldur
            txtKategoriAdi.Text = kayit.Name;
            //txtKategoriAciklamasi = kayit.Description;
            cbDurum.Enabled = cbDurum.Checked;
            #endregion
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = (int)dgvKategoriler.CurrentRow.Cells[0].Value;//seçili satırdaki kaydın idsini yakaladık
            var kayit = context.Categories.Find(id);//id yi ef nin find metoduna verip eşleşen kategoriye getirdik.
            kayit.Name = txtKategoriAdi.Text;
            kayit.Description = txtKategoriAciklamasi.Text;
            kayit.Durum = cbDurum.Checked;
            int sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                //dgvKategoriler.DataSource =context.Categories.ToList();
                Yukle();
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız ! Lütfen Tüm alanları doldurunuz");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dgvKategoriler.CurrentRow.Cells[0].Value;
            var kayit = context.Categories.Find(id);
            context.Categories.Remove(kayit);

            int sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                //dgvKategoriler.DataSource =context.Categories.ToList();
                Yukle();
                MessageBox.Show("Kayıt Silme Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Silme Başarısız!");
            }
        }
    }
}
