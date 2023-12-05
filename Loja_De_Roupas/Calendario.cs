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
//    public partial class Calendario : Form
//    {
//        public Calendario()
//        {
//            InitializeComponent();
//        }
//        // Configurar propriedades, se necessário
//        monthCalendar1.MaxDate = DateTime.Today.AddMonths(3);

//            // Destacar datas de promoção
//            AdicionarDatasDePromocao();
//    }

//    private void AdicionarDatasDePromocao()
//    {
//        // Substitua estas datas com as datas reais de suas promoções
//        DateTime dataPromocao1 = new DateTime(2023, 12, 15);
//        DateTime dataPromocao2 = new DateTime(2023, 12, 20);

//        // Adicionar datas de promoção à lista de datas em negrito
//        monthCalendar1.BoldedDates = new DateTime[] { dataPromocao1, dataPromocao2 };
//    }

//    //private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
//    //{

//    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuaLojaDeRoupas
{
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();

            // Configurar propriedades, se necessário
            monthCalendar1.MaxDate = DateTime.Today.AddMonths(3);

            // Destacar datas de promoção
            AdicionarDatasDePromocao();
        }

        private void AdicionarDatasDePromocao()
        {
            // Substitua estas datas com as datas reais de suas promoções
            DateTime dataPromocao1 = new DateTime(2023, 12, 15);
            DateTime dataPromocao2 = new DateTime(2023, 12, 20);

            // Adicionar datas de promoção à lista de datas em negrito
            monthCalendar1.BoldedDates = new DateTime[] { dataPromocao1, dataPromocao2 };
        }

        
private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
{

}

private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
{
    // Lidar com a data selecionada
    DateTime dataSelecionada = e.Start;
    MessageBox.Show($"Data selecionada: {dataSelecionada.ToShortDateString()}");
}

    }
}

