# Open-closed
# Penggunaan Open Closed Principle

Buat aplikasi console berjudul CouponWithOCP
Tambahkan abstract class Coupon.cs
public abstract class Coupon
    {
        public abstract double calculate(double originPrice);
    }

Buatlah class CouponWithNominal.cs
 class CouponWithNominal : Coupon
    {
        public double discNominal;

        public CouponWithNominal(double discNominal)
        {
            this.discNominal = discNominal;
        }

        public override double calculate(double originPrice)
        {
            return originPrice - discNominal;
        }
    }

Ubah class MainWindow.xaml.cs
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Coupon coupon1 = new CouponWithNominal(2000);
            Console.WriteLine(coupon1.calculate(10000));
        }
    }

Check Point 1: Jalankan aplikasi dengan run without debug

Buatlah class CouponWithPercentage.cs
class CouponWithPercentage : Coupon
    {
        public double discPercentage = 0;

        public CouponWithPercentage(double discPercentage)
        {
            this.discPercentage = discPercentage;
        }

        public override double calculate(double originPrice)
        {
            return (100 - discPercentage) * originPrice / 100;
        }
    }

Ubah class MainWindow.xaml.cs
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Coupon coupon1 = new CouponWithNominal(2000);
            Console.WriteLine(coupon1.calculate(10000));


            Coupon coupon2 = new CouponWithPercentage(25);
            Console.WriteLine(coupon2.calculate(10000));
        }
    }

Check Point 2: Jalankan aplikasi dengan run without debug

Buatlah class CouponWithMaxNominal.cs
 class CouponWithMaxNominal : Coupon
    {

        public double discPercentage = 0;
        public double discNominal=0;

        public CouponWithMaxNominal(double discPercentage, double discNominal)
        {
            this.discPercentage = discPercentage;
            this.discNominal = discNominal;
        }

        public override double calculate(double originPrice)
        {
            double discPercentageInRupiah = discPercentage * originPrice / 100;
            double finalPrice = 0;
            if (discPercentageInRupiah > discNominal)
            {
                finalPrice = originPrice - discNominal;
            }
            else
            {
                finalPrice = originPrice - discPercentageInRupiah;
            }
            return finalPrice;
        }
    }

Ubah class Program.cs
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Coupon coupon1 = new CouponWithNominal(2000);
            Console.WriteLine(coupon1.calculate(10000));


            Coupon coupon2 = new CouponWithPercentage(25);
            Console.WriteLine(coupon2.calculate(10000));


            Coupon coupon3 = new CouponWithMaxNominal(90,3000);
            Console.WriteLine(coupon3.calculate(10000));

        }
    }

Check Point 3: Jalankan aplikasi dengan run without debug

Buatlah class CouponWithCashback.cs
  class CouponWithCashback : Coupon
    {
        public double discNominal;

        public CouponWithCashback(double discNominal)
        {
            this.discNominal = discNominal;
        }

        public override double calculate(double originPrice)
        {
            return originPrice - discNominal;
        }
    }

Ubah class MainWindow.xaml.cs
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Coupon coupon1 = new CouponWithNominal(2000);
            Console.WriteLine(coupon1.calculate(10000));

            Coupon coupon2 = new CouponWithPercentage(25);
            Console.WriteLine(coupon2.calculate(10000));

            Coupon coupon3 = new CouponWithMaxNominal(90,3000);
            Console.WriteLine(coupon3.calculate(10000));

            Coupon coupon4 = new CouponWithCashback(500);
            Console.WriteLine(coupon4.calculate(10000));


        }
    }
