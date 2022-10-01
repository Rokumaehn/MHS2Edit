using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Shapes;

namespace MHS2Edit
{
    /// <summary>
    /// Interaction logic for WindowGenes.xaml
    /// </summary>
    public partial class WindowGenes : Window
    {
        public Monster _monster;

        public WindowGenes()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxGene1.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene1.SelectedItem = Gene.GetTemplate(_monster.Genes[0].Id);
            label1.Content = _monster.Genes[0].ToString();
            labelLevel1.Content = _monster.Genes[0].Level;

            comboBoxGene2.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene2.SelectedItem = Gene.GetTemplate(_monster.Genes[1].Id);
            label2.Content = _monster.Genes[1].ToString();
            labelLevel2.Content = _monster.Genes[1].Level;

            comboBoxGene3.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene3.SelectedItem = Gene.GetTemplate(_monster.Genes[2].Id);
            label3.Content = _monster.Genes[2].ToString();
            labelLevel3.Content = _monster.Genes[2].Level;

            comboBoxGene4.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene4.SelectedItem = Gene.GetTemplate(_monster.Genes[3].Id);
            label4.Content = _monster.Genes[3].ToString();
            labelLevel4.Content = _monster.Genes[3].Level;

            comboBoxGene5.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene5.SelectedItem = Gene.GetTemplate(_monster.Genes[4].Id);
            label5.Content = _monster.Genes[4].ToString();
            labelLevel5.Content = _monster.Genes[4].Level;

            comboBoxGene6.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene6.SelectedItem = Gene.GetTemplate(_monster.Genes[5].Id);
            label6.Content = _monster.Genes[5].ToString();
            labelLevel6.Content = _monster.Genes[5].Level;

            comboBoxGene7.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene7.SelectedItem = Gene.GetTemplate(_monster.Genes[6].Id);
            label7.Content = _monster.Genes[6].ToString();
            labelLevel7.Content = _monster.Genes[6].Level;

            comboBoxGene8.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene8.SelectedItem = Gene.GetTemplate(_monster.Genes[7].Id);
            label8.Content = _monster.Genes[7].ToString();
            labelLevel8.Content = _monster.Genes[7].Level;

            comboBoxGene9.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene9.SelectedItem = Gene.GetTemplate(_monster.Genes[8].Id);
            label9.Content = _monster.Genes[8].ToString();
            labelLevel9.Content = _monster.Genes[8].Level;

            checkBoxGene1.IsChecked = _monster.Genes[0].IsLocked;
            checkBoxGene2.IsChecked = _monster.Genes[1].IsLocked;
            checkBoxGene3.IsChecked = _monster.Genes[2].IsLocked;
            checkBoxGene4.IsChecked = _monster.Genes[3].IsLocked;
            checkBoxGene5.IsChecked = _monster.Genes[4].IsLocked;
            checkBoxGene6.IsChecked = _monster.Genes[5].IsLocked;
            checkBoxGene7.IsChecked = _monster.Genes[6].IsLocked;
            checkBoxGene8.IsChecked = _monster.Genes[7].IsLocked;
            checkBoxGene9.IsChecked = _monster.Genes[8].IsLocked;
        }

        BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }

        bool box1Init = false;
        private void ComboBoxGene1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (box1Init)
            {
                var g = _monster.Genes;
                g[0] = Gene.CreateFromValue((comboBoxGene1.SelectedValue as Gene).Id);
                g[0].IsLocked = checkBoxGene1.IsChecked.GetValueOrDefault(false);
                g[0].Level = Convert.ToUInt32(labelLevel1.Content);
                _monster.Genes = g;
            }
            Image1.Source = BitmapToImageSource( (comboBoxGene1.SelectedValue as Gene).Image );
            box1Init = true;
        }

        bool box2Init = false;
        private void ComboBoxGene2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (box2Init)
            {
                var g = _monster.Genes;
                g[1] = Gene.CreateFromValue((comboBoxGene2.SelectedValue as Gene).Id);
                g[1].IsLocked = checkBoxGene2.IsChecked.GetValueOrDefault(false);
                g[1].Level = Convert.ToUInt32(labelLevel2.Content);
                _monster.Genes = g;
            }
            Image2.Source = BitmapToImageSource((comboBoxGene2.SelectedValue as Gene).Image);
            box2Init = true;
        }

        bool box3Init = false;
        private void ComboBoxGene3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (box3Init)
            {
                var g = _monster.Genes;
                g[2] = Gene.CreateFromValue((comboBoxGene3.SelectedValue as Gene).Id);
                g[2].IsLocked = checkBoxGene3.IsChecked.GetValueOrDefault(false);
                g[2].Level = Convert.ToUInt32(labelLevel3.Content);
                _monster.Genes = g;
            }
            Image3.Source = BitmapToImageSource((comboBoxGene3.SelectedValue as Gene).Image);
            box3Init = true;
        }

        bool box4Init = false;
        private void ComboBoxGene4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (box4Init)
            {
                var g = _monster.Genes;
                g[3] = Gene.CreateFromValue((comboBoxGene4.SelectedValue as Gene).Id);
                g[3].IsLocked = checkBoxGene4.IsChecked.GetValueOrDefault(false);
                g[3].Level = Convert.ToUInt32(labelLevel4.Content);
                _monster.Genes = g;
            }
            Image4.Source = BitmapToImageSource((comboBoxGene4.SelectedValue as Gene).Image);
            box4Init = true;
        }

        bool box5Init = false;
        private void ComboBoxGene5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (box5Init)
            {
                var g = _monster.Genes;
                g[4] = Gene.CreateFromValue((comboBoxGene5.SelectedValue as Gene).Id);
                g[4].IsLocked = checkBoxGene5.IsChecked.GetValueOrDefault(false);
                g[4].Level = Convert.ToUInt32(labelLevel5.Content);
                _monster.Genes = g;
            }
            Image5.Source = BitmapToImageSource((comboBoxGene5.SelectedValue as Gene).Image);
            box5Init = true;
        }

        bool box6Init = false;
        private void ComboBoxGene6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (box6Init)
            {
                var g = _monster.Genes;
                g[5] = Gene.CreateFromValue((comboBoxGene6.SelectedValue as Gene).Id);
                g[5].IsLocked = checkBoxGene6.IsChecked.GetValueOrDefault(false);
                g[5].Level = Convert.ToUInt32(labelLevel6.Content);
                _monster.Genes = g;
            }
            Image6.Source = BitmapToImageSource((comboBoxGene6.SelectedValue as Gene).Image);
            box6Init = true;
        }

        bool box7Init = false;
        private void ComboBoxGene7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (box7Init)
            {
                var g = _monster.Genes;
                g[6] = Gene.CreateFromValue((comboBoxGene7.SelectedValue as Gene).Id);
                g[6].IsLocked = checkBoxGene7.IsChecked.GetValueOrDefault(false);
                g[6].Level = Convert.ToUInt32(labelLevel7.Content);
                _monster.Genes = g;
            }
            Image7.Source = BitmapToImageSource((comboBoxGene7.SelectedValue as Gene).Image);
            box7Init = true;
        }

        bool box8Init = false;
        private void ComboBoxGene8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (box8Init)
            {
                var g = _monster.Genes;
                g[7] = Gene.CreateFromValue((comboBoxGene8.SelectedValue as Gene).Id);
                g[7].IsLocked = checkBoxGene8.IsChecked.GetValueOrDefault(false);
                g[7].Level = Convert.ToUInt32(labelLevel8.Content);
                _monster.Genes = g;
            }
            Image8.Source = BitmapToImageSource((comboBoxGene8.SelectedValue as Gene).Image);
            box8Init = true;
        }

        bool box9Init = false;
        private void ComboBoxGene9_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (box9Init)
            {
                var g = _monster.Genes;
                g[8] = Gene.CreateFromValue((comboBoxGene9.SelectedValue as Gene).Id);
                g[8].IsLocked = checkBoxGene9.IsChecked.GetValueOrDefault(false);
                g[8].Level = Convert.ToUInt32(labelLevel9.Content);
                _monster.Genes = g;
            }
            Image9.Source = BitmapToImageSource((comboBoxGene9.SelectedValue as Gene).Image);
            box9Init = true;
        }

        private void ButtonLevel1Plus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[0].Level++;
            _monster.Genes = g;
            labelLevel1.Content = _monster.Genes[0].Level;
        }

        private void ButtonLevel1Minus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[0].Level--;
            _monster.Genes = g;
            labelLevel1.Content = _monster.Genes[0].Level;
        }

        private void ButtonLevel2Plus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[1].Level++;
            _monster.Genes = g;
            labelLevel2.Content = _monster.Genes[1].Level;
        }

        private void ButtonLevel2Minus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[1].Level--;
            _monster.Genes = g;
            labelLevel2.Content = _monster.Genes[1].Level;
        }

        private void ButtonLevel3Plus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[2].Level++;
            _monster.Genes = g;
            labelLevel3.Content = _monster.Genes[2].Level;
        }

        private void ButtonLevel3Minus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[2].Level--;
            _monster.Genes = g;
            labelLevel3.Content = _monster.Genes[2].Level;
        }

        private void ButtonLevel4Plus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[3].Level++;
            _monster.Genes = g;
            labelLevel4.Content = _monster.Genes[3].Level;
        }

        private void ButtonLevel4Minus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[3].Level--;
            _monster.Genes = g;
            labelLevel4.Content = _monster.Genes[3].Level;
        }

        private void ButtonLevel5Plus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[4].Level++;
            _monster.Genes = g;
            labelLevel5.Content = _monster.Genes[4].Level;
        }
        
        private void ButtonLevel5Minus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[4].Level--;
            _monster.Genes = g;
            labelLevel5.Content = _monster.Genes[4].Level;
        }

        private void ButtonLevel6Plus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[5].Level++;
            _monster.Genes = g;
            labelLevel6.Content = _monster.Genes[5].Level;
        }

        private void ButtonLevel6Minus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[5].Level--;
            _monster.Genes = g;
            labelLevel6.Content = _monster.Genes[5].Level;
        }

        private void ButtonLevel7Plus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[6].Level++;
            _monster.Genes = g;
            labelLevel7.Content = _monster.Genes[6].Level;
        }

        private void ButtonLevel7Minus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[6].Level--;
            _monster.Genes = g;
            labelLevel7.Content = _monster.Genes[6].Level;
        }

        private void ButtonLevel8Plus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[7].Level++;
            _monster.Genes = g;
            labelLevel8.Content = _monster.Genes[7].Level;
        }

        private void ButtonLevel8Minus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[7].Level--;
            _monster.Genes = g;
            labelLevel8.Content = _monster.Genes[7].Level;
        }

        private void ButtonLevel9Plus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[8].Level++;
            _monster.Genes = g;
            labelLevel9.Content = _monster.Genes[8].Level;
        }

        private void ButtonLevel9Minus_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[8].Level--;
            _monster.Genes = g;
            labelLevel9.Content = _monster.Genes[8].Level;
        }

        private void checkBoxGene1_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[0].IsLocked = (sender as CheckBox).IsChecked.GetValueOrDefault(false);
            _monster.Genes = g;
        }

        private void checkBoxGene2_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[1].IsLocked = (sender as CheckBox).IsChecked.GetValueOrDefault(false);
            _monster.Genes = g;
        }

        private void checkBoxGene3_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[2].IsLocked = (sender as CheckBox).IsChecked.GetValueOrDefault(false);
            _monster.Genes = g;
        }

        private void checkBoxGene4_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[3].IsLocked = (sender as CheckBox).IsChecked.GetValueOrDefault(false);
            _monster.Genes = g;
        }

        private void checkBoxGene5_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[4].IsLocked = (sender as CheckBox).IsChecked.GetValueOrDefault(false);
            _monster.Genes = g;
        }

        private void checkBoxGene6_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[5].IsLocked = (sender as CheckBox).IsChecked.GetValueOrDefault(false);
            _monster.Genes = g;
        }

        private void checkBoxGene7_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[6].IsLocked = (sender as CheckBox).IsChecked.GetValueOrDefault(false);
            _monster.Genes = g;
        }

        private void checkBoxGene8_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[7].IsLocked = (sender as CheckBox).IsChecked.GetValueOrDefault(false);
            _monster.Genes = g;
        }

        private void checkBoxGene9_Click(object sender, RoutedEventArgs e)
        {
            var g = _monster.Genes;
            g[8].IsLocked = (sender as CheckBox).IsChecked.GetValueOrDefault(false);
            _monster.Genes = g;
        }
    }
}
