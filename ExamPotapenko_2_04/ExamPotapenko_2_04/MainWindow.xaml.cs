using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamPotapenko_2_04.Models;

namespace ExamPotapenko_2_04
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadClients();
        }
        public void LoadClients()
        {
            using(var db = new Potapenko_2_Exam_04Context())
            {
                listClients.ItemsSource = db.Order.ToList();
            }
           
        }
        private void OrderButton(object sender, RoutedEventArgs e)
        {
            var order = new OrderWindow();
            if (order.ShowDialog() == true)
            {
                LoadClients();
            }
        }

        private void EditOrder(object sender, MouseButtonEventArgs e)
        { //Если найден заказ в нажатых границах - открывается окно редактирования.
            if (sender is Border border && border.DataContext is Order selectedOrder)
            {
                EditOrderWindow editWindow = new EditOrderWindow(selectedOrder);
                if (editWindow.ShowDialog() == true)
                {
                    LoadClients();
                }
            }
        }
    }
}
