namespace LENCO_TEKAN
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ArhivetextBox = new System.Windows.Forms.TextBox();
            this.OutputFolderText = new System.Windows.Forms.TextBox();
            this.Input_folder_text = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Output folder";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Input folder";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(326, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LENCO TEKAN";
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(377, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Arhive folder";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::LENCO_TEKAN.Properties.Settings.Default.autostart;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LENCO_TEKAN.Properties.Settings.Default, "autostart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(20, 135);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "AutoStart";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // ArhivetextBox
            // 
            this.ArhivetextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LENCO_TEKAN.Properties.Settings.Default, "Arhivefolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ArhivetextBox.Location = new System.Drawing.Point(94, 76);
            this.ArhivetextBox.Name = "ArhivetextBox";
            this.ArhivetextBox.Size = new System.Drawing.Size(277, 20);
            this.ArhivetextBox.TabIndex = 25;
            this.ArhivetextBox.Text = global::LENCO_TEKAN.Properties.Settings.Default.Arhivefolder;
            // 
            // OutputFolderText
            // 
            this.OutputFolderText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LENCO_TEKAN.Properties.Settings.Default, "OutputFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OutputFolderText.Location = new System.Drawing.Point(92, 43);
            this.OutputFolderText.Name = "OutputFolderText";
            this.OutputFolderText.Size = new System.Drawing.Size(277, 20);
            this.OutputFolderText.TabIndex = 21;
            this.OutputFolderText.Text = global::LENCO_TEKAN.Properties.Settings.Default.OutputFolder;
            // 
            // Input_folder_text
            // 
            this.Input_folder_text.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LENCO_TEKAN.Properties.Settings.Default, "InputFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Input_folder_text.Location = new System.Drawing.Point(92, 12);
            this.Input_folder_text.Name = "Input_folder_text";
            this.Input_folder_text.Size = new System.Drawing.Size(277, 20);
            this.Input_folder_text.TabIndex = 17;
            this.Input_folder_text.Text = global::LENCO_TEKAN.Properties.Settings.Default.InputFolder;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 170);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ArhivetextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.OutputFolderText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Input_folder_text);
            this.Name = "Form1";
            this.Text = "LENCO TEKAN v. 1.0.0.1";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox OutputFolderText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Input_folder_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox ArhivetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

