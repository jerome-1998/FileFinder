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
using System.Threading;
using System.ComponentModel;
using System.IO;

namespace FileFinder
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FoundFiles foundFiles;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnFindFile_Click(object sender, RoutedEventArgs e)
        {
            //Update Label
            lblResult.Content = $"Suche nach Dateien...";
            MessageBox.Show("Die Suche kann einige Minuten dauern");
            //Get Files
            foundFiles= new FoundFiles(tbxFileName.Text);
            foundFiles.LookingForFiles();
            List<FileInfo> files = foundFiles.fileInfos;
            int amount = files.Count;
            //Update Label
            SetLblAmount(lblResult, amount);
            //Clean Garbage
            GC.Collect();

        }

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            //Open new Window
            ShowFiles showFiles = new ShowFiles(foundFiles.fileInfos);
            SetLblAmount(showFiles.lblAmount, foundFiles.fileInfos.Count);
            showFiles.ShowDialog();

        }

        private void SetLblAmount(Label lbl, int amount)
        {
            //Show how much files got found
            lbl.Content = $"{amount} Dateien gefunden: ";
        }

    }
}
