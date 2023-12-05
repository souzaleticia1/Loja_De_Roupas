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
        //private Tema tema;  // Mantenha uma única instância de Tema
        public Aparencia()
        {
            InitializeComponent();
            //tema = new Tema();
            /*tema.AtualizarAparencia();*/ /*// Certifique-se de que o tema é inicializado corretamente*/
            //InicializarTema();
        }

        Tema tema = new Tema();

        private void InicializarTema()
        {
            //tema.AtualizarAparencia();

            // Adicione os eventos CheckedChanged aos RadioButtons, se existirem
            //if (radioButtonTemaClaro != null && radioButtonTemaEscuro != null)
            //{
            //    radioButtonTemaClaro.CheckedChanged += RadioButtonTema_CheckedChanged;
            //    radioButtonTemaEscuro.CheckedChanged += RadioButtonTema_CheckedChanged;
            //}
            //void RadioButtonTema_CheckedChanged(object sender, EventArgs e)
            //{
            //    // Verifica qual RadioButton está marcado e atualiza o tema conforme necessário
            //    if (radioButtonTemaClaro.Checked)
            //    {
            //        tema.AtualizarAparencia(false);
            //    }
            //    else if (radioButtonTemaEscuro.Checked)
            //    {
            //        tema.AtualizarAparencia(true);
            //    }
            //}


            // Atualize a aparência inicial
            //AtualizarAparencia();



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

        //public void AtualizarAparencia()
        //{
        //    if (temaEscuro)
        //    {
        //        this.BackColor = Color.DarkSlateGray;
        //        // Adicione outras configurações de estilo para o tema escuro...
        //    }
        //    else
        //    {
        //        this.BackColor = SystemColors.Control;
        //        // Adicione outras configurações de estilo para o tema claro...
        //    }
        //    // Defina as cores para o tema claro
        //    Color colorBackClaro = Color.White;
        //    Color colorTextClaro = Color.Black;

        //    // Defina as cores para o tema escuro
        //    Color colorBackEscuro = Color.FromArgb(45, 45, 48);
        //    Color colorTextEscuro = Color.White;

        //    void AlterTheme(bool themeEscuro)
        //    {
        //        // Altere as cores com base no tema escolhido
        //        this.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
        //        this.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

        //        // Itere através de todos os controles no formulário
        //        foreach (Control control in this.Controls)
        //        {
        //            // Aplique o tema aos controles recursivamente (se necessário)
        //            ApllyThemeToControls(control, themeEscuro);
        //        }
        //    }

        //    void ApllyThemeToControls(Control control, bool themeEscuro)
        //    {
        //        // Altere as cores dos controles
        //        control.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
        //        control.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

        //        // Itere através dos controles filhos recursivamente
        //        foreach (Control control2 in control.Controls)
        //        {
        //            ApllyThemeToControls(control2, themeEscuro);
        //        }
        //    }

        //}
        //private void AtualizarAparencia()
        //{
        //    Tema.AplicarTemaEscuro(); // Pode ser Tema.AplicarTemaClaro() conforme necessário
        //}

        //// Inscreva-se no evento TemaAlterado
        //GerenciadorTema.ChangedTheme += (sender, args) =>
        //{
        //    // Atualize a aparência de todos os formulários abertos
        //    foreach (Form form in Application.OpenForms)
        //    {
        //        GerenciadorTema.AtualizarAparencia(form);
        //    }

        //    // Inscreva-se no evento TemaAlterado
        //    GerenciadorTema.TemaAlterado += (sender, args) =>
        //    {
        //        // Atualize a aparência do formulário quando o tema for alterado
        //        GerenciadorTema.AtualizarAparencia(this);
        //    };
        //}

        //    // Restante do código do formulário...
        //}



        //// Inscreva-se no evento TemaAlterado
        //GerenciadorTema.TemaAlterado += (sender, args) =>
        //{
        //    // Atualize a aparência do formulário quando o tema for alterado
        //    GerenciadorTema.AtualizarAparencia(this);
        //};

        // Restante do código do formulário...




        //private void radioButtonClaro_CheckedChanged(object sender, EventArgs e)
        //{
        //    AplicarTemaClaro();
        //}

        //private void radioButtonEscuro_CheckedChanged(object sender, EventArgs e)
        //{
        //    AplicarTemaEscuro();
        //}


        //// Defina as cores para o tema claro
        //Color colorBackClaro = Color.White;
        //Color colorTextClaro = Color.Black;

        //// Defina as cores para o tema escuro
        //Color colorBackEscuro = Color.FromArgb(45, 45, 48);
        //Color colorTextEscuro = Color.White;

        ////private void AlterTheme(bool themeEscuro)
        ////{
        ////    // Altere as cores com base no tema escolhido
        ////    this.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
        ////    this.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

        ////    // Itere através de todos os controles no formulário
        ////    foreach (Control control in this.Controls)
        ////    {
        ////        // Aplique o tema aos controles recursivamente (se necessário)
        ////        ApllyThemeToControls(control, themeEscuro);
        ////    }
        ////}

        ////private void ApllyThemeToControls(Control control, bool themeEscuro)
        ////{
        ////    // Altere as cores dos controles
        ////    control.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
        ////    control.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

        ////    // Itere através dos controles filhos recursivamente
        ////    foreach (Control control2 in control.Controls)
        ////    {
        ////        ApllyThemeToControls(control2, themeEscuro);
        ////    }
        ////}

        //private void AtualizarAparencia()
        //{
        //    // Lógica para atualizar a aparência com base nas configurações de tema
        //    AlternarTema(Tema.TemaEscuro);
        //}

        //private void AlternarTema(bool themeEscuro)
        //{
        //    // Lógica para alternar o tema baseado no valor de temaEscuro
        //    this.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
        //    this.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

        //    foreach (Control control in this.Controls)
        //    {
        //        ApllyThemeToControls(control, themeEscuro);
        //    }
        //}

        //private void ApllyThemeToControls(Control control, bool themeEscuro)
        //{
        //    control.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
        //    control.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

        //    foreach (Control control2 in control.Controls)
        //    {
        //        ApllyThemeToControls(control2, themeEscuro);
        //    }
        //}



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonTemaClaro_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButtonTemaClaro.Checked)
            //{
            //    Tema.TemaEscuro = false; // Tema claro
            //    AtualizarAparencia();
            //}

            //tema.AtualizarAparencia();

            //tema.AtualizarAparencia();

            tema.AtualizarAparencia(false);


        }

        private void radioButtonTemaEscuro_CheckedChanged(object sender, EventArgs e)
            {
            //if (radioButtonTemaEscuro.Checked)
            //{
            //    Tema.TemaEscuro = true; // Tema escuro
            //    AtualizarAparencia();
            //}

            //Tema tema = new Tema();
            //tema.AplicarTemaEscuro();

            //tema.AtualizarAparencia();

            //tema.AtualizarAparencia();

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


