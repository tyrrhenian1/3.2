using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace _3._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> numbers = new List<int>();

        private void countBox_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) //При нажатии на Enter в TextBox, введенное число добавляется в список
            {
                bool Check = int.TryParse(countBox.Text, out _);
                if (Check) //Проверка,что бы было введено число
                {
                    int a;
                    a = Convert.ToInt32(countBox.Text);
                    numbers.Add(a);
                    countBox.Text = "";
                    if (a == 0) //Проверка введенного значения
                    {
                        int res = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > 0)
                            {
                                res += numbers[i];
                            }
                        }
                        resultBox.Text = Convert.ToString(res);
                        numbers.Clear();
                    }
                    
                }
                else countBox.Text = "Нельзя";
            }
        }
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int res = 0;
            for (int i = 0;i < numbers.Count;i++)
            {
                if (numbers[i] > 0)
                {
                    res += numbers[i];
                }
            }
            resultBox.Text = Convert.ToString(res);
            numbers.Clear();
        }

       
    }
}
