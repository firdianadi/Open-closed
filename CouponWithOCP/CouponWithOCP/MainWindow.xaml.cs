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

namespace CouponWithOCP
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Coupon coupon1 = new CouponWithNominal(2000);
            Console.WriteLine(coupon1.calculate(10000));

            Coupon coupon2 = new CouponWithPercentage(25);
            Console.WriteLine(coupon2.calculate(10000));

            Coupon coupon3 = new CouponWithMaxNominal(90, 3000);
            Console.WriteLine(coupon3.calculate(10000));

            Coupon coupon4 = new CouponWithCashback(500);
            Console.WriteLine(coupon4.calculate(10000));


        }
    }
}
