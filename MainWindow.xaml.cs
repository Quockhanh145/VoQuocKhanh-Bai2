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

namespace Bai_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_binh_phuong_Click(object sender, RoutedEventArgs e)
        {
            int so;
            so = Int32.Parse(txtSo.Text);
            int kq = so * so;
            txtKq.Text = kq.ToString();         
        }

        private void btn_lap_phuong_Click(object sender, RoutedEventArgs e)
        {
            int so;
            so = Int32.Parse(txtSo.Text);
            int kq = so * so * so;
            txtKq.Text = kq.ToString();
        }
        public int giaithua(int n)
        {
            int giai_thua = 1;
            for (int i = 1; i <= n; i++)
                giai_thua *= i;
            return giai_thua;

        }
        private void btn_Giai_thua_Click(object sender, RoutedEventArgs e)
        {
            int so;
            so = Int32.Parse(txtSo.Text);

            int kq = giaithua(so);
            txtKq.Text = kq.ToString();
        }
    }
}
