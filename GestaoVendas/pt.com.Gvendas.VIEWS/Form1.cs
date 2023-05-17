using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();
            obj.Nome = txtNome.Text;
            obj.telefone = txtNum.Text;
            obj.morada = txtMorada.Text;
            obj.email = txtemail.Text;
        }
    }
}
