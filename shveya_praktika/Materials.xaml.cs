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
	/// Логика взаимодействия для Materials.xaml
	/// </summary>
	public partial class Materials : Window
	{
		public Materials()
		{
			InitializeComponent();
			using (praktikaEntities1 db = new praktikaEntities1())
			{
				if (db.Пользователи.Where(x => x.Id == CurrentUser.Id).First().IdРоли == 3 || db.Пользователи.Where(x => x.Id == CurrentUser.Id).First().IdРоли == 1)
				{
					SelectList.Items.Add("Изделия");
				}
			}
		}

		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (SelectList.SelectedIndex == 0)
			{
				using (praktikaEntities1 db = new praktikaEntities1())
				{
					List<Ткани> clothes = new List<Ткани>();
					clothes = db.Ткани.ToList();

					DataGridForList.ItemsSource = clothes;
				}
			}
			else if (SelectList.SelectedIndex == 1)
			{
				using (praktikaEntities1 db = new praktikaEntities1())
				{
					List<Фурнитура> furniture = new List<Фурнитура>();
					furniture = db.Фурнитура.ToList();

					DataGridForList.ItemsSource = furniture;
				}
			}
			else if (SelectList.SelectedIndex == 2)
			{
				using (praktikaEntities1 db = new praktikaEntities1())
				{
					List<Изделия> goods = new List<Изделия>();
					goods = db.Изделия.ToList();

					DataGridForList.ItemsSource = goods;
				}
			}
		}

		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			CurrentUser.Id = 0;
			Authorization authorization = new Authorization();
			authorization.Show();
			this.Close();
		}

		private void BackButton_Click(object sender, RoutedEventArgs e)
		{
			using (praktikaEntities1 db = new praktikaEntities1())
			{
				if (db.Пользователи.Where(x => x.Id == CurrentUser.Id).First().IdРоли == 1)
				{
					DirectorScreen directorScreen = new DirectorScreen();
					directorScreen.Show();
					this.Close();
				}
				else if (db.Пользователи.Where(x => x.Id == CurrentUser.Id).First().IdРоли == 2)
				{
					StorekeeperScreen storekeeperScreen = new StorekeeperScreen();
					storekeeperScreen.Show();
					this.Close();
				}
				else
				{
					ManagerScreen managerScreen = new ManagerScreen();
					managerScreen.Show();
					this.Close();
				}
			}

		}
	}
}
