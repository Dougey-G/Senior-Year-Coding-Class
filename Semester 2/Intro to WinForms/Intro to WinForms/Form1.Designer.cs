namespace Intro_to_WinForms
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Button_DoSomething = new System.Windows.Forms.Button();
            this.CheckBox_FailSafe = new System.Windows.Forms.CheckBox();
            this.DateTime_Picker = new System.Windows.Forms.DateTimePicker();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.CheckforMarioMaker2Hype = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_DoSomething
            // 
            this.Button_DoSomething.Location = new System.Drawing.Point(12, 12);
            this.Button_DoSomething.Name = "Button_DoSomething";
            this.Button_DoSomething.Size = new System.Drawing.Size(245, 156);
            this.Button_DoSomething.TabIndex = 0;
            this.Button_DoSomething.Text = "Very Useful Button";
            this.Button_DoSomething.UseVisualStyleBackColor = true;
            this.Button_DoSomething.Click += new System.EventHandler(this.Button_DoSomething_Click);
            // 
            // CheckBox_FailSafe
            // 
            this.CheckBox_FailSafe.AutoSize = true;
            this.CheckBox_FailSafe.Location = new System.Drawing.Point(333, 29);
            this.CheckBox_FailSafe.Name = "CheckBox_FailSafe";
            this.CheckBox_FailSafe.Size = new System.Drawing.Size(67, 17);
            this.CheckBox_FailSafe.TabIndex = 1;
            this.CheckBox_FailSafe.Text = "Fail Safe";
            this.CheckBox_FailSafe.UseVisualStyleBackColor = true;
            // 
            // DateTime_Picker
            // 
            this.DateTime_Picker.Location = new System.Drawing.Point(351, 89);
            this.DateTime_Picker.Name = "DateTime_Picker";
            this.DateTime_Picker.Size = new System.Drawing.Size(200, 20);
            this.DateTime_Picker.TabIndex = 2;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(72, 208);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(205, 133);
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(473, 199);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 20);
            this.TextBox.TabIndex = 4;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // CheckforMarioMaker2Hype
            // 
            this.CheckforMarioMaker2Hype.AutoSize = true;
            this.CheckforMarioMaker2Hype.Location = new System.Drawing.Point(319, 53);
            this.CheckforMarioMaker2Hype.Name = "CheckforMarioMaker2Hype";
            this.CheckforMarioMaker2Hype.Size = new System.Drawing.Size(221, 17);
            this.CheckforMarioMaker2Hype.TabIndex = 5;
            this.CheckforMarioMaker2Hype.Text = "check if you\'re excited for Mario Maker 2.";
            this.CheckforMarioMaker2Hype.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckforMarioMaker2Hype);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.DateTime_Picker);
            this.Controls.Add(this.CheckBox_FailSafe);
            this.Controls.Add(this.Button_DoSomething);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Button_DoSomething;
        private System.Windows.Forms.CheckBox CheckBox_FailSafe;
        private System.Windows.Forms.DateTimePicker DateTime_Picker;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.CheckBox CheckforMarioMaker2Hype;
    }
}

