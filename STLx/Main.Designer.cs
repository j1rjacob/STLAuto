namespace STLx
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.metroTileWith = new MetroFramework.Controls.MetroTile();
            this.metroTileWithout = new MetroFramework.Controls.MetroTile();
            this.metroTileAuto = new MetroFramework.Controls.MetroTile();
            this.metroTileCompany = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileWith
            // 
            this.metroTileWith.Location = new System.Drawing.Point(24, 64);
            this.metroTileWith.Name = "metroTileWith";
            this.metroTileWith.Size = new System.Drawing.Size(208, 71);
            this.metroTileWith.TabIndex = 9;
            this.metroTileWith.Text = "Employee with Bank Account";
            this.metroTileWith.Click += new System.EventHandler(this.metroTileWith_Click);
            // 
            // metroTileWithout
            // 
            this.metroTileWithout.Location = new System.Drawing.Point(24, 149);
            this.metroTileWithout.Name = "metroTileWithout";
            this.metroTileWithout.Size = new System.Drawing.Size(208, 71);
            this.metroTileWithout.TabIndex = 10;
            this.metroTileWithout.Text = "Employee without Bank Account";
            this.metroTileWithout.Click += new System.EventHandler(this.metroTileWithout_Click);
            // 
            // metroTileAuto
            // 
            this.metroTileAuto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.metroTileAuto.Location = new System.Drawing.Point(256, 64);
            this.metroTileAuto.Name = "metroTileAuto";
            this.metroTileAuto.Size = new System.Drawing.Size(232, 240);
            this.metroTileAuto.TabIndex = 11;
            this.metroTileAuto.Text = "STL Auto";
            this.metroTileAuto.Click += new System.EventHandler(this.metroTileAuto_Click);
            // 
            // metroTileCompany
            // 
            this.metroTileCompany.Location = new System.Drawing.Point(24, 233);
            this.metroTileCompany.Name = "metroTileCompany";
            this.metroTileCompany.Size = new System.Drawing.Size(208, 71);
            this.metroTileCompany.TabIndex = 12;
            this.metroTileCompany.Text = "Company";
            this.metroTileCompany.Click += new System.EventHandler(this.metroTileCompany_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 323);
            this.Controls.Add(this.metroTileCompany);
            this.Controls.Add(this.metroTileAuto);
            this.Controls.Add(this.metroTileWithout);
            this.Controls.Add(this.metroTileWith);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileWith;
        private MetroFramework.Controls.MetroTile metroTileWithout;
        private MetroFramework.Controls.MetroTile metroTileAuto;
        private MetroFramework.Controls.MetroTile metroTileCompany;
    }
}