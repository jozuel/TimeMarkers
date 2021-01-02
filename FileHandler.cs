using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TimeMarkers
{
    class FileHandler
    {
        private string filePath;
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        private string fullFilePath;
        public string FullFilePath
        {
            get { return fullFilePath; }
            set { fullFilePath = value; }
        }

        private string fileName;
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private int fileNumber;
        public int FileNumber
        {
            get { return fileNumber; }
            set { fileNumber = value; }
        }
        private Keys detectKey;
        public Keys DetectKey
        {
            get { return detectKey; }
            set { detectKey = value; }
        }
        private MouseButtons detectMouseButton;
        public MouseButtons DetectMouseButton
        {
            get { return detectMouseButton; }
            set { detectMouseButton = value; }
        }
        //read tmConfig.txt and set variables
        public void readConfig()
        {
            List<String> config, tmp = new List<String>();
            string defaultConfig;
            int count = 0;
            if (File.Exists("tmConfig.txt"))
            {
                config = File.ReadLines("tmConfig.txt").ToList();
                foreach (string c in config)
                {
                    //get second part of config
                    tmp.Add(c.Split('=')[1]);
                    count++;
                }
                //first validate

                filePath = tmp[0];
                fileName = tmp[1];
                fileNumber = Int32.Parse(tmp[2]);

                //cast string to enum keys
                detectKey = (Keys)Enum.Parse(typeof(Keys), tmp[3], true);
                detectMouseButton = (MouseButtons)Enum.Parse(typeof(MouseButtons), tmp[4], true);
                /*MessageBox.Show("file path: " + filePath + Environment.NewLine +
                           "file name: " + fileName + Environment.NewLine +
                           "file number:" + fileNumber + Environment.NewLine +
                           "detect key:" + detectKey.ToString(), "test", MessageBoxButtons.OK);
                */
            }
            else   //create default file
            {
                filePath = Directory.GetCurrentDirectory();
                fileName = "test";
                fileNumber = 1;
                detectKey = Keys.F9;
                detectMouseButton = MouseButtons.None;

                defaultConfig = "file path=" + filePath + Environment.NewLine +
                           "file name=" + fileName + Environment.NewLine +
                           "file number=" + fileNumber + Environment.NewLine +
                           "detect key=" + detectKey.ToString() + Environment.NewLine +
                           "detect mouse button=" + detectMouseButton.ToString();

                File.AppendAllText(Directory.GetCurrentDirectory() + "\\tmConfig.txt", defaultConfig);
            }
            fullFilePath = filePath + "" + fileName + fileNumber + ".txt";
        }

        public void writeConfig(string path, string fileName, int fileNumber, Keys detectKey, MouseButtons detectMouseButton)
        {
            File.WriteAllText("tmConfig.txt", "file path=" + path + Environment.NewLine);
            File.AppendAllText("tmConfig.txt", "file name=" + fileName + Environment.NewLine);
            File.AppendAllText("tmConfig.txt", "file number=" + fileNumber + Environment.NewLine);
            File.AppendAllText("tmConfig.txt", "detect key=" + detectKey.ToString() + Environment.NewLine);
            File.AppendAllText("tmConfig.txt", "detect mouse button=" + detectMouseButton.ToString());
        }
        public FileHandler(String filePath)
        {
            this.filePath = filePath;
            //fs = new FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.Read);
        }
        public FileHandler()
        {
        }
        //append text to file at fullPath with file name in it
        public void writeToFile(String fullPath, String text)
        {
            File.AppendAllText(fullPath, text);
        }
        //append text to file from FileHandler parameters
        public void writeToFile(string text)
        {
            fullFilePath = filePath + "\\" + fileName + fileNumber + ".txt";
            File.AppendAllText(fullFilePath, text);
        }
    }
}
