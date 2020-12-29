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
using System.Runtime.CompilerServices;

namespace FileFinder
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged//
    {
        //use for foundfiles class
        private string selectedPath;
        //use for gui
        private string _showpath;
        //use class to find files
        private FoundFiles foundFiles;
        //sentence for user
        private const string noPath= "kein Pfad ausgewählt";
        //boolean variable to enable / unable results button
        private bool _showresult;
        //update binding
        public event PropertyChangedEventHandler PropertyChanged;
        //boolean property for binding result button
        public bool ShowResult
        {
            get
            {
                return _showresult;
            }
            set
            {
                _showresult = value;
                OnPropertyChanged();
            }
        }

        public string ShowPath
        {
            get
            {
                return _showpath;
            }
            set
            {
                _showpath = value;
                OnPropertyChanged();
            }
        }

        //if Value changed, update stuff (Boilerplate code)
        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            //set DataContext for Bindings
            DataContext = this;
            //basically these two are "" and "kein Pfad ausgewählt"
            selectedPath = "";
            ShowPath = noPath;
            //set Show Button disabled by start
            ShowResult = foundFiles !=null;
        }

        private void BtnFindFile_Click(object sender, RoutedEventArgs e)
        {
            //Update Label
            lblResult.Content = $"Suche nach Dateien...";
            MessageBox.Show("Die Suche kann einige Minuten dauern");
            //Get Files
            foundFiles= new FoundFiles(tbxFileName.Text, selectedPath);
            foundFiles.LookingForFiles();
            List<FileInfo> files = foundFiles.fileInfos;
            int amount = files.Count;
            //Update Label
            SetLblAmount(lblResult, amount);
            //Clean Garbage
            GC.Collect();
            selectedPath = "";
            ShowPath = noPath;
            ShowResult = foundFiles.fileInfos.Any();
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

        private void BtnPath_Click(object sender, RoutedEventArgs e)
        {
            //select the path
            using(var fbd = new System.Windows.Forms.FolderBrowserDialog())
            {
                //select folder
                System.Windows.Forms.DialogResult rs = fbd.ShowDialog();
                if(rs.ToString()=="OK")
                {
                    //take folderpath for visualizing
                    ShowPath = fbd.SelectedPath;
                }
                else
                {
                    //tell user there is no path selected
                    ShowPath = noPath;
                }
                //use seperate variable because showpath is not usefull when there is no path selected
                selectedPath = fbd.SelectedPath;

            }
            
        }

        private void BtnClearPath_Click(object sender, RoutedEventArgs e)
        {
            //clear showed path-label
            selectedPath = "";
            ShowPath = noPath;
        }
    }
}
