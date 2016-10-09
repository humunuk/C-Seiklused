using System;
using System.Windows;
using InimesteKuvamine.Models;
using InimesteKuvamine.ViewModels;

namespace InimesteKuvamine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private MainWindowVM _vm;

        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainWindowVM();
            _vm.LoadData();
            //nn käed õliseks meetod: lboxInimesed.ItemsSource = _vm.Inimesed;
            this.DataContext = _vm;
        }

        private void btnLisaInimene_Click(object sender, RoutedEventArgs e)
        {
            string eesnimi = txtEesnimi.Text;
            string perenimi = txtPerenimi.Text;
#warning Validation lisada
            int pikkus = Int16.Parse(txtPikkus.Text);

            Inimene inimene = new Inimene(eesnimi, perenimi, pikkus);
            _vm.LisaInimene(inimene);
        }

        private void lboxInimesed_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //Inimene leitudInimene = lboxInimesed.SelectedItem as Inimene;
            //if (leitudInimene != null)
            //{
            //    txtPerenimi.Text = leitudInimene.Perenimi;
            //}
            //Inimene leiduInimene1 = (Inimene) lboxInimesed.SelectedItem; -> selle puhul ei saa kontrollida, kas castimine toimus
        }
    }
}
