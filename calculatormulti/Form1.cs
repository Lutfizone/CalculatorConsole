using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatormulti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TxtNilaiA.Text);
            var b = Convert.ToInt32(TxtNilaiB.Text);


            switch (cmbOperasi.SelectedIndex)
            {

                case 0:
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add( Penambahan(a, b));
                    Convert.ToString(lstHasil);
                    break;
                case 1:
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(Pengurangan(a, b));
                    Convert.ToString(lstHasil);
                    break;
                case 2:
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(Perkalian(a, b));
                    Convert.ToString(lstHasil);
                    break;
                case 3:
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(Pembagian(a, b));
                    Convert.ToString(lstHasil);
                    break;
            }

         }

        private void cmbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
