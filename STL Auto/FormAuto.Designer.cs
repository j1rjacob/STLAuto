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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPayroll = new System.Windows.Forms.Button();
            this.textBoxPayroll = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGosi = new System.Windows.Forms.Button();
            this.textBoxGosi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBig = new System.Windows.Forms.Button();
            this.textBoxBig = new System.Windows.Forms.TextBox();
            this.TextBoxPaymentDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxSmall = new System.Windows.Forms.TextBox();
            this.buttonSmall = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 430);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(811, 22);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(805, 200);
            this.dataGridView1.TabIndex = 5;
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
            this.buttonPayroll.BackColor = System.Drawing.Color.Green;
            this.buttonPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayroll.ForeColor = System.Drawing.Color.White;
            this.buttonPayroll.Location = new System.Drawing.Point(120, 53);
            this.buttonPayroll.Name = "buttonPayroll";
            this.buttonPayroll.Size = new System.Drawing.Size(75, 23);
            this.buttonPayroll.TabIndex = 7;
            this.buttonPayroll.Text = "browse";
            this.buttonPayroll.UseVisualStyleBackColor = false;
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
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.Green;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCalculate.Location = new System.Drawing.Point(322, 141);
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
            this.buttonGosi.BackColor = System.Drawing.Color.Green;
            this.buttonGosi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGosi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGosi.ForeColor = System.Drawing.Color.White;
            this.buttonGosi.Location = new System.Drawing.Point(320, 56);
            this.buttonGosi.Name = "buttonGosi";
            this.buttonGosi.Size = new System.Drawing.Size(75, 23);
            this.buttonGosi.TabIndex = 19;
            this.buttonGosi.Text = "browse";
            this.buttonGosi.UseVisualStyleBackColor = false;
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
            this.buttonBig.BackColor = System.Drawing.Color.Green;
            this.buttonBig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBig.ForeColor = System.Drawing.Color.White;
            this.buttonBig.Location = new System.Drawing.Point(528, 54);
            this.buttonBig.Name = "buttonBig";
            this.buttonBig.Size = new System.Drawing.Size(75, 23);
            this.buttonBig.TabIndex = 25;
            this.buttonBig.Text = "browse";
            this.buttonBig.UseVisualStyleBackColor = false;
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
            this.TextBoxPaymentDescription.Location = new System.Drawing.Point(330, 110);
            this.TextBoxPaymentDescription.Name = "TextBoxPaymentDescription";
            this.TextBoxPaymentDescription.Size = new System.Drawing.Size(184, 20);
            this.TextBoxPaymentDescription.TabIndex = 31;
            this.TextBoxPaymentDescription.Text = "2/28/2018";
            this.TextBoxPaymentDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Payment Description";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 96);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(159, 112);
            this.dataGridView2.TabIndex = 47;
            this.dataGridView2.Visible = false;
            // 
            // textBoxSmall
            // 
            this.textBoxSmall.Location = new System.Drawing.Point(616, 25);
            this.textBoxSmall.Name = "textBoxSmall";
            this.textBoxSmall.Size = new System.Drawing.Size(184, 20);
            this.textBoxSmall.TabIndex = 24;
            this.textBoxSmall.Text = "E:\\MaskRider\\mahmoud\\LATEST UPDATE PAYROLL\\Payroll 1189 format Org UPDATED April " +
    "01-2018 NEW.xlsx";
            this.textBoxSmall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSmall
            // 
            this.buttonSmall.BackColor = System.Drawing.Color.Green;
            this.buttonSmall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSmall.ForeColor = System.Drawing.Color.White;
            this.buttonSmall.Location = new System.Drawing.Point(728, 54);
            this.buttonSmall.Name = "buttonSmall";
            this.buttonSmall.Size = new System.Drawing.Size(75, 23);
            this.buttonSmall.TabIndex = 25;
            this.buttonSmall.Text = "browse";
            this.buttonSmall.UseVisualStyleBackColor = false;
            this.buttonSmall.Click += new System.EventHandler(this.buttonSmall_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(712, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Small Salaries Path";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(584, 96);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(159, 112);
            this.dataGridView3.TabIndex = 48;
            this.dataGridView3.Visible = false;
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 452);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxPaymentDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSmall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSmall);
            this.Controls.Add(this.buttonBig);
            this.Controls.Add(this.textBoxBig);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGosi);
            this.Controls.Add(this.textBoxGosi);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPayroll;
        private System.Windows.Forms.TextBox textBoxPayroll;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGosi;
        private System.Windows.Forms.TextBox textBoxGosi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBig;
        private System.Windows.Forms.TextBox textBoxBig;
        private System.Windows.Forms.TextBox TextBoxPaymentDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxSmall;
        private System.Windows.Forms.Button buttonSmall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}