using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;


            if(login=="Miltom" && senha == "123")
            {
                MessageBox.Show("Você está conectado!!");
                panelSaldo.Visible = true;
            }
            else
            {
                MessageBox.Show("Tá errado kkkkkkkk");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
