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
using System.Windows.Shapes;

namespace shveya_praktika
{
	/// <summary>
	/// Логика взаимодействия для CustomerScreen.xaml
	/// </summary>
	public partial class CustomerScreen : Window
	{
		public CustomerScreen()
		{
			InitializeComponent();
		}

		private void OrderCreateButton_Click(object sender, RoutedEventArgs e)
		{
			CreatingOrder creatingOrder = new CreatingOrder();
			creatingOrder.Show();
			this.Close();
		}

		private void OrdersButton_Click(object sender, RoutedEventArgs e)
		{
			Orders orders = new Orders();
			orders.Show();
			this.Close();
		}
		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			CurrentUser.Id = 0;
			Authorization authorization = new Authorization();
			authorization.Show();
			this.Close();
		}
    }
}
