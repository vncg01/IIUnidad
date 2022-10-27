using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void listaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosFrom userFrom = new UsuariosFrom();
            userFrom.Show();
        }
    }
}
