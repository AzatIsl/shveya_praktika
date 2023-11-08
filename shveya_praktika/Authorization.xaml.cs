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

namespace shveya_praktika
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class Authorization : Window
	{
		public Authorization()
		{
			InitializeComponent();
		}
		private void AutButton_Click(object sender, RoutedEventArgs e)
		{
			if (Login.Text == "" || Password.Password == "")
			{
				MessageBox.Show("Заполните все поля");
			}
			else
			{
				using (praktikaEntities1 db = new praktikaEntities1())
				{
					Пользователи user = db.Пользователи.Where(x => x.Логин == Login.Text && x.Пароль == Password.Password).FirstOrDefault();
					if (user != null)
					{
						CurrentUser.Id = user.Id;
						switch (user.IdРоли)
						{
							case 1:
								DirectorScreen screen = new DirectorScreen();
								screen.Show();
								this.Close();
								break;
							case 2:
								StorekeeperScreen storekeeperScreen = new StorekeeperScreen();
								storekeeperScreen.Show();
								this.Close();
								break;
							case 3:
								ManagerScreen managerScreen = new ManagerScreen();
								managerScreen.Show();
								this.Close();
								break;
							case 4:
								CustomerScreen customerScreen = new CustomerScreen();
								customerScreen.Show();
								this.Close();
								break;
						}

					}
					else
					{
						MessageBox.Show("Неверные данные для входа");
					}
				}
			}
		}
		private void RegButton_Click(object sender, RoutedEventArgs e)
		{


			Registration registration = new Registration();
			registration.Show();
			this.Close();

		}
	}
}
