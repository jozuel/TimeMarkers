using System;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace TimeMarkers
{
    public partial class timeMarkers : Form
    {
        public timeMarkers()
        {
            InitializeComponent();
            //
            // stopwatch
            //
            this.stopwatch = new System.Diagnostics.Stopwatch();
            //
            //globalhook
            //
            gloobalHook = Hook.GlobalEvents();
            detectKey = Keys.F9;
            detectMouseButton = MouseButtons.None;
            //
            //FileHandler
            //
            fileHandler = new FileHandler();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileHandler.readConfig();
            initFromConfig();
        }

        // on exit write content to config
        private void Form1_Closing(object sender, FormClosedEventArgs e)
        {
            fileHandler.writeConfig(path, fileName.Text, (int)fileNumber.Value, detectKey, detectMouseButton);
            RemoveKeybordMouseHooks();
        }
        //set form from config
        private void initFromConfig()
        {
            fileName.Text = fileHandler.FileName;
            fileNumber.Value = fileHandler.FileNumber;
            path = fileHandler.FilePath;
            localisation.Text = path;
            fullpath = fileHandler.FullFilePath;
            detectKey = fileHandler.DetectKey;
            detectMouseButton = fileHandler.DetectMouseButton;
            if (detectKey != Keys.None)
                currKeyLbl.Text = detectKey.ToString();
            else
                currKeyLbl.Text = detectMouseButton.ToString();
        }
        private void browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath.ToString();
                this.localisation.Text = fbd.SelectedPath.ToString();
            }
        }

        private void start_Click(object sender, EventArgs e)
        {   //if browse label or name label is empty then msgbox
            if (String.IsNullOrEmpty(fileName.ToString())
            || String.IsNullOrEmpty(fileNumber.ToString())
            || String.IsNullOrEmpty(path))
            {
                MessageBox.Show("Unalble to create a file. Check path or file name",
                "Unable to create a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!stopwatch.IsRunning)
                {
                    fullpath = path + this.fileName.Text + fileNumber.Value + ".txt";
                    fileHandler.FullFilePath = fullpath;
                    fileHandler.FilePath = path;
                    fileHandler.FileName = fileName.Text;
                    fileHandler.FileNumber = (int)fileNumber.Value;

                    stopwatch.Start();
                    AddKeybordMouseHooks();
                }
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            RemoveKeybordMouseHooks();
            //save time in label

            this.timePassLbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

        }

        private void reset_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            stopwatch.Reset();
            RemoveKeybordMouseHooks();
            this.timePassLbl.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            0, 00, 00, 00);
        }

        private void AddKeybordMouseHooks()
        {
            gloobalHook.MouseDownExt += GlobalHookMouseDownExt;
            gloobalHook.KeyDown += GlobalHookKeyDown;
        }
        private void RemoveKeybordMouseHooks()
        {
            gloobalHook.MouseDownExt -= GlobalHookMouseDownExt;
            gloobalHook.KeyDown -= GlobalHookKeyDown;
        }
        //when keyboard key is pressed
        private void GlobalHookKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == detectKey)
            {
                TimeSpan ts = stopwatch.Elapsed;
                string timestamp = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                //save time to file
                fileHandler.writeToFile(timestamp + "\n");

                this.timePassLbl.Text = timestamp;

            }
        }
        //when mouse key is pressed
        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right && e.Button != MouseButtons.None)
            {
                TimeSpan ts = stopwatch.Elapsed;
                string timestamp = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
                //save time to file
                fileHandler.writeToFile(timestamp + "\n");

                this.timePassLbl.Text = timestamp;
            }
        }

        private void setKeyBtn_Click(object sender, EventArgs e)
        {
            gloobalHook.MouseDownExt += OnceGlobalHookMouseDownExt;
            gloobalHook.KeyDown += OnceGlobalHookKeyDown;
        }
        //used only in setting key to detect
        private void OnceGlobalHookKeyDown(object sender, KeyEventArgs e)
        {
            detectKey = e.KeyCode;
            this.currKeyLbl.Text = e.KeyCode.ToString();
            //reset mouse detection
            detectMouseButton = MouseButtons.None;
            gloobalHook.MouseDownExt -= OnceGlobalHookMouseDownExt;
            gloobalHook.KeyDown -= OnceGlobalHookKeyDown;
        }
        //used only in setting mouse button to detect
        private void OnceGlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
            {
                //reset keyboard detection
                detectKey = Keys.None;
                detectMouseButton = e.Button;
                this.currKeyLbl.Text = e.Button.ToString();
                gloobalHook.MouseDownExt -= OnceGlobalHookMouseDownExt;
                gloobalHook.KeyDown -= OnceGlobalHookKeyDown;
            }
        }
    }
}
