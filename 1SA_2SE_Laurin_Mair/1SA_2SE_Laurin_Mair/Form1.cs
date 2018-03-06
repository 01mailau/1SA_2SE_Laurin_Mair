using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1SA_2SE_Laurin_Mair
{
    public partial class tanken : Form
    {

        public tanken()
        {
            InitializeComponent();
        }

        private void autoerstellen_Click(object sender, EventArgs e)
        {
            
        }

        private void marke_TextChanged(object sender, EventArgs e)
        {
            autoerstellen.Text = "0";
        }

        private void farbe_TextChanged(object sender, EventArgs e)
        {
            farbe.Text = "0";
        }

        private void ps_TextChanged(object sender, EventArgs e)
        {
            ps.Text = "0";
        }

        private void Tankgröse_TextChanged(object sender, EventArgs e)
        {
           Tankgröse.Text = "0";
        }

        private void verbrauch_TextChanged(object sender, EventArgs e)
        {
            verbrauch.Text = "0";

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = verbrauch.Text;
        }
       
      
        }
    }

