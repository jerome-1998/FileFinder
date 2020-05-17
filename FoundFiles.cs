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
        public FoundFiles(string filename)
        {
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
            Stack<string> dirs = new Stack<string>();
            
            try
            {
                //get all drives
                string[] drives = Directory.GetLogicalDrives();
                foreach(string s in drives)
                {
                    //MessageBox.Show(s);
                    dirs.Push(s);
                }
                //run by every subdictionary
                while(dirs.Count>0)
                {
                    string currentDir = dirs.Pop();
                    string[] subDirs;
                    try
                    {
                        subDirs = Directory.GetDirectories(currentDir);
                        string[] fArray = null;
                        fArray = Directory.GetFiles(currentDir);
                        foreach(string s in fArray)
                        {
                            //if File contains searched Filename push it to List
                            if(new FileInfo(s).Name.ToLower().Contains(filename.ToLower()))
                            {
                                fileInfoList.Add(new FileInfo(s));
                                //MessageBox.Show("ja");
                            }
                        }
                    }
                    catch
                    {
                        //unauthorized Access or something else
                        continue;
                    }
                    foreach(string sub in subDirs)
                    {
                        dirs.Push(sub);
                    }
                }

            }
            catch(Exception e)
            {
                //Do nothing
            }
        }

    }
}
