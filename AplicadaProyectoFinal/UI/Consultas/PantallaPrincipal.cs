using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicadaProyectoFinal
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario ru = new RegistroUsuario();
            ru.Show();
        }
    }
}
