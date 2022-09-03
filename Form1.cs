using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 1, doğru = 0, yanlış = 0, puan = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;
            richTextBox1.Text = "Cumhuriyet hangi yılda ilan edilmiştir?";
            BTNA.Text = "1921";
            BTNB.Text = "1923";
            BTNC.Text = "1925";
            BTND.Text = "1927";
            lbldgr.Text = "1923";
            lblsoruno.Text = soruno.ToString();

        }
        private void BTNA_Click(object sender, EventArgs e)
        {
            BTNB.Enabled = false;
            BTNC.Enabled = false;
            BTND.Enabled = false;
            button5.Enabled = true;

            lblscm.Text = BTNA.Text;

            if (lblscm.Text == lbldgr.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                puan += 5;
                lblpuan.Text = puan.ToString();
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
            }
        }

        private void BTNB_Click(object sender, EventArgs e)
        {
            BTNA.Enabled = false;
            BTNC.Enabled = false;
            BTND.Enabled = false;
            button5.Enabled = true;
            lblscm.Text = BTNB.Text;

            if (lblscm.Text== lbldgr.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                puan += 5;
                lblpuan.Text = puan.ToString();
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
            }
        }

        private void BTNC_Click(object sender, EventArgs e)
        {
            BTNB.Enabled = false;
            BTNA.Enabled = false;
            BTND.Enabled = false;
            button5.Enabled=true;
            lblscm.Text = BTNC.Text;

            if (lblscm.Text == lbldgr.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                puan += 5;
                lblpuan.Text = puan.ToString();
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
            }
        }

        private void BTND_Click(object sender, EventArgs e)
        {
            BTNB.Enabled = false;
            BTNC.Enabled = false;
            BTNA.Enabled = false;
            button5.Enabled = true;

            lblscm.Text = BTND.Text;

            if (lblscm.Text == lbldgr.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                puan += 5;
                lblpuan.Text = puan.ToString();
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BTNA.Enabled = true;
            BTNB.Enabled = true;
            BTNC.Enabled=true; 
            BTND.Enabled = true;
            button5.Enabled = false;
            soruno++;
            lblsoruno.Text = soruno.ToString();
           
            if(soruno==2)
            {
                richTextBox1.Text= "Hangi il Ege bölgesinde değildir?";
                BTNA.Text = "İzmir";
                BTNB.Text = "Manisa";
                BTNC.Text = "Aydın";
                BTND.Text = "Edirne";
                lbldgr.Text = "Edirne";
            }
            
            if (soruno == 3)
            {
                richTextBox1.Text = "Beyaz Diş kitabının yazarı kimdir?";
                BTNA.Text = "Jack London";
                BTNB.Text = "Tolstoy";
                BTNC.Text = "Halide Edip Adıvar";
                BTND.Text = "Neitzche";
                lbldgr.Text = "Jack London";
            }
            
            if(soruno == 4)
            {
                BTNB.Enabled = false;
                BTNA.Enabled = false;
                BTND.Enabled = false;
                BTNC.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Doğru sayısı: "+ doğru + "\nYanlış sayısı: " + yanlış + "\nToplam Puanınız: " + puan);
            }
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
