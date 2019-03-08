using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContaDeBar
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {

        ContaBar contaBar = new ContaBar();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDespesa_Click(object sender, RoutedEventArgs e)
        {
            contaBar.ValorUnitario = Convert.ToDecimal(txtValorUnitario.Text);
            contaBar.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            contaBar.QtdPessoas = Convert.ToInt32(txtQtdPessoas.Text);
            bool garcom = Convert.ToBoolean(ckGarcom.IsChecked);

            contaBar.AdicionaCompra(garcom);
            contaBar.CalculoPorPessoa();

            lblTotal.Content = contaBar.Total.ToString();
            lblTotalPessoa.Content = contaBar.TotalPessoa.ToString();

            txtQuantidade.Clear();
            txtValorUnitario.Clear();
        }
    }
}
