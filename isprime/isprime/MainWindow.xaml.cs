using System;
using System.Windows;

namespace isprime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM(); //建立新的对象
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm; //绑定vm的数据来源
        }

        public bool isPrime(int num) //以6的倍数判断是否是素数
        {
            if (num == 2 || num == 3)
            {
                return true;
            }
            if (num % 6 != 1 && num % 6 != 5)
            {
                return false;
            }
            int tmp = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(num)));
            for (int i = 5; i <= tmp; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int size = vm.TargetNum; //获取对象的内容

            for (int i = 2; i <= size; i++)
            {
                if (isPrime(i) == true)
                {
                    primeResult.Items.Add(i);
                }
            }
        }
    }
}
