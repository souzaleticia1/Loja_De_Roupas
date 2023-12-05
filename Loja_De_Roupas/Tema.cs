//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Configuration;

//namespace Loja_De_Roupas
//{
//    internal class Tema
//    {

//public static class ConfiguracoesTema
//    {
//        private const string ChaveTema = "TemaEscuro";

//        public static bool TemaEscuro
//        {
//            get
//            {
//                string valor = ConfigurationManager.AppSettings[ChaveTema];
//                return string.IsNullOrEmpty(valor) ? false : Convert.ToBoolean(valor);
//            }
//            set
//            {
//                ConfigurationManager.AppSettings[ChaveTema] = value.ToString();
//            }
//        }
//    }

//}
//}

//using System;
//using System.Drawing;
//using System.IO;
//using System.Windows.Forms;

//public static class Tema
//{
//private static readonly string caminhoArquivo = "configuracoesTema.txt";

//public static bool TemaEscuro
//{
//    get
//    {
//        return File.Exists(caminhoArquivo) ? Convert.ToBoolean(File.ReadAllText(caminhoArquivo)) : false;
//    }
//    set
//    {
//        File.WriteAllText(caminhoArquivo, value.ToString());
//    }
//}

//using System.Drawing;
//using System.Windows.Forms;

//public class Tema : Form
//{
//    protected bool temaEscuro = false;

//    //public Tema()
//    //{
//    //    AtualizarAparencia();
//    //}

//    public void AtualizarAparencia()
//    {
//        if (temaEscuro)
//        {
//            this.BackColor = Color.DarkSlateGray;
//            // Adicione outras configurações de estilo para o tema escuro...
//        }
//        else
//        {
//            this.BackColor = SystemColors.Control;
//            // Adicione outras configurações de estilo para o tema claro...
//        }
//    }

//    public void AplicarTemaEscuro()
//    {
//        temaEscuro = true;
//        AtualizarAparencia();
//    }

//    public void AplicarTemaClaro()
//    {
//        temaEscuro = false;
//        AtualizarAparencia();
//    }
//}



//using System;
//using System.Drawing;
//using System.Windows.Forms;

//public static class Tema
//{
//    private static bool temaEscuro = false;

//    public static bool TemaEscuro
//    {
//        get { return temaEscuro; }
//        set
//        {
//            if (temaEscuro != value)
//            {
//                temaEscuro = value;
//                ChangedTheme?.Invoke(null, EventArgs.Empty);
//            }
//        }
//    }

//    public static event EventHandler ChangedTheme;

//    public static void AtualizarAparencia(Form formulario)
//    {
//        // Lógica para atualizar a aparência do formulário com base no tema
//        if (temaEscuro)
//        {
//            formulario.BackColor = Color.DarkSlateGray;
//            // Adicione outros controles e suas propriedades de estilo aqui...
//        }
//        else
//        {
//            formulario.BackColor = SystemColors.Control;
//            // Adicione outros controles e suas propriedades de estilo aqui...
//        }
//    }
//}

//using System;
//using System.Drawing;
//using System.Windows.Forms;

//public static class Tema
//{
//    private static bool temaEscuro = false;

//    public static bool TemaEscuro
//    {
//        get { return temaEscuro; }
//        set
//        {
//            if (temaEscuro != value)
//            {
//                temaEscuro = value;
//                OnTemaAlterado(EventArgs.Empty);
//            }
//        }
//    }

//    public static event EventHandler ChangedTheme;

//    private static void OnTemaAlterado(EventArgs e)
//    {
//        // Dispara o evento para notificar todos os ouvintes
//        ChangedTheme?.Invoke(null, e);
//    }

//    public static void AtualizarAparencia(Form formulario)
//    {
//        // Lógica para atualizar a aparência do formulário com base no tema
//        if (temaEscuro)
//        {
//            formulario.BackColor = Color.DarkSlateGray;
//            // Adicione outros controles e suas propriedades de estilo aqui...
//        }
//        else
//        {
//            formulario.BackColor = SystemColors.Control;
//            // Adicione outros controles e suas propriedades de estilo aqui...
//        }
//    }
//}

//using System;
//using System.Drawing;
//using System.Windows.Forms;

//public static class Tema
//{
//    private static bool temaEscuro = false;

//    public static bool TemaEscuro
//    {
//        get { return temaEscuro; }
//        set
//        {
//            if (temaEscuro != value)
//            {
//                temaEscuro = value;
//                OnTemaAlterado(EventArgs.Empty);
//            }
//        }
//    }

//    public static event EventHandler ChangedTheme;

//    private static void OnTemaAlterado(EventArgs e)
//    {
//        // Dispara o evento para notificar todos os ouvintes
//        ChangedTheme?.Invoke(null, e);
//    }

//    public static void AtualizarAparencia(Form formulario)
//    {
//        // Lógica para atualizar a aparência do formulário com base no tema
//        if (temaEscuro)
//        {
//            formulario.BackColor = Color.DarkSlateGray;
//            // Adicione outros controles e suas propriedades de estilo aqui...
//        }
//        else
//        {
//            formulario.BackColor = SystemColors.Control;
//            // Adicione outros controles e suas propriedades de estilo aqui...
//        }
//    }
//}

