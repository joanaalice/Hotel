using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormCheckOut : Form
    {
        public FormCheckOut()
        {
            InitializeComponent();
        }

        private void linkLabelSaidaAntecipada_Click(object sender, EventArgs e)
        {
            labelQuartos.Text = "Todos os Quartos";
        }
    }
}
