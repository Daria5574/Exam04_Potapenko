using ExamPotapenko_2_04.Models;
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

namespace ExamPotapenko_2_04
{
    /// <summary>
    /// Логика взаимодействия для EditOrderWindow.xaml
    /// </summary>
    public partial class EditOrderWindow : Window
    {
        Order _order;
        public EditOrderWindow(Order order)
        {
            InitializeComponent();
            _order = order;
        }
        private void BackButton(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void OrderButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