//using System;
//using System.Drawing;
//using System.Windows.Forms;

//public class Tema : Form
//{
//    private static bool temaEscuro = false;

//    public Tema()
//    {
//        AtualizarAparencia();
//    }

//    public void AtualizarAparencia()
//    {
//        if (temaEscuro)
//        {
//            this.BackColor = Color.DarkSlateGray;
//            // Adicione outras configurações de estilo para o tema escuro...
//        }
//        else
//        {
//            this.BackColor = SystemColors.Control;
//            // Adicione outras configurações de estilo para o tema claro...
//        }
//    }

//    public static void AplicarTemaEscuro()
//    {
//        temaEscuro = true;
//        AtualizarAparenciaGlobal();
//    }

//    public static void AplicarTemaClaro()
//    {
//        temaEscuro = false;
//        AtualizarAparenciaGlobal();
//    }

//    private static void AtualizarAparenciaGlobal()
//    {
//        foreach (Form formularioAberto in Application.OpenForms)
//        {
//            if (formularioAberto is Tema)
//            {
//                ((Tema)formularioAberto).AtualizarAparencia();
//            }
//        }
//    }
//}

//using System;
//using System.Drawing;
//using System.Windows.Forms;

//public class Tema : Form
//{
//    private static bool temaEscuro = false;

//    // Evento que será acionado quando o tema for alterado
//    public static event EventHandler TemaAlterado;

//    public Tema()
//    {
//        AtualizarAparencia();
//    }

//    public void AtualizarAparencia()
//    {
//        if (temaEscuro)
//        {
//            this.BackColor = Color.DarkSlateGray;
//            // Adicione outras configurações de estilo para o tema escuro...
//        }
//        else
//        {
//            this.BackColor = SystemColors.Control;
//            // Adicione outras configurações de estilo para o tema claro...
//        }
//    }

//    public static void AplicarTemaEscuro()
//    {
//        temaEscuro = true;
//        // Dispara o evento para notificar os formulários sobre a mudança de tema
//        OnTemaAlterado();
//    }

//    public static void AplicarTemaClaro()
//    {
//        temaEscuro = false;
//        // Dispara o evento para notificar os formulários sobre a mudança de tema
//        OnTemaAlterado();
//    }

//    private static void OnTemaAlterado()
//    {
//        // Dispara o evento para notificar os formulários sobre a mudança de tema
//        TemaAlterado?.Invoke(null, EventArgs.Empty);
//    }
//}




//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Loja_De_Roupas
//{
//        public partial class Tema : Form
//        {
//        public void AtualizarAparencia()
//        {
//            // Defina as cores para o tema claro
//            Color colorBackClaro = Color.White;
//            Color colorTextClaro = Color.Black;

//            // Defina as cores para o tema escuro
//            Color colorBackEscuro = Color.FromArgb(45, 45, 48);
//            Color colorTextEscuro = Color.White;

//            void AlterTheme(bool themeEscuro)
//            {
//                // Altere as cores com base no tema escolhido
//                this.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
//                this.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

//                // Itere através de todos os controles no formulário
//                foreach (Control control in this.Controls)
//                {
//                    // Aplique o tema aos controles recursivamente (se necessário)
//                    ApllyThemeToControls(control, themeEscuro);
//                }
//            }

//            void ApllyThemeToControls(Control control, bool themeEscuro)
//            {
//                // Altere as cores dos controles
//                control.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
//                control.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

//                // Itere através dos controles filhos recursivamente
//                foreach (Control control2 in control.Controls)
//                {
//                    ApllyThemeToControls(control2, themeEscuro);
//                }
//            }
//        }
//    }
//}






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
    public partial class Tema : Form
    {
        // Defina as cores para o tema claro
        private Color colorBackClaro = Color.White;
        private Color colorTextClaro = Color.Black;

        // Defina as cores para o tema escuro
        private Color colorBackEscuro = Color.FromArgb(45, 45, 48);
        private Color colorTextEscuro = Color.White;

        public void AtualizarAparencia(bool themeEscuro)
        {
            AlterarTheme(themeEscuro);
        }

        private void AlterarTheme(bool themeEscuro)
        {
            // Altere as cores com base no tema escolhido
            this.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
            this.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

            // Itere através de todos os controles no formulário
            foreach (Control control in this.Controls)
            {
                // Aplique o tema aos controles recursivamente (se necessário)
                AplicarTemaAosControles(control, themeEscuro);
            }
        }

        private void AplicarTemaAosControles(Control control, bool themeEscuro)
        {
            // Altere as cores dos controles
            control.BackColor = themeEscuro ? colorBackEscuro : colorBackClaro;
            control.ForeColor = themeEscuro ? colorTextEscuro : colorTextClaro;

            // Itere através dos controles filhos recursivamente
            foreach (Control control2 in control.Controls)
            {
                AplicarTemaAosControles(control2, themeEscuro);
            }
        }
    }
}
