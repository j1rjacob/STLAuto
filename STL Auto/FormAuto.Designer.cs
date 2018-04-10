namespace STL_Auto
{
    partial class FormAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTblPayroll = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPayroll = new System.Windows.Forms.Button();
            this.textBoxPayroll = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTblGosi = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGosi = new System.Windows.Forms.Button();
            this.textBoxGosi = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTblBig = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBig = new System.Windows.Forms.Button();
            this.textBoxBig = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxTblPayroll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonPayroll);
            this.panel1.Controls.Add(this.textBoxPayroll);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 328);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Payroll WorkSheet Name";
            // 
            // textBoxTblPayroll
            // 
            this.textBoxTblPayroll.Location = new System.Drawing.Point(11, 105);
            this.textBoxTblPayroll.Name = "textBoxTblPayroll";
            this.textBoxTblPayroll.Size = new System.Drawing.Size(184, 20);
            this.textBoxTblPayroll.TabIndex = 3;
            this.textBoxTblPayroll.Text = "Sheet1";
            this.textBoxTblPayroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Payroll Path";
            // 
            // buttonPayroll
            // 
            this.buttonPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPayroll.Location = new System.Drawing.Point(120, 54);
            this.buttonPayroll.Name = "buttonPayroll";
            this.buttonPayroll.Size = new System.Drawing.Size(75, 23);
            this.buttonPayroll.TabIndex = 1;
            this.buttonPayroll.Text = "browse";
            this.buttonPayroll.UseVisualStyleBackColor = true;
            this.buttonPayroll.Click += new System.EventHandler(this.buttonPayroll_Click);
            // 
            // textBoxPayroll
            // 
            this.textBoxPayroll.Location = new System.Drawing.Point(8, 25);
            this.textBoxPayroll.Name = "textBoxPayroll";
            this.textBoxPayroll.Size = new System.Drawing.Size(184, 20);
            this.textBoxPayroll.TabIndex = 0;
            this.textBoxPayroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxTblGosi);
            this.panel3.Controls.Add(this.buttonCalculate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.buttonGosi);
            this.panel3.Controls.Add(this.textBoxGosi);
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 328);
            this.panel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gosi WorkSheet Name";
            // 
            // textBoxTblGosi
            // 
            this.textBoxTblGosi.Location = new System.Drawing.Point(8, 105);
            this.textBoxTblGosi.Name = "textBoxTblGosi";
            this.textBoxTblGosi.Size = new System.Drawing.Size(184, 20);
            this.textBoxTblGosi.TabIndex = 5;
            this.textBoxTblGosi.Text = "Sheet1";
            this.textBoxTblGosi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.Red;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCalculate.Location = new System.Drawing.Point(0, 142);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(200, 176);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gosi Path";
            // 
            // buttonGosi
            // 
            this.buttonGosi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGosi.Location = new System.Drawing.Point(120, 54);
            this.buttonGosi.Name = "buttonGosi";
            this.buttonGosi.Size = new System.Drawing.Size(75, 23);
            this.buttonGosi.TabIndex = 2;
            this.buttonGosi.Text = "browse";
            this.buttonGosi.UseVisualStyleBackColor = true;
            this.buttonGosi.Click += new System.EventHandler(this.buttonGosi_Click);
            // 
            // textBoxGosi
            // 
            this.textBoxGosi.Location = new System.Drawing.Point(8, 25);
            this.textBoxGosi.Name = "textBoxGosi";
            this.textBoxGosi.Size = new System.Drawing.Size(184, 20);
            this.textBoxGosi.TabIndex = 1;
            this.textBoxGosi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxTblBig);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonBig);
            this.panel2.Controls.Add(this.textBoxBig);
            this.panel2.Location = new System.Drawing.Point(400, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 328);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Big Salaries Worksheet Name";
            // 
            // textBoxTblBig
            // 
            this.textBoxTblBig.Location = new System.Drawing.Point(8, 105);
            this.textBoxTblBig.Name = "textBoxTblBig";
            this.textBoxTblBig.Size = new System.Drawing.Size(184, 20);
            this.textBoxTblBig.TabIndex = 5;
            this.textBoxTblBig.Text = "Payroll Information";
            this.textBoxTblBig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Big Salaries Path";
            // 
            // buttonBig
            // 
            this.buttonBig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBig.Location = new System.Drawing.Point(120, 54);
            this.buttonBig.Name = "buttonBig";
            this.buttonBig.Size = new System.Drawing.Size(75, 23);
            this.buttonBig.TabIndex = 2;
            this.buttonBig.Text = "browse";
            this.buttonBig.UseVisualStyleBackColor = true;
            this.buttonBig.Click += new System.EventHandler(this.buttonBig_Click);
            // 
            // textBoxBig
            // 
            this.textBoxBig.Location = new System.Drawing.Point(8, 25);
            this.textBoxBig.Name = "textBoxBig";
            this.textBoxBig.Size = new System.Drawing.Size(184, 20);
            this.textBoxBig.TabIndex = 1;
            this.textBoxBig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 554);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(610, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(603, 208);
            this.dataGridView1.TabIndex = 5;
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Auto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPayroll;
        private System.Windows.Forms.TextBox textBoxPayroll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonGosi;
        private System.Windows.Forms.TextBox textBoxGosi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBig;
        private System.Windows.Forms.TextBox textBoxBig;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTblPayroll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTblGosi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTblBig;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}