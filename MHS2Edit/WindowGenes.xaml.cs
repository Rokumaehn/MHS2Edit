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
            comboBoxGene1.SelectedItem = _monster.Genes[0];
            comboBoxGene1.ItemsSource = Gene.ALL.Values.ToList();

            comboBoxGene2.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene2.SelectedItem = _monster.Genes[1];

            comboBoxGene3.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene3.SelectedItem = _monster.Genes[2];

            comboBoxGene4.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene4.SelectedItem = _monster.Genes[3];

            comboBoxGene5.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene5.SelectedItem = _monster.Genes[4];

            comboBoxGene6.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene6.SelectedItem = _monster.Genes[5];

            comboBoxGene7.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene7.SelectedItem = _monster.Genes[6];
            comboBoxGene7.Text = _monster.Genes[6].ToString();

            comboBoxGene8.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene8.SelectedItem = _monster.Genes[7];

            comboBoxGene9.ItemsSource = Gene.ALL.Values.ToList();
            comboBoxGene9.SelectedItem = _monster.Genes[8];

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

        private void ComboBoxGene1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Image1.Source = BitmapToImageSource( (comboBoxGene1.SelectedValue as Gene).Image );
        }

        private void ComboBoxGene2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Image2.Source = BitmapToImageSource((comboBoxGene2.SelectedValue as Gene).Image);
        }

        private void ComboBoxGene3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Image3.Source = BitmapToImageSource((comboBoxGene3.SelectedValue as Gene).Image);
        }

        private void ComboBoxGene4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Image4.Source = BitmapToImageSource((comboBoxGene4.SelectedValue as Gene).Image);
        }

        private void ComboBoxGene5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Image5.Source = BitmapToImageSource((comboBoxGene5.SelectedValue as Gene).Image);
        }

        private void ComboBoxGene6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Image6.Source = BitmapToImageSource((comboBoxGene6.SelectedValue as Gene).Image);
        }

        private void ComboBoxGene7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Image7.Source = BitmapToImageSource((comboBoxGene7.SelectedValue as Gene).Image);
        }

        private void ComboBoxGene8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Image8.Source = BitmapToImageSource((comboBoxGene8.SelectedValue as Gene).Image);
        }

        private void ComboBoxGene9_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Image9.Source = BitmapToImageSource((comboBoxGene9.SelectedValue as Gene).Image);
        }

        private void CheckBoxGene1_Checked(object sender, RoutedEventArgs e)
        {
            comboBoxGene1.SelectedItem = Gene.GetById(2);
        }
        private void CheckBoxGene1_Unchecked(object sender, RoutedEventArgs e)
        {
            comboBoxGene1.SelectedItem = Gene.GetById(1);
        }
    }
}
