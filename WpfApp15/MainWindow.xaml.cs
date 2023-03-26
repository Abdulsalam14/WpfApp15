using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void chckbx_Click(object sender, RoutedEventArgs e)
        {
            heg.Value = 0;
            wid.Value = 0;
            if (chckbx.IsChecked == true)
            {
                Binding binding = new Binding("Value");
                binding.Source = wid;
                binding.Mode = BindingMode.TwoWay;
                heg.SetBinding(Slider.ValueProperty, binding);
            }
            else if(chckbx.IsChecked == false)
            {
                heg.ClearValue(Slider.ValueProperty);
            }
        }
    }
}


