using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Digitron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        
        bool daLiJeNula=true;     // proverava da li je 0 na pocetku linije u textBoxu
        bool znaakPlus = false;   // naredna 3 bool-a ce nam trebati za racunanje vrednosti, kada kliknemo na dugme "="
        bool znaakMinus = false;
        bool znakPuta = false;
        bool znakPodeljeno = false;
        bool znakJednako = false; // ovaj bool ce nam trebati za resetovanje nakon jednog racunanja

        public void ProveriDaLiJeRacunato() // ova metoda proverava da li je vrseno racunanje
        {                                   //ako jeste, onda ukucavanjem narednog broja se resetuje textBox i ponovo se vrsi racunanje za  nove brojeve
            if (znakJednako)
            {
                textBox1.Text = "";
                znakJednako = false;
            }
        }

        private void jedan_Click(object sender, EventArgs e)  // nakon sto kliknemo na dugme 1, on uradi sledece
        {
            ProveriDaLiJeRacunato();

            if (daLiJeNula) 
            {
                textBox1.Text = "1";      // ako je na  pocetku linije u textBoxu nula, on je prelepi sa jedinicom
                daLiJeNula = false;
            }
            else
            textBox1.Text += "1";         // ako nije bila nula, on samo doda jedinicu
        }

        private void nula_Click(object sender, EventArgs e)  // kada kliknemo na dugme nula , uradi sledece
        {
            ProveriDaLiJeRacunato();

            if (daLiJeNula)               // ako je nula na pocetku, ne radi nista u metodi, tj. ne dodaji dalje nule
                return;
            else
                textBox1.Text += "0";     // u suprotnom dodaji koliko hoces
        }

        private void dva_Click(object sender, EventArgs e) // i za dugme dva, kao i za preostalih 7 dugmica, isto se radi
        {
            ProveriDaLiJeRacunato();

            if (daLiJeNula)
            {
                textBox1.Text = "2";
                daLiJeNula = false;
            }
            else
            textBox1.Text += "2";
        }

        private void tri_Click(object sender, EventArgs e)
        {
            ProveriDaLiJeRacunato();

            if (daLiJeNula)
            {
                textBox1.Text = "3";
                daLiJeNula = false;
            }
            else
            textBox1.Text += "3";
        }

        private void cetiri_Click(object sender, EventArgs e)
        {
            ProveriDaLiJeRacunato();

            if (daLiJeNula)
            {
                textBox1.Text = "4";
                daLiJeNula = false;
            }
            else
            textBox1.Text += "4";
        }

        private void pet_Click(object sender, EventArgs e)
        {
            ProveriDaLiJeRacunato();

            if (daLiJeNula)
            {
                textBox1.Text = "5";
                daLiJeNula = false;
            }
            else
            textBox1.Text += "5";
        }

        private void sest_Click(object sender, EventArgs e)
        {
            ProveriDaLiJeRacunato();

            if (daLiJeNula)
            {
                textBox1.Text = "6";
                daLiJeNula = false;
            }
            else
            textBox1.Text += "6";
        }

        private void sedam_Click(object sender, EventArgs e)
        {
            ProveriDaLiJeRacunato();

            if (daLiJeNula)
            {
                textBox1.Text = "7";
                daLiJeNula = false;
            }
            else
            textBox1.Text += "7";
        }

        private void osam_Click(object sender, EventArgs e)
        {
            ProveriDaLiJeRacunato();

            if (daLiJeNula)
            {
                textBox1.Text = "8";
                daLiJeNula = false;
            }
            else
            textBox1.Text += "8";
        }

        private void devet_Click(object sender, EventArgs e)
        {
            ProveriDaLiJeRacunato();

            if (daLiJeNula)
            {
                textBox1.Text = "9";
                daLiJeNula = false;
            }
            else
            textBox1.Text += "9";
        }

        private void deljenje_Click(object sender, EventArgs e)  // e sad, kada kliknemo na dugme deljenje, izvrsi se sledece
        {
            if (textBox1.Text == "") // ukoliko nije unet nijedan broj u textBox, ne zelimo da izvrsacamo operaciju deljenja
            {
                return;
            }
            else
            {
                znakPodeljeno = true;           // postavljamo bool vrednosti na true, sto ce nam trebati u metodi "jednako_Click"
                textBox1.Tag = textBox1.Text;   // pamtimo vrednost koju smo uneli pre znaka plus
                textBox1.Text = "";             // a zatim obrisemo sve sto se nalazi u text boxu
            }
        }

        private void mnozenje_Click(object sender, EventArgs e) // i za dugme mnozenje radimo isto kao za ugme deljenje, a i za preostala dva dugmeta
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                znakPuta = true;
                textBox1.Tag = textBox1.Text;  
                textBox1.Text = "";            
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                znaakMinus = true;
                textBox1.Tag = textBox1.Text;  
                textBox1.Text = "";          
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else
            {
                znaakPlus = true;  
                textBox1.Tag = textBox1.Text; 
                textBox1.Text = "";             
            }
        }
                       
        private void jednako_Click(object sender, EventArgs e)  // najbitnija metoda 
        {
            znakJednako = true;

            if (znaakPlus)
            {
                decimal decimalniBroj = Convert.ToDecimal(textBox1.Tag) + Convert.ToDecimal(textBox1.Text); // sabiramo dve vrednosti...konvertujemo u decimalni, jer ce nam vecina rezultata upravo biti decimalan broj
                textBox1.Text = decimalniBroj.ToString(); // rezultat prikazujem u textBoxu, a posto je u pitanju broj, moramo da stavimo metodu ToString
            }

            if (znaakMinus)
            {
                decimal decimalniBroj = Convert.ToDecimal(textBox1.Tag) - Convert.ToDecimal(textBox1.Text); // oduzimamo dve vrednosti
                textBox1.Text = decimalniBroj.ToString(); // da bi ga prikazao u text boxu 
            }

            if (znakPuta)
            {
                decimal decimalniBroj = Convert.ToDecimal(textBox1.Tag) * Convert.ToDecimal(textBox1.Text); // sabiramo dve vrednosti
                textBox1.Text = decimalniBroj.ToString(); // da bi ga prikazao u text boxu 
            }

            if (znakPodeljeno)
            {
                decimal decimalniBroj = Convert.ToDecimal(textBox1.Tag) / Convert.ToDecimal(textBox1.Text); // sabiramo dve vrednosti
                textBox1.Text = decimalniBroj.ToString(); // da bi ga prikazao u text boxu 
            }

           
        }
                         
        private void tacka_Click(object sender, EventArgs e)  // metoda za decimalne brojeve
        {
            if (textBox1.Text.Contains("."))   //ako broj vec sadrzi decimalnu tacku, iskoci iz metode (ne zelimo dve decimalne tacke)
            {                                  
                return;                            
            }
            else
                textBox1.Text += ".";           // u suprotnom stavi decimalnu tacku
        }

        private void button1_Click(object sender, EventArgs e)          // dugme CLEAR
        {
            textBox1.Text = "0";                                        // postavi textBox na nulu
            daLiJeNula = true;                                          // i bool vrednost resetuj na true, sto je bitno za naredna racunanja
            znaakPlus = znaakMinus = znakPodeljeno = znakPuta = znakJednako= false; // resetujemo svako dugme na pocetnu vrednost
        }

        private void button2_Click(object sender, EventArgs e) // dugme za pozitivne i negativne brojeve
        {
            if (textBox1.Text.Contains("-"))                   // ako je broj vec negativan, ti mu na klik dugmeta obrisi znak minus
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }
            else
                textBox1.Text = "-" + textBox1.Text;            // a ako nije bio negativan, ti mu dodaj znak minus
        }


       
     
    }
}
