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

        // Defina as cores para o tema claro
        Color colorBackClaro = Color.White;
        Color colorTextClaro = Color.Black;

        // Defina as cores para o tema escuro
        Color colorBackEscuro = Color.FromArgb(45, 45, 48);
        Color colorTextEscuro = Color.White;

        //private void AlterTheme(bool themeEscuro)
        //{
        //    // Altere as cores com base no tema escolhido
        //    this.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
        //    this.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

        //    // Itere através de todos os controles no formulário
        //    foreach (Control control in this.Controls)
        //    {
        //        // Aplique o tema aos controles recursivamente (se necessário)
        //        ApllyThemeToControls(control, themeEscuro);
        //    }
        //}

        //private void ApllyThemeToControls(Control control, bool themeEscuro)
        //{
        //    // Altere as cores dos controles
        //    control.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
        //    control.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

        //    // Itere através dos controles filhos recursivamente
        //    foreach (Control control2 in control.Controls)
        //    {
        //        ApllyThemeToControls(control2, themeEscuro);
        //    }
        //}

        private void AtualizarAparencia()
        {
            // Lógica para atualizar a aparência com base nas configurações de tema
            AlternarTema(Tema.TemaEscuro);
        }

        private void AlternarTema(bool themeEscuro)
        {
            // Lógica para alternar o tema baseado no valor de temaEscuro
            this.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
            this.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

            foreach (Control control in this.Controls)
            {
                ApllyThemeToControls(control, themeEscuro);
            }
        }

        private void ApllyThemeToControls(Control control, bool themeEscuro)
        {
            control.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
            control.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

            foreach (Control control2 in control.Controls)
            {
                ApllyThemeToControls(control2, themeEscuro);
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTemaClaro_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTemaClaro.Checked)
            {
                Tema.TemaEscuro = false; // Tema claro
                AtualizarAparencia();
            }

        }

            private void radioButtonTemaEscuro_CheckedChanged(object sender, EventArgs e)
        {
                if (radioButtonTemaEscuro.Checked)
                {
                    Tema.TemaEscuro = true; // Tema escuro
                    AtualizarAparencia();
                }
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
            //// Carrega o estado do RadioButton ao carregar a tela
            //if (Properties.Settings.Default.TemaEscuro)
            //{
            //    radioButtonTemaEscuro.Checked = true;
            //}
            //else
            //{
            //    radioButtonTemaClaro.Checked = true;
            //}

            //// Atualiza a aparência com base nas configurações de tema
            //AtualizarAparencia();
        }
    }
}
