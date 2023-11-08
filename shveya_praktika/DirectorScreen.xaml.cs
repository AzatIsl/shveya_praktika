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
	/// Логика взаимодействия для DirectorScreen.xaml
	/// </summary>
	public partial class DirectorScreen : Window
	{
		public DirectorScreen()
		{
			InitializeComponent();
		}

		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			CurrentUser.Id = 0;
			Authorization authorization = new Authorization();
			authorization.Show();
			this.Close();
		}

		private void MaterialsButton_Click(object sender, RoutedEventArgs e)
		{
			Materials materials = new Materials();
			materials.Show();
			Close();
		}

		private void ReportsButton_Click(object sender, RoutedEventArgs e)
		{
			Reports reports = new Reports();
			reports.Show();
			this.Close();
		}
	}
}
