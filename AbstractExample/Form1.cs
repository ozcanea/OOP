using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuitar_Click(object sender, EventArgs e)
        {
            Guitar guitar = new Guitar();
            guitar.Name = "Gibson";
            guitar.Description = "It's Good Quality";

            string sound = guitar.Play();

            Musician musician = new Musician();
            musician.Name = "Ekin Anıl";
            musician.LastName = "Guitarson";

            MessageBox.Show(string.Format(@"
                Musician Name:{0}
                Musician Last Name: {1}
                Sound of Instrument: {2}
                Intrument Brand: {3}",musician.Name,musician.LastName,sound,musician.Instrument.Name));
        }
    }
}
