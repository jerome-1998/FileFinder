using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace FileFinder
{
    class FoundFiles
    {
        //Set instance variable
        private List<FileInfo> fileInfoList;
        private string filename;
        private string selectedPath;
        public FoundFiles(string filename, string selectedPath)
        {
            this.selectedPath = selectedPath;
            this.filename = filename;
            fileInfoList = new List<FileInfo>();
        }

        //Property
        public List<FileInfo> fileInfos
        {
            get
            {
                return fileInfoList;
            }
        }

        //Search all Files which contains the filename
        public void LookingForFiles()
        {
            //generate list for all directorys
            Stack<string> dirs = new Stack<string>();
            if (selectedPath == "")
            {

                //get all drives
                string[] drives = Directory.GetLogicalDrives();
                foreach (string s in drives)
                {
                    //MessageBox.Show(s);
                    dirs.Push(s);
                }
                //Push all found files to fileinfo List
                PushFilesToList(dirs);
            }
            else
            {
                foreach (string s in Directory.GetDirectories(selectedPath))
                {
                    dirs.Push(s);
                }
                PushFilesToList(dirs);   
            }
            
        }

        private void PushFilesToList(Stack<string> dirs)
        {
            try
            {

                //run by every subdictionary
                while (dirs.Count > 0)
                {
                    //take current directory from list
                    string currentDir = dirs.Pop();
                    //generate subdirectory array
                    string[] subDirs;
                    try
                    {
                        //Get all Directs in current direct
                        subDirs = Directory.GetDirectories(currentDir);
                        //generate array for files
                        string[] fArray = null;
                        //push all files in current direct in filearray
                        fArray = Directory.GetFiles(currentDir);
                        foreach (string s in fArray)
                        {
                            //if File contains searched Filename push it to List
                            if (new FileInfo(s).Name.ToLower().Contains(filename.ToLower()))
                            {
                                //push file to list
                                fileInfoList.Add(new FileInfo(s));
                            }
                        }
                    }
                    catch
                    {
                        //unauthorized Access or something else
                        continue;
                    }
                    foreach (string sub in subDirs)
                    {
                        //enlarge directory list with subdirs
                        dirs.Push(sub);
                    }
                }

            }
            catch (Exception e)
            {
                //Do nothing
            }
        }

    }
}
