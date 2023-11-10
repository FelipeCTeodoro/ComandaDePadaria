using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComandaDePadaria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Instanciar um Usuário:

            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Email = txbEmail.Text;
            usuario.Senha = txbSenha.Text;

            // Obter o resultado do SELECT no banco:
            var resultado = usuario.Logar();

            if(resultado.Rows.Count == 1)
            {
                // Senha Correta: Prosseguir..

                usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                usuario.Id = (int)resultado.Rows[0]["id"];
                MessageBox.Show(usuario.NomeCompleto);

                // Próximo Passo Abrir a Janela de menu:

                MenuPrincipal janela = new MenuPrincipal();

                // Esconder a janela atual:

                Hide();

                // Mostrar o Login quando o menu fechar:

                janela.ShowDialog();


            }
            else
            {
                // Senha incorreta:
                MessageBox.Show("E-mail ou Senha Incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
