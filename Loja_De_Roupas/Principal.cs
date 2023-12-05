using SuaLojaDeRoupas;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void endereçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //instanciando objetos da classe Form1 (esses são os comandos para abrir outra tela)
            Form2 form2 = new Form2();
            //ShowDialog bloqueia tudo que está atras dela, já o Show não bloqueia, então da para clicar na tela de login, por isso estamos usando o ShowDialog
            form2.ShowDialog();
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciando objetos da classe Form1 (esses são os comandos para abrir outra tela)
            Aparencia aparencia = new Aparencia();
            //ShowDialog bloqueia tudo que está atras dela, já o Show não bloqueia, então da para clicar na tela de login, por isso estamos usando o ShowDialog
            aparencia.ShowDialog();
        }

        private void calendárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //instanciando objetos da classe Form1 (esses são os comandos para abrir outra tela)
            Calendario calendario = new Calendario();
            //ShowDialog bloqueia tudo que está atras dela, já o Show não bloqueia, então da para clicar na tela de login, por isso estamos usando o ShowDialog
            calendario.ShowDialog();
        }
    }
}
