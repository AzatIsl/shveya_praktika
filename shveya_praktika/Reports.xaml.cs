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
	/// Логика взаимодействия для Reports.xaml
	/// </summary>
	public partial class Reports : Window
	{
		public Reports()
		{
			InitializeComponent();
		}

		private void BackButton_Click(object sender, RoutedEventArgs e)
		{
			DirectorScreen directorScreen = new DirectorScreen();
			directorScreen.Show();
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
