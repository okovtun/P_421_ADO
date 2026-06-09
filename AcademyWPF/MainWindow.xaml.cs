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

using System.Configuration;
using DBtools;

namespace AcademyWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Connector connector;
		DataGrid[] tables;
		public MainWindow()
		{
			InitializeComponent();
			connector = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
			tables = new DataGrid[] { dgStudents, dgGroups, dgDirections, dgDisciplines, dgTeachers };
		}

		private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			int i = (sender as TabControl).SelectedIndex;
			tables[i].ItemsSource = connector.Load
				($"SELECT * FROM {(tabControl.Items[i] as TabItem).Header}").DefaultView;
		}
	}
}
