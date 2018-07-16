namespace AutoCaption
{
    partial class AutoCaption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.ChooseMicButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.MicLabel = new System.Windows.Forms.Label();
            this.ChooseOutputButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.SpeakTimer = new System.Windows.Forms.Timer(this.components);
            this.lengthTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 26);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ChooseMicButton
            // 
            this.ChooseMicButton.Location = new System.Drawing.Point(12, 323);
            this.ChooseMicButton.Name = "ChooseMicButton";
            this.ChooseMicButton.Size = new System.Drawing.Size(129, 23);
            this.ChooseMicButton.TabIndex = 1;
            this.ChooseMicButton.Text = "Choose microphone";
            this.ChooseMicButton.UseVisualStyleBackColor = true;
            this.ChooseMicButton.Click += new System.EventHandler(this.ChooseMicButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(104, 26);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // MicLabel
            // 
            this.MicLabel.AutoSize = true;
            this.MicLabel.Location = new System.Drawing.Point(149, 328);
            this.MicLabel.Name = "MicLabel";
            this.MicLabel.Size = new System.Drawing.Size(30, 13);
            this.MicLabel.TabIndex = 3;
            this.MicLabel.Text = "Mic: ";
            // 
            // ChooseOutputButton
            // 
            this.ChooseOutputButton.Location = new System.Drawing.Point(12, 81);
            this.ChooseOutputButton.Name = "ChooseOutputButton";
            this.ChooseOutputButton.Size = new System.Drawing.Size(129, 23);
            this.ChooseOutputButton.TabIndex = 4;
            this.ChooseOutputButton.Text = "Choose File output";
            this.ChooseOutputButton.UseVisualStyleBackColor = true;
            this.ChooseOutputButton.Click += new System.EventHandler(this.ChooseOutputButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(215, 26);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(223, 284);
            this.OutputTextBox.TabIndex = 5;
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(12, 121);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(32, 13);
            this.FilePathLabel.TabIndex = 6;
            this.FilePathLabel.Text = "Path:";
            this.FilePathLabel.UseMnemonic = false;
            // 
            // SpeakTimer
            // 
            this.SpeakTimer.Enabled = true;
            this.SpeakTimer.Interval = 6500;
            this.SpeakTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lengthTimer
            // 
            this.lengthTimer.Enabled = true;
            this.lengthTimer.Interval = 1500;
            this.lengthTimer.Tick += new System.EventHandler(this.lengthTimer_Tick);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(323, 351);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(43, 13);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "Status: ";
            // 
            // AutoCaption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(450, 385);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.ChooseOutputButton);
            this.Controls.Add(this.MicLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.ChooseMicButton);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AutoCaption";
            this.Text = "AutoCaption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ChooseMicButton;
        private System.Windows.Forms.Button StopButton;
        public System.Windows.Forms.Label MicLabel;
        private System.Windows.Forms.Button ChooseOutputButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Timer SpeakTimer;
        private System.Windows.Forms.Timer lengthTimer;
        private System.Windows.Forms.Label StatusLabel;
    }
}

