using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ryToplama2
{
    public partial class toplamaForm : Form
    {
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region yöntem 1
            string mesaj;
            mesaj = "İŞLEM"+" "+tbSayi1.Text + " + " + tbSayi2.Text + "=" + tbSonuc.Text;
            lbListe.Items.Add(mesaj);
          //  lbListe.Items.Add(tbSayi1.Text + " + " + tbSayi2.Text + "=" + tbSonuc.Text);
            //clear methodu
            tbSayi1.Clear();
            tbSayi2.Clear();
            tbSonuc.Clear();
            //odakla 
            tbSayi1.Select(); /*tbSayi1.Focus();*/
            #endregion

            #region yontem 2

            //tbSayi1.Text = "";
            //tbSayi2.Text = "";
            //tbSonuc.Text = "";
            //tbSayi1.Select();
            #endregion

            #region yöntem 3
            //tbSayi1.Text = tbSayi2.Text = tbSonuc.Text = "";
            //tbSayi1.Focus();


            #endregion
        }
        public toplamaForm()
        {
            InitializeComponent();
        }

        private void toplamaForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            // tbSonuc.Text = ((Convert.ToUInt16(tbSayi1.Text)) + (Convert.ToInt16(tbSayi2.Text))).ToString();
            int a, b,topla = 0, sonuc;
  // int sayi 1  ;
  // int sayi 2 ;
  // int topla ;

            //int sayi1,sayi2,topla = 0;
            a =Convert.ToUInt16(tbSayi1.Text);
            
            b = Convert.ToUInt16(tbSayi2.Text);
            
            topla = a + b;

            //tbSonuc.Text = Convert.ToString( topla);
            tbSonuc.Text = topla.ToString();

           

        }

       
    }
}
