using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_De_Roupas
{
    public partial class Aparencia : Form
    {
        public Aparencia()
        {
            InitializeComponent();
        }

        Tema tema = new Tema();

        private void InicializarTema()
        {
            // Adicione os eventos CheckedChanged aos RadioButtons
            radioButtonTemaClaro.CheckedChanged += RadioButtonTema_CheckedChanged;
            radioButtonTemaEscuro.CheckedChanged += RadioButtonTema_CheckedChanged;

            // Atualize a aparência inicial
            AtualizarAparencia();
        }
        private void RadioButtonTema_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica qual RadioButton está marcado e atualiza o tema conforme necessário
            if (radioButtonTemaClaro.Checked)
            {
                tema.AtualizarAparencia(false);
            }
            else if (radioButtonTemaEscuro.Checked)
            {
                tema.AtualizarAparencia(true);
            }
        }

        private void AtualizarAparencia()
        {
            // Chame o método AtualizarAparencia da instância Tema
            tema.AtualizarAparencia(radioButtonTemaEscuro.Checked);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonTemaClaro_CheckedChanged(object sender, EventArgs e)
        {
            tema.AtualizarAparencia(false);
        }

        private void radioButtonTemaEscuro_CheckedChanged(object sender, EventArgs e)
        {
            tema.AtualizarAparencia(true);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //instanciando objetos da classe Form1 (esses são os comandos para abrir outra tela)
            Principal principal = new Principal();
            //ShowDialog bloqueia tudo que está atras dela, já o Show não bloqueia, então da para clicar na tela de login, por isso estamos usando o ShowDialog
            principal.ShowDialog();
        }

        private void Aparencia_Load(object sender, EventArgs e)
        {
           
        }
    
    }

}


