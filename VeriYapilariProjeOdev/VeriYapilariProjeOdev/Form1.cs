using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariProjeOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Liste liste = new Liste();
        
        string metin;
        
        string [] dizi;
        
        private void btnMetinYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt";
            ofd.ShowDialog();

            Stream file = ofd.OpenFile();
            StreamReader reader = new StreamReader(file);
            metin = reader.ReadToEnd();
            txtMetin.Text = ofd.FileName;
            dizi = metin.Split();

            
        }

        private void ıslemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            foreach (string item in dizi)
            {
                liste.ekle(item);
            }
            
        }

        private void btnHeapAktar_Click(object sender, EventArgs e)
        {
                
            
            
        }

        private void btnAgacaTasi_Click(object sender, EventArgs e)
        {
           
            }

            

        }
    }

