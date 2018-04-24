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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTblPayroll = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPayroll = new System.Windows.Forms.Button();
            this.textBoxPayroll = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTblGosi = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGosi = new System.Windows.Forms.Button();
            this.textBoxGosi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBig = new System.Windows.Forms.Button();
            this.textBoxBig = new System.Windows.Forms.TextBox();
            this.TextBoxPaymentDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNetPayCol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 610);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(603, 200);
            this.dataGridView1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Payroll WorkSheet Name";
            // 
            // textBoxTblPayroll
            // 
            this.textBoxTblPayroll.Location = new System.Drawing.Point(11, 104);
            this.textBoxTblPayroll.Name = "textBoxTblPayroll";
            this.textBoxTblPayroll.Size = new System.Drawing.Size(184, 20);
            this.textBoxTblPayroll.TabIndex = 9;
            this.textBoxTblPayroll.Text = "Sheet1";
            this.textBoxTblPayroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payroll Path";
            // 
            // buttonPayroll
            // 
            this.buttonPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPayroll.Location = new System.Drawing.Point(120, 53);
            this.buttonPayroll.Name = "buttonPayroll";
            this.buttonPayroll.Size = new System.Drawing.Size(75, 23);
            this.buttonPayroll.TabIndex = 7;
            this.buttonPayroll.Text = "browse";
            this.buttonPayroll.UseVisualStyleBackColor = true;
            this.buttonPayroll.Click += new System.EventHandler(this.buttonPayroll_Click);
            // 
            // textBoxPayroll
            // 
            this.textBoxPayroll.Location = new System.Drawing.Point(8, 24);
            this.textBoxPayroll.Name = "textBoxPayroll";
            this.textBoxPayroll.Size = new System.Drawing.Size(184, 20);
            this.textBoxPayroll.TabIndex = 6;
            this.textBoxPayroll.Text = "E:\\MaskRider\\mahmoud\\march 2018 payroll.xlsx";
            this.textBoxPayroll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Gosi WorkSheet Name";
            // 
            // textBoxTblGosi
            // 
            this.textBoxTblGosi.Location = new System.Drawing.Point(208, 107);
            this.textBoxTblGosi.Name = "textBoxTblGosi";
            this.textBoxTblGosi.Size = new System.Drawing.Size(184, 20);
            this.textBoxTblGosi.TabIndex = 22;
            this.textBoxTblGosi.Text = "Sheet1";
            this.textBoxTblGosi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.Red;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCalculate.Location = new System.Drawing.Point(200, 336);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(200, 65);
            this.buttonCalculate.TabIndex = 21;
            this.buttonCalculate.Text = "calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Gosi Path";
            // 
            // buttonGosi
            // 
            this.buttonGosi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGosi.Location = new System.Drawing.Point(320, 56);
            this.buttonGosi.Name = "buttonGosi";
            this.buttonGosi.Size = new System.Drawing.Size(75, 23);
            this.buttonGosi.TabIndex = 19;
            this.buttonGosi.Text = "browse";
            this.buttonGosi.UseVisualStyleBackColor = true;
            this.buttonGosi.Click += new System.EventHandler(this.buttonGosi_Click);
            // 
            // textBoxGosi
            // 
            this.textBoxGosi.Location = new System.Drawing.Point(208, 27);
            this.textBoxGosi.Name = "textBoxGosi";
            this.textBoxGosi.Size = new System.Drawing.Size(184, 20);
            this.textBoxGosi.TabIndex = 18;
            this.textBoxGosi.Text = "E:\\MaskRider\\mahmoud\\gosi march.xlsx";
            this.textBoxGosi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Big Salaries Path";
            // 
            // buttonBig
            // 
            this.buttonBig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBig.Location = new System.Drawing.Point(528, 54);
            this.buttonBig.Name = "buttonBig";
            this.buttonBig.Size = new System.Drawing.Size(75, 23);
            this.buttonBig.TabIndex = 25;
            this.buttonBig.Text = "browse";
            this.buttonBig.UseVisualStyleBackColor = true;
            this.buttonBig.Click += new System.EventHandler(this.buttonBig_Click);
            // 
            // textBoxBig
            // 
            this.textBoxBig.Location = new System.Drawing.Point(416, 25);
            this.textBoxBig.Name = "textBoxBig";
            this.textBoxBig.Size = new System.Drawing.Size(184, 20);
            this.textBoxBig.TabIndex = 24;
            this.textBoxBig.Text = "E:\\MaskRider\\mahmoud\\LATEST UPDATE PAYROLL\\BIG SALARIES ORIGINAL - UPDATED  April" +
    " 02,2018.xlsx";
            this.textBoxBig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBoxPaymentDescription
            // 
            this.TextBoxPaymentDescription.Location = new System.Drawing.Point(208, 305);
            this.TextBoxPaymentDescription.Name = "TextBoxPaymentDescription";
            this.TextBoxPaymentDescription.Size = new System.Drawing.Size(184, 20);
            this.TextBoxPaymentDescription.TabIndex = 31;
            this.TextBoxPaymentDescription.Text = "2/28/2018";
            this.TextBoxPaymentDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Payment Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Net Pay Column";
            // 
            // textBoxNetPayCol
            // 
            this.textBoxNetPayCol.Location = new System.Drawing.Point(114, 153);
            this.textBoxNetPayCol.Name = "textBoxNetPayCol";
            this.textBoxNetPayCol.Size = new System.Drawing.Size(79, 20);
            this.textBoxNetPayCol.TabIndex = 33;
            this.textBoxNetPayCol.Text = "V";
            this.textBoxNetPayCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Batch No Column";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "C";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Basic";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(318, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 20);
            this.textBox2.TabIndex = 37;
            this.textBox2.Text = "I";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(357, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Others";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(318, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 20);
            this.textBox3.TabIndex = 39;
            this.textBox3.Text = "M";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(273, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Housing";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(235, 249);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(79, 20);
            this.textBox4.TabIndex = 45;
            this.textBox4.Text = "K";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(264, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Aesthetic";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(235, 201);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(79, 20);
            this.textBox5.TabIndex = 43;
            this.textBox5.Text = "N";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(424, 248);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(159, 112);
            this.dataGridView2.TabIndex = 47;
            this.dataGridView2.Visible = false;
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 632);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNetPayCol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxPaymentDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBig);
            this.Controls.Add(this.textBoxBig);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTblGosi);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGosi);
            this.Controls.Add(this.textBoxGosi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTblPayroll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPayroll);
            this.Controls.Add(this.textBoxPayroll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Auto Big Salary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTblPayroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPayroll;
        private System.Windows.Forms.TextBox textBoxPayroll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTblGosi;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGosi;
        private System.Windows.Forms.TextBox textBoxGosi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBig;
        private System.Windows.Forms.TextBox textBoxBig;
        private System.Windows.Forms.TextBox TextBoxPaymentDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNetPayCol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}