using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace _3Text
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
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox1 != null)
            {
                textBox1.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox(object sender, SizeChangedEventArgs e)
        {
            if (textBox1 != null)
            {
               double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
                textBox1.FontSize = fontSize;
                    }
        }
              
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.FontWeight == FontWeights.Normal)
            {
                textBox1.FontWeight = FontWeights.Bold;
            }
            else
            {
                textBox1.FontWeight = FontWeights.Normal;
            }
        }
                private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox1.FontStyle == FontStyles.Normal)
            {
                textBox1.FontStyle = FontStyles.Italic;
            }
            else
            {
                textBox1.FontStyle = FontStyles.Normal;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //if (textBox.TextDecorations.Count == 0)
            //{
            //    textBox.TextDecorations.Add(TextDecorations.Underline);
            //        }
            //else
            //{
            //    textBox.TextDecorations.Remove(TextDecorations.Underline[0]);
            //}
            if (textBox1.TextDecorations==null)
            {
                textBox1.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                textBox1.TextDecorations = null;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox1 != null)
            {
                textBox1.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox1 != null)
            {
                textBox1.Foreground = Brushes.Red;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog()==true)
            {
                textBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter= "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog()==true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
