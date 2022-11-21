using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openChoise(object sender, RoutedEventArgs e)
        {
            sender.ToString();
                

            Menu.Visibility = Visibility.Hidden;
            Choise.Visibility = Visibility.Visible;
        }
        private void closeProgramm(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void openMenu(object sender, RoutedEventArgs e)
        {
            Menu.Visibility = Visibility.Visible;
            Choise.Visibility = Visibility.Hidden;
        }
        private void myGif1_MediaEnded(object sender, RoutedEventArgs e)
        {
            myGif1.Position = new TimeSpan(0, 0, 1);
            myGif1.Play();
        }



        private void openChoiseLR1(object sender, RoutedEventArgs e)
        {
            LR1.Visibility = Visibility.Hidden;
            Choise.Visibility = Visibility.Visible;
        }
        private void openChoiseLR2(object sender, RoutedEventArgs e)
        {
            LR2.Visibility = Visibility.Hidden;
            Choise.Visibility = Visibility.Visible;
        }
        private void openChoiseLR3(object sender, RoutedEventArgs e)
        {
            LR3.Visibility = Visibility.Hidden;
            Choise.Visibility = Visibility.Visible;
        }
        private void openChoiseLR4(object sender, RoutedEventArgs e)
        {
            LR4.Visibility = Visibility.Hidden;
            Choise.Visibility = Visibility.Visible;
        }
        private void openChoiseLR5(object sender, RoutedEventArgs e)
        {
            LR5.Visibility = Visibility.Hidden;
            Choise.Visibility = Visibility.Visible;
        }
        private void openChoiseLR6(object sender, RoutedEventArgs e)
        {
            LR6.Visibility = Visibility.Hidden;
            Choise.Visibility = Visibility.Visible;
        }
        private void openChoiseLR7(object sender, RoutedEventArgs e)
        {
            LR7.Visibility = Visibility.Hidden;
            Choise.Visibility = Visibility.Visible;
        }
        private void openChoiseLR8(object sender, RoutedEventArgs e)
        {
            LR8.Visibility = Visibility.Hidden;
            Choise.Visibility = Visibility.Visible;
        }
        private void openChoiseLR9(object sender, RoutedEventArgs e)
        {
            LR9.Visibility = Visibility.Hidden;
            Choise.Visibility = Visibility.Visible;
        }
        private void openChoiseLR10(object sender, RoutedEventArgs e)
        {
            LR10.Visibility = Visibility.Hidden;
            Choise.Visibility = Visibility.Visible;
        }
        private void openChoiseLR11(object sender, RoutedEventArgs e)
        {
            LR11.Visibility = Visibility.Hidden;
            Choise.Visibility = Visibility.Visible;
        }




        private void openLR1(object sender, RoutedEventArgs e)
        {
            LR1.Visibility = Visibility.Visible;
            Choise.Visibility = Visibility.Hidden;
        }
        private void openLR2(object sender, RoutedEventArgs e)
        {
            LR2.Visibility = Visibility.Visible;
            Choise.Visibility = Visibility.Hidden;
        }
        private void openLR3(object sender, RoutedEventArgs e)
        {
            LR3.Visibility = Visibility.Visible;
            Choise.Visibility = Visibility.Hidden;
        }
        private void openLR4(object sender, RoutedEventArgs e)
        {
            LR4.Visibility = Visibility.Visible;
            Choise.Visibility = Visibility.Hidden;
        }
        private void openLR5(object sender, RoutedEventArgs e)
        {
            LR5.Visibility = Visibility.Visible;
            Choise.Visibility = Visibility.Hidden;
        }
        private void openLR6(object sender, RoutedEventArgs e)
        {
            LR6.Visibility = Visibility.Visible;
            Choise.Visibility = Visibility.Hidden;
        }
        private void openLR7(object sender, RoutedEventArgs e)
        {
            LR7.Visibility = Visibility.Visible;
            Choise.Visibility = Visibility.Hidden;
        }
        private void openLR8(object sender, RoutedEventArgs e)
        {
            LR8.Visibility = Visibility.Visible;
            Choise.Visibility = Visibility.Hidden;
        }
        private void openLR9(object sender, RoutedEventArgs e)
        {
            LR9.Visibility = Visibility.Visible;
            Choise.Visibility = Visibility.Hidden;
        }
        private void openLR10(object sender, RoutedEventArgs e)
        {
            LR10.Visibility = Visibility.Visible;
            Choise.Visibility = Visibility.Hidden;
        }
        private void openLR11(object sender, RoutedEventArgs e)
        {
            LR11.Visibility = Visibility.Visible;
            Choise.Visibility = Visibility.Hidden;
        }

        private void Switch(object sender_1, RoutedEventArgs e)
        {
            bool vis1 = part1.IsEnabled;
            if (vis1)
            {
                part1.IsEnabled = false;
                part2.IsEnabled = true;
                LR1_1.Visibility = Visibility.Visible;
                LR1_2.Visibility = Visibility.Hidden;
            }
            else
            {
                part1.IsEnabled = true;
                part2.IsEnabled = false;
                LR1_1.Visibility = Visibility.Hidden;
                LR1_2.Visibility = Visibility.Visible;
            }
        }
        
        private void LR1_Func1(object sender, RoutedEventArgs e)
        {
            try
            {
                double p = double.Parse(param_p.Text);
                double v = double.Parse(param_v.Text);
                double t = double.Parse(param_t.Text);
                double s = (v * t) / p;
                param_s.Text = s.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: \n"+ex.Message);
            }
        }
        private void LR1_Func2(object sender, RoutedEventArgs e)
        {
            string Eng = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            string Ru = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮЁйцукенгшщзхъфывапролджэячсмитьбюё";
            string Eng_Ru = Eng + Ru;
            string kek = "1234567890!£$%`^&*()_[]+=-{}#~";
            int L=0;
            try
            {
                L = int.Parse(length.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: \n" + ex.Message);
            }
            
            string password = "";
            Random rand = new Random();
            switch (Lang.Text)
            {
                case "Eng":
                    if (NAS.IsChecked == true)
                    {
                        for (int i = L - 1; i >= 0; i -= 2)
                        {
                            password += Eng[rand.Next(52)];
                            password += kek[rand.Next(30)];
                        }
                    }
                    else
                    {
                        for (int i = L - 1; i >= 0; i--)
                        {
                            password += Eng[rand.Next(52)];
                        }
                    }
                    break;
                case "Ru":
                    if (NAS.IsChecked == true)
                    {
                        for (int i = L - 1; i >= 0; i -= 2)
                        {
                            password += Ru[rand.Next(66)];
                            password += kek[rand.Next(30)];
                        }
                    }
                    else
                    {
                        for (int i = L - 1; i >= 0; i--)
                        {
                            password += Ru[rand.Next(66)];
                        }
                    }
                    break;
                case "Eng/Ru":
                    if (NAS.IsChecked == true)
                    {
                        for (int i = L - 1; i >= 0; i -= 2)
                        {
                            password += Eng_Ru[rand.Next(118)];
                            password += kek[rand.Next(30)];
                        }
                    }
                    else
                    {
                        for (int i = L - 1; i >= 0; i--)
                        {
                            password += Eng_Ru[rand.Next(118)];
                        }
                    }
                    break;
            }
            Password.Text = password;
        }
        private void LR1_Func3(object sender, RoutedEventArgs e)
        {
            string key = "";
            string password = "";
            string RU = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮЁ";
            string ru = "йцукенгшщзхъфывапролджэячсмитьбюё";

            try
            {
                key = keygen.Text;
                if (key.Equals(""))
                {
                    throw new Exception("Отсутствует ключ шифрования");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: \n" + ex.Message);
            }
            double n = key.Length;
            n=(n*n*n*n)%100;
            Random rand = new Random();
            for (int i = 0; i <= 6; i++)
            {
                
                if (i < 3)
                {
                    
                    password += ru[rand.Next(33)];
                }
                if (i>3 && i < 6)
                {
                    
                    password += RU[rand.Next(33)];
                }
                if (i == 6)
                {
                    if (n < 10)
                    {
                       
                        password += "0" + n;
                    }
                    else
                    {
                
                        password += n;
                    }
                }
            }
            Pass.Text = password;
        }



        private void LR2_Func1(object sender, RoutedEventArgs e)
        {
            int line = Code1.Text.Length / 8 + 1;
            char[,] code = new char[line, 8], decode = new char[8, line];
            char[] input = Code1.Text.ToCharArray(); string output = "";
            for (int i = 0; i < line; i++)
            {
                for (int j = 0;j<8; j++)
                {
                    code[i, j] = ' ';
                    decode[j, i] = ' ';
                }
            }
            try
            {
             
                    int count = 0;
                    if (input.Length > 40)
                    {
                        throw new Exception("Можно кодировать только текст\nразмерностью до 40 символов");
                    }
                    for (int i = 0; i < line; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (count == input.Length) break;
                            code[i, j] = input[count]; //Здесь вылетает:"Индекс находится вне границ массива"
                            count++;
                        }
                    }
                    for (int i = 0; i < line; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            decode[j, i] = code[i, j];

                        }
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < line; j++)
                        {
                            output += decode[i, j];
                        }
                    }
                
                DeCode1.Text = output;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: \n" + ex.Message);
            }
            //finally
            //{
            //    DeCode1.Text = input.Length.ToString();
            //}
        }
        private void LR2_Func2(object sender, RoutedEventArgs e)
        {
            int line = Code1.Text.Length / 8;
            char[,] code = new char[line, 8], decode = new char[8, line];
            char[] input = DeCode1.Text.ToCharArray(); string output = "";
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    code[i, j] = ' ';
                    decode[j, i] = ' ';
                }
            }
            try
            {
                int count = 0;
                if (input.Length > 40)
                {
                    throw new Exception("Можно кодировать только текст\nразмерностью до 40 символов");
                }
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < line; j++)
                    {
                        if (count == input.Length) break;
                        decode[i, j] = input[count]; //Здесь вылетает:"Индекс находится вне границ массива"
                        count++;
                    }
                }
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < line; j++)
                    {
                        code[j, i] = decode[i, j];
                    }
                }
                for (int i = 0; i < line; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        output += code[i, j];
                    }
                }


                DeCode1.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: \n" + ex.Message);
            }
        }
        private void LR2_Func3(object sender, RoutedEventArgs e)
        {
            DeCode2.Text = "";
            switch(Size.Text)
            {
                case "5x5 (25 симв.)":
                int[,] kv = new[,] { { 2, 18, 1, 23, 21 },
                                 { 12, 25, 5, 4, 19 },
                                 { 16, 9, 15, 14, 11 },
                                 { 13, 3, 24, 17, 8 },
                                 { 22, 10, 20, 7, 6 }
            };
                char[] input = Code2.Text.ToCharArray();
                char[,] output = new char[5, 5], pon = new char[5, 5];

                var IP = new Dictionary<int, char>();
                for (int i = 0; i < input.Length; i++)
                {
                    IP.Add(i + 1, input[i]);
                }

                int n = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        output[i, j] = ' ';
                        pon[i, j] = ' ';
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (n == input.Length) break;
                        pon[i, j] = input[n];
                        n++;
                    }
                }
                int p = 1;
                for (int k = 0; k < input.Length; k++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (p == kv[i, j])
                            {
                                output[i, j] = IP[p];
                                break;
                            }
                        }
                    }
                    p++;
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        DeCode2.Text += output[i, j].ToString();
                    }
                }
                    break;
                case "6x6 (36 симв.)":
                    int[,] kv1 = new[,] { {18,28,3,12,15,35  },
                                 {32,11,14,17,4,33 },
                                 {20,9,24,13,16,29 },
                                 {21,27,10,25,23,5 },
                                 {1,30,34,8,31,7 },
                                 {19,6,26,36,22,2 }};
                    char[] input1 = Code2.Text.ToCharArray();
                    char[,] output1 = new char[6, 6], pon1 = new char[6, 6];

                    var IP1 = new Dictionary<int, char>();
                    for (int i = 0; i < input1.Length; i++)
                    {
                        IP1.Add(i + 1, input1[i]);
                    }

                    int n1 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            output1[i, j] = ' ';
                            pon1[i, j] = ' ';
                        }
                    }
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (n1 == input1.Length) break;
                            pon1[i, j] = input1[n1];
                            n1++;
                        }
                    }
                    int p1 = 1;
                    for (int k = 0; k < input1.Length; k++)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (p1 == kv1[i, j])
                                {
                                    output1[i, j] = IP1[p1];
                                    break;
                                }
                            }
                        }
                        p1++;
                    }
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            DeCode2.Text += output1[i, j].ToString();
                        }
                    }
                    break;
            }
            //DeCode2.Text = input.ToString();
        }
        private void LR2_Func4(object sender, RoutedEventArgs e)
        {
            if (Size.Text == "5x5 (25 симв.)")
            {
                int[,] kv = new[,] { { 2, 18, 1, 23, 21 },
                                 { 12, 25, 5, 4, 19 },
                                 { 16, 9, 15, 14, 11 },
                                 { 13, 3, 24, 17, 8 },
                                 { 22, 10, 20, 7, 6 }};
                char[] input = Code2.Text.ToCharArray();
                var IP = new Dictionary<int, char>();
                int num, p = 0;
                string output = "";
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (p == input.Length) break;
                        num = kv[i, j];
                        IP[num] = input[p];
                        p++;
                    }
                }
                for (int i = 1; i <= input.Length; i++)
                {
                    output += IP[i];
                }
                DeCode2.Text = output;
            }
            if (Size.Text == "6x6 (36 симв.)")
            {
                int[,] kv = new[,]{ {18,28,3,12,15,35  },
                                 {32,11,14,17,4,33 },
                                 {20,9,24,13,16,29 },
                                 {21,27,10,25,23,5 },
                                 {1,30,34,8,31,7 },
                                 {19,6,26,36,22,2 }};
                char[] input = Code2.Text.ToCharArray();
                var IP = new Dictionary<int, char>();
                int num, p = 0;
                string output = "";
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (p == input.Length) break;
                        num = kv[i, j];
                        IP[num] = input[p];
                        p++;
                    }
                }
                for (int i = 1; i <= input.Length; i++)
                {
                    output += IP[i];
                }
                DeCode2.Text = output;
            }
        }
        private void Refere1(object sender, RoutedEventArgs e)
        {
            Code1.Text = DeCode1.Text;
        }
        private void Refere2(object sender, RoutedEventArgs e)
        {
            Code2.Text = DeCode2.Text;
        }


        private void CaesarSwitch(object sender, RoutedEventArgs e)
        {
            CaesarCode.Text = CaesarDecode.Text;
        }
        private void CaesarCoding(object sender, RoutedEventArgs e)
        {
            char[] s = CaesarCode.Text.ToCharArray(),
                abcR = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray(),
                ABCR = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray(),
                abcE = "abcdefghijkmnloprstuqvwxyz".ToCharArray(),
                ABCE = "ABCDEFGHIJKMNLOPRSTUQVWXYZ".ToCharArray();
            string output = "";
            switch (CaesarABC.Text)
            {
                case "Ru":
                    try
                    {
                        int param = int.Parse(CaesarKey.Text) % 10;
                        for (int i = 0; i < s.Length; i++)
                        {
                            for (int j = 0; j < 33; j++)
                            {
                                if (s[i] == abcR[j])
                                {
                                    if (j + param <= 32)
                                    {
                                        s[i] = abcR[j + param];
                                        output += s[i];

                                    }
                                    else
                                    {
                                        s[i] = abcR[j + param - 32 - 1];
                                        output += s[i];
                                    }
                                    break;
                                }
                                else if (s[i] == ABCR[j])
                                {
                                    if (j + param >= 32)
                                    {
                                        s[i] = ABCR[j + param - 32 - 1];
                                        output += s[i];
                                    }
                                    else
                                    {
                                        s[i] = ABCR[j + param];
                                        output += s[i];
                                    }
                                    break;
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: \n" + ex.Message);
                    }
                    break;
                case "Eng":
                    try
                    {
                        int param = int.Parse(CaesarKey.Text) % 10;
                        for (int i = 0; i < s.Length; i++)
                        {
                            for (int j = 0; j < 26; j++)
                            {
                                if (s[i] == abcE[j])
                                {
                                    if (j + param <= 25)
                                    {
                                        s[i] = abcE[j + param];
                                        output += s[i];
                                    }
                                    else
                                    {
                                        s[i] = abcE[j + param - 25 - 1];
                                        output += s[i];
                                    }
                                    break;
                                }
                                else if (s[i] == ABCE[j])
                                {
                                    if (j + param <= 25)
                                    {
                                        s[i] = ABCE[j + param];
                                        output += s[i];
                                    }
                                    else
                                    {
                                        s[i] = ABCE[j + param - 25 - 1];
                                        output += s[i];
                                    }
                                    break;
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: \n" + ex.Message);
                    }
                    break;
            }
            CaesarDecode.Text = output;
        }
        private void CaesarDecoding(object sender, RoutedEventArgs e)
        {
            char[] s = CaesarCode.Text.ToCharArray(),
                abcR = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray(),
                ABCR = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray(),
                abcE = "abcdefghijkmnloprstuqvwxyz".ToCharArray(),
                ABCE = "ABCDEFGHIJKMNLOPRSTUQVWXYZ".ToCharArray();
            string output = "";
            switch (CaesarABC.Text)
            {
                case "Ru":
                    try
                    {
                        int param = int.Parse(CaesarKey.Text) % 10;
                        for (int i = 0; i < s.Length; i++)
                        {
                            for (int j = 0; j < 33; j++)
                            {
                                if (s[i] == abcR[j])
                                {
                                    if (j - param < 0)
                                    {
                                        s[i] = abcR[32 + j - param + 1];
                                        output += s[i];
                                    }
                                    else
                                    {
                                        s[i] = abcR[j - param];
                                        output += s[i];
                                    }
                                    break;
                                }
                                else if (s[i] == ABCR[j])
                                {
                                    if (j + param < 0)
                                    {
                                        s[i] = ABCR[32 + j - param + 1];
                                        output += s[i];
                                    }
                                    else
                                    {
                                        s[i] = ABCR[j - param];
                                        output += s[i];
                                    }
                                    break;
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: \n" + ex.Message);
                    }
                    break;
                case "Eng":
                    try
                    {
                        int param = int.Parse(CaesarKey.Text) % 10;
                        for (int i = 0; i < s.Length; i++)
                        {
                            for (int j = 0; j < 26; j++)
                            {
                                if (s[i] == abcE[j])
                                {
                                    if (j - param < 0)
                                    {
                                        s[i] = abcE[25 + j - param + 1];
                                        output += s[i];
                                    }
                                    else
                                    {
                                        s[i] = abcE[j - param];
                                        output += s[i];
                                    }
                                    break;
                                }
                                else if (s[i] == ABCE[j])
                                {
                                    if (j - param < 0)
                                    {
                                        s[i] = ABCE[25 + j - param + 1];
                                        output += s[i];
                                    }
                                    else
                                    {
                                        s[i] = ABCE[j - param];
                                        output += s[i];
                                    }
                                    break;
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: \n" + ex.Message);
                    }
                    break;
            }
            CaesarDecode.Text = output;
        }

        

        private void TrisemSwitch(object sender, RoutedEventArgs e)
        {
            TrisemCode.Text = TrisemDecode.Text;
        }
        private void TrisemCoding(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(TrisemA.Text), 
                B = int.Parse(TrisemB.Text), 
                C = int.Parse(TrisemC.Text);
            char[] input = TrisemCode.Text.ToCharArray(),
                abcR = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray(),
                ABCR = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray(),
                abcE = "abcdefghijkmnloprstuqvwxyz".ToCharArray(),
                ABCE = "ABCDEFGHIJKMNLOPRSTUQVWXYZ".ToCharArray(); 
            string output = "";
            int param = 0;
            switch (Lang_T.Text)
            {
                case "Ru":
                    try
                    {
                        
                        for (int i = 0; i < input.Length; i++)
                        {
                            param = A * i * i + B * i + C;
                            if (param > 33) param = param % 33;
                            for (int j = 0; j < 33; j++)
                            {
                                if (input[i] == abcR[j])
                                {
                                    if (j + param <= 32)
                                    {
                                        input[i] = abcR[j + param];
                                        output += input[i];

                                    }
                                    else
                                    {
                                        input[i] = abcR[j + param - 32 - 1];
                                        output += input[i];
                                    }
                                    break;
                                }
                                else if (input[i] == ABCR[j])
                                {
                                    if (j + param >= 32)
                                    {
                                        input[i] = ABCR[j + param - 32 - 1];
                                        output += input[i];
                                    }
                                    else
                                    {
                                        input[i] = ABCR[j + param];
                                        output += input[i];
                                    }
                                    break;
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: \n" + ex.Message);
                    }
                    break;
                case "Eng":
                    try
                    {
                        
                        for (int i = 0; i < input.Length; i++)
                        {
                            param = A * i * i + B * i + C;
                            if (param > 26) param = param % 26;
                            for (int j = 0; j < 26; j++)
                            {
                                if (input[i] == abcE[j])
                                {
                                    if (j + param <= 25)
                                    {
                                        input[i] = abcE[j + param];
                                        output += input[i];
                                    }
                                    else
                                    {
                                        input[i] = abcE[j + param - 25 - 1];
                                        output += input[i];
                                    }
                                    break;
                                }
                                else if (input[i] == ABCE[j])
                                {
                                    if (j + param <= 25)
                                    {
                                        input[i] = ABCE[j + param];
                                        output += input[i];
                                    }
                                    else
                                    {
                                        input[i] = ABCE[j + param - 25 - 1];
                                        output += input[i];
                                    }
                                    break;
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: \n" + ex.Message);
                    }
                    break;
            }
            TrisemDecode.Text = output;
            
        }
        private void TrisemDecoding(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(TrisemA.Text), 
                B = int.Parse(TrisemB.Text), 
                C = int.Parse(TrisemC.Text);
            char[] input = TrisemCode.Text.ToCharArray(),
                abcR = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray(),
                ABCR = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray(),
                abcE = "abcdefghijkmnloprstuqvwxyz".ToCharArray(),
                ABCE = "ABCDEFGHIJKMNLOPRSTUQVWXYZ".ToCharArray(); 
            string output = "";
            int param = 0;
            switch (Lang_T.Text)
            {
                case "Ru":
                    try
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            param = (A * i * i + B * i + C)%33;
                            for (int j = 0; j < 33; j++)
                            {
                                if (input[i] == abcR[j])
                                {
                                    if (j - param < 0)
                                    {
                                        input[i] = abcR[32 + j - param + 1];
                                        output += input[i];
                                    }
                                    else
                                    {
                                        input[i] = abcR[j - param];
                                        output += input[i];
                                    }
                                    break;
                                }
                                else if (input[i] == ABCR[j])
                                {
                                    if (j + param < 0)
                                    {
                                        input[i] = ABCR[32 + j - param + 1];
                                        output += input[i];
                                    }
                                    else
                                    {
                                        input[i] = ABCR[j - param];
                                        output += input[i];
                                    }
                                    break;
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: \n" + ex.Message);
                    }
                    break;
                case "Eng":
                    try
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            param = (A * i * i + B * i + C)%26;
                            for (int j = 0; j < 26; j++)
                            {
                                if (input[i] == abcE[j])
                                {
                                    if (j - param < 0)
                                    {
                                        input[i] = abcE[25 + j - param + 1];
                                        output += input[i];
                                    }
                                    else
                                    {
                                        input[i] = abcE[j - param];
                                        output += input[i];
                                    }
                                    break;
                                }
                                else if (input[i] == ABCE[j])
                                {
                                    if (j - param < 0)
                                    {
                                        input[i] = ABCE[25 + j - param + 1];
                                        output += input[i];
                                    }
                                    else
                                    {
                                        input[i] = ABCE[j - param];
                                        output += input[i];
                                    }
                                    break;
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: \n" + ex.Message);
                    }
                    break;
            }
            TrisemDecode.Text = output;
        }
        private void PFCoding(object sender, RoutedEventArgs e)
        {
            try
            {
                int coordI_1 = 0, coordJ_1 = 0;
                int coordI_2 = 0, coordJ_2 = 0;

                string ruAlph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ,";
                string forCode = PFCode.Text;
                if (forCode == "") forCode = "Коллекционер";
                string codedString = "";
                string engAlph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string[,] matrix = new string[5, 7];
                string keyWord = PFKey.Text;
                if (keyWord == "") keyWord = "удар";
                keyWord = keyWord.ToUpper();
                string exeptedAlph = ruAlph;
                int l = 0;
                bool isKWUsed = false;
                //убираем символы из алфавита
                for (int i = 0; i < keyWord.Length; i++)
                {
                    for (int j = 0; j < ruAlph.Length; j++)
                    {
                        if (keyWord[i] == ruAlph[j]) exeptedAlph = exeptedAlph.Replace(ruAlph[j].ToString(), "");
                    }
                }

                //заполняем матрицу
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (!isKWUsed)
                        {
                            for (int k = 0; k < keyWord.Length; k++)
                            {
                                if (k >= 7) { k = 0; i++; }
                                matrix[i, k] = keyWord[l].ToString();
                                l++;
                                j = k;
                                if (l >= keyWord.Length) break;

                            }
                            isKWUsed = true;
                            l = 0;
                            j++;
                        }

                        if (j > 7) { j = 0; i++; }
                        if (l < exeptedAlph.Length)
                        {
                            matrix[i, j] = Convert.ToString(exeptedAlph[l]);
                            l++;
                        }

                    }

                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }

                //фразу на биграммы части
                forCode = forCode.ToUpper();
                string Newstring = "";

                for (int i = 0; i < forCode.Length; i++)
                {
                    Newstring += forCode[i];
                    if (i < forCode.Length - 1)
                        if (forCode[i] == forCode[i + 1]) Newstring += "Х";//добавление символа х после 1 символа
                }

                if (Newstring.Length % 2 != 0)
                {
                    Newstring += " ";
                }

                char[] charForCode = Newstring.ToCharArray();
                l = 0;
                for (int osn = 0; osn < charForCode.Length; osn += 2)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (charForCode[osn].ToString() == matrix[i, j])
                            {
                                coordI_1 = i;
                                coordJ_1 = j;
                            }
                        }
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (charForCode[osn + 1].ToString() == matrix[i, j])
                            {
                                coordI_2 = i;
                                coordJ_2 = j;
                            }
                        }
                    }

                    codedString += matrix[coordI_2, coordJ_1].ToString() + matrix[coordI_1, coordJ_2].ToString();

                }
                PFDecode.Text = codedString;
            }
            catch { MessageBox.Show("error"); }

        }
        private void PFDecoding(object sender, RoutedEventArgs e)
        {
            try
            {
                int coordI_1 = 0, coordJ_1 = 0;
                int coordI_2 = 0, coordJ_2 = 0;
                string ruAlph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ,";
                string forCode = PFCode.Text;
                if (forCode == "") forCode = " Коллекционер Джон Фаулз";
                string codedString = "";
                string engAlph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string[,] matrix = new string[5, 7];
                string keyWord = PFKey.Text;
                if (keyWord == "") keyWord = "Удар";
                keyWord = keyWord.ToUpper();
                string exeptedAlph = ruAlph;
                int l = 0;
                bool isKWUsed = false;
                //убираем символы из алфавита
                for (int i = 0; i < keyWord.Length; i++)
                {
                    for (int j = 0; j < ruAlph.Length; j++)
                    {
                        if (keyWord[i] == ruAlph[j]) exeptedAlph = exeptedAlph.Replace(ruAlph[j].ToString(), "");
                    }
                }

                //заполняем матрицу
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (!isKWUsed)
                        {
                            for (int k = 0; k < keyWord.Length; k++)
                            {
                                if (k >= 7) { k = 0; i++; }
                                matrix[i, k] = keyWord[l].ToString();
                                l++;
                                j = k;
                                if (l >= keyWord.Length) break;

                            }

                            isKWUsed = true;
                            l = 0;
                            j++;
                        }

                        if (j > 7) { j = 0; i++; }
                        if (l < exeptedAlph.Length)
                        {
                            matrix[i, j] = Convert.ToString(exeptedAlph[l]);
                            l++;
                        }

                    }

                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }

                //делим фразу на биограммы
                forCode = forCode.ToUpper();
                string Newstring = "";

                for (int i = 0; i < forCode.Length; i++)
                {
                    Newstring += forCode[i];
                    if (i < forCode.Length - 1)
                        if (forCode[i] == forCode[i + 1]) Newstring += "Х";
                }

                string decodedString = "";
                char[] charForDecode = PFCode.Text.ToCharArray();
                l = 0;
                coordI_1 = 0;
                coordJ_1 = 0;
                coordI_2 = 0;
                coordJ_2 = 0;
                for (int osn = 0; osn < charForDecode.Length; osn += 2)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (charForDecode[osn].ToString() == matrix[i, j])
                            {
                                coordI_1 = i;
                                coordJ_1 = j;

                            }
                        }
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (charForDecode[osn + 1].ToString() == matrix[i, j])
                            {
                                coordI_2 = i;
                                coordJ_2 = j;
                            }
                        }
                    }

                    decodedString += matrix[coordI_2, coordJ_1].ToString() + matrix[coordI_1, coordJ_2].ToString();

                }
                for (int i = 0; i < decodedString.Length - 2; i++)
                {
                    if (decodedString[i] == decodedString[i + 2] && decodedString[i + 1].ToString() == "Х".ToString()) { decodedString = decodedString.Remove(i + 1, 1); }
                }



                PFDecode.Text = decodedString;
            }
            catch { MessageBox.Show("error"); }

        }
        private void PFSwitch(object sender, RoutedEventArgs e)
        {
            PFCode.Text = PFDecode.Text;
        }

        private void LR4_1_Coding(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int A = Convert.ToInt32(A_LR4.Text);
            int B = Convert.ToInt32(B_LR4.Text);
            int C = Convert.ToInt32(C_LR4.Text);
            string output1 = "";
            string output2 = "";
            string output3 = "";
            string output4 = "";
            string output5 = "";
            string output6 = "";
            int[] k1 = new int[10];
            int[] k2 = new int[10];
            double[] k3 = new double[10];
            double[] k4 = new double[10];
            int[] k5 = new int[10];
            
            int n = rand.Next(1, 5);
            k1[0] = n * 3;
            n = rand.Next(1, 5);
            k2[0] = n * (-2);
            n = rand.Next(1, 5);
            k3[0] = n * 3 ;
            n = rand.Next(1, 5);
            k4[0] = -2.3;
            n = rand.Next(1, 5);
            k5[0] = -30;
            output1 += k1[0] + "; ";
            output2 += k2[0] + "; ";
            output3 += k3[0] + "; ";
            output4 += k4[0] + "; ";
            output5 += k5[0] + "; ";
            //output6 += k6[0] + "; ";
            for (int i = 1; i < 10; i++)
            {
                k1[i] = (A * k1[i - 1] + B) % C;
                k2[i] = (A * k2[i - 1] + B) % C;
                k3[i] = (A * k3[i - 1] + B) % C;
                k4[i] = (A * k4[i - 1] + B) % C;
                k5[i] = (A * k5[i - 1] + B) % C;
                switch (k2[i] % 6)
                {
                    case 0:
                        k1[i] = 3;
                        k2[i] = -3;
                        k3[i] = (double)rand.Next(30, 121) / 10.0;
                        k4[i] = (double)rand.Next(-23, 108) / 10.0;
                        k5[i] = -30;
                        break;
                    case 1:
                        k1[i] = 6;
                        k2[i] = 0;
                        k3[i] = (double)rand.Next(30, 121) / 10.0;
                        k4[i] = (double)rand.Next(-23, 108) / 10.0;
                        k5[i] = 10;
                        break;
                    case 2:
                        k1[i] = 9;
                        k2[i] = 6;
                        k3[i] = (double)rand.Next(30, 121) / 10.0;
                        k4[i] = (double)rand.Next(-23, 108) / 10.0;
                        k5[i] = 63;
                        break;
                    case 3:
                        k1[i] = 12;
                        k2[i] = 9;
                        k3[i] = (double)rand.Next(30, 121) / 10.0;
                        k4[i] = (double)rand.Next(-23, 108) / 10.0;
                        k5[i] = 59;
                        break;
                    case 4:
                        k1[i] = 3;
                        k2[i] = 12;
                        k3[i] = (double)rand.Next(30, 121) / 10.0;
                        k4[i] = (double)rand.Next(-23, 108) / 10.0;
                        k5[i] = 120;
                        break;
                    case 5:
                        k1[i] = 6;
                        k2[i] = 15;
                        k3[i] = (double)rand.Next(30,121)/10.0;
                        k4[i] = (double)rand.Next(-23, 108) / 10.0;
                        k5[i] = 175;
                        break;
                }
                output1 += k1[i] + "; ";
                output2 += k2[i] + "; ";
                output3 += k3[i] + "; ";
                output4 += k4[i] + "; ";
                output5 += k5[i] + "; ";
            }
            LR41_Output.Text = output1;
            LR42_Output.Text = output2;
            LR43_Output.Text = output3;
            LR44_Output.Text = output4;
            LR45_Output.Text = output5;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            string x = "";
            var y = new HashSet<string>();
            while (y.Count <= 3)
            {
                y.Add(rand.Next(0, 10).ToString());
            }
            
            Check.Text = y;
        }
    }
}
