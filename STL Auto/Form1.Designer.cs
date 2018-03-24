namespace STL_Auto
{
    partial class FormMain
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
            this.OpenFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.ButtonCompute = new System.Windows.Forms.Button();
            this.TextBoxFiles = new System.Windows.Forms.TextBox();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFileDialogExcel
            // 
            this.OpenFileDialogExcel.FileName = "openFileDialog1";
            // 
            // ButtonCompute
            // 
            this.ButtonCompute.Location = new System.Drawing.Point(456, 24);
            this.ButtonCompute.Name = "ButtonCompute";
            this.ButtonCompute.Size = new System.Drawing.Size(75, 23);
            this.ButtonCompute.TabIndex = 0;
            this.ButtonCompute.Text = "Compute";
            this.ButtonCompute.UseVisualStyleBackColor = true;
            // 
            // TextBoxFiles
            // 
            this.TextBoxFiles.Location = new System.Drawing.Point(32, 24);
            this.TextBoxFiles.Name = "TextBoxFiles";
            this.TextBoxFiles.Size = new System.Drawing.Size(224, 20);
            this.TextBoxFiles.TabIndex = 1;
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Location = new System.Drawing.Point(288, 24);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowse.TabIndex = 2;
            this.ButtonBrowse.Text = "Browse";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Write";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 335);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonBrowse);
            this.Controls.Add(this.TextBoxFiles);
            this.Controls.Add(this.ButtonCompute);
            this.Name = "FormMain";
            this.Text = "Excel Auto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialogExcel;
        private System.Windows.Forms.Button ButtonCompute;
        private System.Windows.Forms.TextBox TextBoxFiles;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

