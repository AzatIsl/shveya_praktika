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
	/// Логика взаимодействия для Registration.xaml
	/// </summary>
	public partial class Registration : Window
	{
		public Registration()
		{
			InitializeComponent();
		}

		private void ButtonReg_Click(object sender, RoutedEventArgs e)
		{
			if (Login.Text == "" || Password.Password == "" || RepeatedPassword.Password == "")
			{
				MessageBox.Show("Заполните все поля");
			}
			else
			{
				if (Password.Password != RepeatedPassword.Password)
				{
					MessageBox.Show("Пароли не совпадают");
				}
				else
				{
					using (var db = new praktikaEntities1())
					{
						Пользователи user = new Пользователи
						{
							Логин = Login.Text,
							Пароль = Password.Password,
							IdРоли = 4
						};
						if (db.Пользователи.Any(x => x.Логин == Login.Text))
						{
							MessageBox.Show("Пользователь с таким логином уже зарегистрирован");
						}
						else
						{
							db.Пользователи.Add(user);
							db.SaveChanges();
							Authorization authorization = new Authorization();
							authorization.Show();
							this.Close();
						}
					}
				}
			}
		}

		private void AutButton_Click(object sender, RoutedEventArgs e)
		{
			Authorization authorization = new Authorization();
			authorization.Show();
			this.Close();
		}
	}
}
