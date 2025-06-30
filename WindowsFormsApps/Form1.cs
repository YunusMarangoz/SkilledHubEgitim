using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ekrenadaki form yüklendiğinde bu metot çalışır,veri tabanından veri çekip ekrana gönderme gibi işlemleri bu ekranda yapabiliriz.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2  form2 = new Form2();
            //form2.Show();//Çağıırılan form shoe metoduyla gösterilirse,tüm formalra erişim sağlanabilir.
            form2.ShowDialog();//Çağırılan Form Shoe Dialog metoduyla gösterilirse,üstteki form kapatılana kadar alttaki forma erişim engellenir.
            //this.Hide();//form 2 yi açtıktan sonra bu formu(form1)gizle

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();//Formu Kapat
            Application.Exit();//Komple Uygulmayı Kapat
        }
    }
}
