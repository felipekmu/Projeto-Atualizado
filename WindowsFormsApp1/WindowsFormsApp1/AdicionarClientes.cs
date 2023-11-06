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
    public partial class AdicionarClientes : Form
    {
        public AdicionarClientes()
        {
            InitializeComponent();
        }

        public clCliente cliente;

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telainical formulario = new Telainical();
            formulario.Show();
            this.Close();
        }

        private void adicionarPratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarPratos formulario = new AdicionarPratos();
            formulario.Show();
            this.Close();
        }

        private void AdicionarClientes_Load(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                txtID.Text = cliente.idcliente.ToString();
                txtNome.Text = cliente.nome;
                txtCpf.Text = cliente.cpf;
                txtTelefone.Text = cliente.telefone;
                txtEmail.Text = cliente.email;
                btnSalvar.Text = "Atualizar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clCliente cliente = new clCliente();
            cliente.nome = txtNome.Text;
            cliente.cpf = txtCpf.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.email = txtEmail.Text;

            if (txtID.Text == "")
            {
                txtID.Text = Convert.ToString(cliente.Salvar());
            }
            else
            {
                cliente.idcliente = int.Parse(txtID.Text);
                cliente.Atualizar();
            }
        }
    }
}
