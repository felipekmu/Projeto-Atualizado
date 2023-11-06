using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodball
{
    public partial class AdicionarPratos : Form
    {
        public AdicionarPratos()
        {
            InitializeComponent();
        }

        private void adicionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telainical formulario = new Telainical();
            formulario.Show();
            this.Close();
        }

        private void adicionarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarClientes formulario = new AdicionarClientes();
            formulario.Show();
            this.Close();
        }

        private void AdicionarPratos_Load(object sender, EventArgs e)
        {

        }
    }
}
