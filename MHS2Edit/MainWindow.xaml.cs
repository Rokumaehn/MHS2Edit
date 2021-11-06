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

namespace MHS2Edit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        byte[] rawData;
        Character _character;
        Monsters _monsters;
        ItemBox _itemBox;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                rawData = File.ReadAllBytes(openFileDialog.FileName);

                _character = new Character(rawData);
                _monsters = new Monsters(rawData);
                _itemBox = new ItemBox(rawData);

                DataGridMonsters.ItemsSource = _monsters.MonsterList;
                DataGridParty.ItemsSource = _monsters.PartyList;
                DataGridItems.ItemsSource = _itemBox.ItemList;
                DataGridItemsHealing.ItemsSource = _itemBox.ItemListHealing;
                DataGridItemsSupport.ItemsSource = _itemBox.ItemListSupport;
                DataGridItemsMaterials.ItemsSource = _itemBox.ItemListMaterials;
                DataGridItemsFacilities.ItemsSource = _itemBox.ItemListFacilities;
                DataGridItemsGrowth.ItemsSource = _itemBox.ItemListGrowth;
                DataGridItemsKey.ItemsSource = _itemBox.ItemListKey;
                textBoxCharacterName.Text = _character.Name;
                textBoxCharacterExp.Text = _character.Exp.ToString();
                textBoxCharacterZenny.Text = _character.Zenny.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                File.WriteAllBytes(openFileDialog.FileName, rawData);
        }

        private void TextBoxCharacterName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_character != null)
            {
                _character.Name = textBoxCharacterName.Text;
            }
        }

        private void TextBoxCharacterExp_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_character != null)
            {
                try
                {
                    _character.Exp = UInt32.Parse(textBoxCharacterExp.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Value.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void TextBoxCharacterZenny_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_character != null)
            {
                try
                {
                    _character.Zenny = UInt32.Parse(textBoxCharacterZenny.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Value.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            foreach (var item in _itemBox.ItemListMaterials)
            {
                if(item.Name=="__UNKNOWN__")
                {
                    item.Amount = item.Id;
                }
            }
        }

        private void DataGridParty_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            WindowGenes wnd = new WindowGenes();
            wnd._monster = DataGridParty.SelectedItem as Monster;
            wnd.Title = "Genes - " + wnd._monster.Name;
            wnd.ShowDialog();
        }

        private void DataGridMonsters_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            WindowGenes wnd = new WindowGenes();
            wnd._monster = DataGridMonsters.SelectedItem as Monster;
            wnd.Title = "Genes - " + wnd._monster.Name;
            wnd.ShowDialog();
        }
    }
}
