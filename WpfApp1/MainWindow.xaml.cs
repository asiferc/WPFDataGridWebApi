using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //DataTable dt;
        public MainWindow()
        {
            InitializeComponent();
            GetDataFromWebApi();
        }

        public void GetDataFromWebApi()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("https://localhost:44320/Data/").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                List<Employee> data = JsonConvert.DeserializeObject<List<Employee>>(stringData);
                dataGrid1.ItemsSource = data;
            }
        }

        private void txtId_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            int filter = Convert.ToInt32(t.Text);
            ICollectionView cv = CollectionViewSource.GetDefaultView(dataGrid1.ItemsSource);
            if (filter == 0)
                cv.Filter = null;
            else
            {
                cv.Filter = o =>
                {
                    Employee p = o as Employee;
                    return p.EmployeeID == (filter);
                };
            }
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            string filter = t.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(dataGrid1.ItemsSource);
            if (filter == "")
                cv.Filter = null;
            else
            {
                cv.Filter = o =>
                {
                    Employee p = o as Employee;
                    return (p.EmployeeName.ToUpper().Contains(filter.ToUpper()));
                };
            }
        }

        private void txtLocation_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            string filter = t.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(dataGrid1.ItemsSource);
            if (filter == "")
                cv.Filter = null;
            else
            {
                cv.Filter = o =>
                {
                    Employee p = o as Employee;
                    return (p.Location.ToUpper().Contains(filter.ToUpper()));
                };
            }
        }

        private void txtReportingManager_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            string filter = t.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(dataGrid1.ItemsSource);
            if (filter == "")
                cv.Filter = null;
            else
            {
                cv.Filter = o =>
                {
                    Employee p = o as Employee;
                    return (p.ReportingManager.ToUpper().Contains(filter.ToUpper()));                    
                };
            }
        }
    }

}
