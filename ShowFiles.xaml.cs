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
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;

namespace FileFinder
{
    /// <summary>
    /// Interaktionslogik für ShowFiles.xaml
    /// </summary>
    public partial class ShowFiles : Window
    {
        private List<FileInfo> fileInfos;
        public ShowFiles(List<FileInfo> fileInfos)
        {
            this.fileInfos = fileInfos;
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgFiles.DataContext = fileInfos;
        }

        private void DataGridRow_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            string path = ((FileInfo)dgFiles.SelectedItem).DirectoryName;
            MessageBox.Show(path);
            Process.Start("explorer.exe", path);
        }
    }
}
