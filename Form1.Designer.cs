namespace TimeMarkers
{
    partial class timeMarkers
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.localLbl = new System.Windows.Forms.Label();
            this.localisation = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.fileNumber = new System.Windows.Forms.NumericUpDown();
            this.timeLbl = new System.Windows.Forms.Label();
            this.timePassLbl = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.appendCheckBox = new System.Windows.Forms.CheckBox();
            this.setKeyBtn = new System.Windows.Forms.Button();
            this.currKeyInfoLbl = new System.Windows.Forms.Label();
            this.currKeyLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // localLbl
            // 
            this.localLbl.AutoSize = true;
            this.localLbl.Location = new System.Drawing.Point(53, 23);
            this.localLbl.Name = "localLbl";
            this.localLbl.Size = new System.Drawing.Size(70, 13);
            this.localLbl.TabIndex = 0;
            this.localLbl.Text = "File Location:";
            // 
            // localisation
            // 
            this.localisation.AutoSize = true;
            this.localisation.Location = new System.Drawing.Point(119, 23);
            this.localisation.Name = "localisation";
            this.localisation.Size = new System.Drawing.Size(66, 13);
            this.localisation.TabIndex = 1;
            this.localisation.Text = "eg. C:/folder";
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(54, 53);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(176, 99);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 20);
            this.fileName.TabIndex = 3;
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.Location = new System.Drawing.Point(53, 101);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(55, 13);
            this.fileNameLbl.TabIndex = 4;
            this.fileNameLbl.Text = "File name:";
            // 
            // fileNumber
            // 
            this.fileNumber.Location = new System.Drawing.Point(334, 101);
            this.fileNumber.Name = "fileNumber";
            this.fileNumber.Size = new System.Drawing.Size(51, 20);
            this.fileNumber.TabIndex = 8;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(53, 140);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(80, 13);
            this.timeLbl.TabIndex = 9;
            this.timeLbl.Text = "Last timestamp:";
            // 
            // timePassLbl
            // 
            this.timePassLbl.AutoSize = true;
            this.timePassLbl.Location = new System.Drawing.Point(158, 140);
            this.timePassLbl.Name = "timePassLbl";
            this.timePassLbl.Size = new System.Drawing.Size(43, 13);
            this.timePassLbl.TabIndex = 10;
            this.timePassLbl.Text = "0:00:00";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(54, 177);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 11;
            this.start.Text = "play";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(200, 177);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(63, 23);
            this.pause.TabIndex = 12;
            this.pause.Text = "pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(310, 177);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 13;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // appendCheckBox
            // 
            this.appendCheckBox.AutoSize = true;
            this.appendCheckBox.Checked = true;
            this.appendCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.appendCheckBox.Location = new System.Drawing.Point(293, 140);
            this.appendCheckBox.Name = "appendCheckBox";
            this.appendCheckBox.Size = new System.Drawing.Size(92, 17);
            this.appendCheckBox.TabIndex = 14;
            this.appendCheckBox.Text = "Nadpisywanie";
            this.appendCheckBox.UseVisualStyleBackColor = true;
            this.appendCheckBox.Visible = false;
            // 
            // setKeyBtn
            // 
            this.setKeyBtn.Location = new System.Drawing.Point(322, 231);
            this.setKeyBtn.Name = "setKeyBtn";
            this.setKeyBtn.Size = new System.Drawing.Size(63, 23);
            this.setKeyBtn.TabIndex = 15;
            this.setKeyBtn.Text = "set key";
            this.setKeyBtn.UseVisualStyleBackColor = true;
            this.setKeyBtn.Click += new System.EventHandler(this.setKeyBtn_Click);
            // 
            // currKeyInfoLbl
            // 
            this.currKeyInfoLbl.AutoSize = true;
            this.currKeyInfoLbl.Location = new System.Drawing.Point(53, 236);
            this.currKeyInfoLbl.Name = "currKeyInfoLbl";
            this.currKeyInfoLbl.Size = new System.Drawing.Size(109, 13);
            this.currKeyInfoLbl.TabIndex = 16;
            this.currKeyInfoLbl.Text = "Current key to detect:";
            // 
            // currKeyLbl
            // 
            this.currKeyLbl.AutoSize = true;
            this.currKeyLbl.Location = new System.Drawing.Point(210, 236);
            this.currKeyLbl.Name = "currKeyLbl";
            this.currKeyLbl.Size = new System.Drawing.Size(24, 13);
            this.currKeyLbl.TabIndex = 17;
            this.currKeyLbl.Text = "key";
            // 
            // timeMarkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 297);
            this.Controls.Add(this.currKeyLbl);
            this.Controls.Add(this.currKeyInfoLbl);
            this.Controls.Add(this.setKeyBtn);
            this.Controls.Add(this.appendCheckBox);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.start);
            this.Controls.Add(this.timePassLbl);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.fileNumber);
            this.Controls.Add(this.fileNameLbl);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.localisation);
            this.Controls.Add(this.localLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "timeMarkers";
            this.Text = "Time Stamps";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label localLbl;
        private System.Windows.Forms.Label localisation;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.NumericUpDown fileNumber;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label timePassLbl;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.CheckBox appendCheckBox;
        //timer
        private System.Diagnostics.Stopwatch stopwatch;
        //hook to acces keybord input
        private Gma.System.MouseKeyHook.IKeyboardMouseEvents gloobalHook;
        //key to detect
        private System.Windows.Forms.Keys detectKey;
        //path and path with file
        private string path, fullpath;
        //class to write timestamps
        private FileHandler fileHandler;
        //mouse button to detect
        private System.Windows.Forms.MouseButtons detectMouseButton;
        private System.Windows.Forms.Button setKeyBtn;
        private System.Windows.Forms.Label currKeyInfoLbl;
        private System.Windows.Forms.Label currKeyLbl;
    }
}

