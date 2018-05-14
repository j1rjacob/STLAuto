namespace STLx
{
    partial class WBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WBank));
            this.dataGridViewWBank = new System.Windows.Forms.DataGridView();
            this.ComboBoxStatusW = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAddress3 = new System.Windows.Forms.TextBox();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.textBoxBankCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxBatchNo = new System.Windows.Forms.TextBox();
            this.TextBoxBankAcctNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderWithBank = new System.Windows.Forms.ErrorProvider(this.components);
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxIqama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWithBank)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWBank
            // 
            this.dataGridViewWBank.AllowUserToAddRows = false;
            this.dataGridViewWBank.AllowUserToDeleteRows = false;
            this.dataGridViewWBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWBank.Location = new System.Drawing.Point(16, 384);
            this.dataGridViewWBank.Name = "dataGridViewWBank";
            this.dataGridViewWBank.ReadOnly = true;
            this.dataGridViewWBank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWBank.Size = new System.Drawing.Size(712, 150);
            this.dataGridViewWBank.TabIndex = 190;
            this.dataGridViewWBank.SelectionChanged += new System.EventHandler(this.dataGridViewWBank_SelectionChanged);
            // 
            // ComboBoxStatusW
            // 
            this.ComboBoxStatusW.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxStatusW.FormattingEnabled = true;
            this.ComboBoxStatusW.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.ComboBoxStatusW.Location = new System.Drawing.Point(520, 144);
            this.ComboBoxStatusW.Name = "ComboBoxStatusW";
            this.ComboBoxStatusW.Size = new System.Drawing.Size(216, 28);
            this.ComboBoxStatusW.TabIndex = 189;
            this.ComboBoxStatusW.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxStatus_Validating);
            this.ComboBoxStatusW.Validated += new System.EventHandler(this.ComboBoxStatus_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(434, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 22);
            this.label10.TabIndex = 188;
            this.label10.Text = "STATUS";
            // 
            // textBoxAddress3
            // 
            this.textBoxAddress3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAddress3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress3.Location = new System.Drawing.Point(520, 112);
            this.textBoxAddress3.Name = "textBoxAddress3";
            this.textBoxAddress3.Size = new System.Drawing.Size(216, 27);
            this.textBoxAddress3.TabIndex = 187;
            this.textBoxAddress3.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAddress3_Validating);
            this.textBoxAddress3.Validated += new System.EventHandler(this.textBoxAddress3_Validated);
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress2.Location = new System.Drawing.Point(520, 80);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(216, 27);
            this.textBoxAddress2.TabIndex = 186;
            this.textBoxAddress2.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAddress2_Validating);
            this.textBoxAddress2.Validated += new System.EventHandler(this.textBoxAddress2_Validated);
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress1.Location = new System.Drawing.Point(160, 272);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(216, 27);
            this.textBoxAddress1.TabIndex = 185;
            this.textBoxAddress1.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAddress1_Validating);
            this.textBoxAddress1.Validated += new System.EventHandler(this.textBoxAddress1_Validated);
            // 
            // textBoxProject
            // 
            this.textBoxProject.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProject.Location = new System.Drawing.Point(160, 240);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(216, 27);
            this.textBoxProject.TabIndex = 184;
            this.textBoxProject.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxProject_Validating);
            this.textBoxProject.Validated += new System.EventHandler(this.textBoxProject_Validated);
            // 
            // textBoxBankCode
            // 
            this.textBoxBankCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxBankCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBankCode.Location = new System.Drawing.Point(160, 178);
            this.textBoxBankCode.Name = "textBoxBankCode";
            this.textBoxBankCode.Size = new System.Drawing.Size(216, 27);
            this.textBoxBankCode.TabIndex = 183;
            this.textBoxBankCode.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBankCode_Validating);
            this.textBoxBankCode.Validated += new System.EventHandler(this.textBoxBankCode_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 182;
            this.label5.Text = "ADDRESS 2";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.BackgroundImage")));
            this.ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(520, 320);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(136, 56);
            this.ButtonDelete.TabIndex = 177;
            this.ButtonDelete.Text = "DELETE";
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AutoSize = true;
            this.ButtonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave.BackgroundImage")));
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(376, 320);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(136, 56);
            this.ButtonSave.TabIndex = 178;
            this.ButtonSave.Text = "SAVE";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.AutoSize = true;
            this.ButtonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEdit.BackgroundImage")));
            this.ButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.Location = new System.Drawing.Point(232, 320);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(136, 56);
            this.ButtonEdit.TabIndex = 179;
            this.ButtonEdit.Text = "EDIT";
            this.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonNew
            // 
            this.ButtonNew.AutoSize = true;
            this.ButtonNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonNew.BackgroundImage")));
            this.ButtonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.Location = new System.Drawing.Point(88, 320);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(136, 56);
            this.ButtonNew.TabIndex = 180;
            this.ButtonNew.Text = "NEW";
            this.ButtonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.AutoSize = true;
            this.ButtonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSearch.BackgroundImage")));
            this.ButtonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(584, 8);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(151, 56);
            this.ButtonSearch.TabIndex = 181;
            this.ButtonSearch.Text = "SEARCH";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxBatchNo
            // 
            this.TextBoxBatchNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxBatchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBatchNo.Location = new System.Drawing.Point(160, 114);
            this.TextBoxBatchNo.Name = "TextBoxBatchNo";
            this.TextBoxBatchNo.Size = new System.Drawing.Size(216, 27);
            this.TextBoxBatchNo.TabIndex = 165;
            this.TextBoxBatchNo.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxBatchNo_Validating);
            this.TextBoxBatchNo.Validated += new System.EventHandler(this.TextBoxBatchNo_Validated);
            // 
            // TextBoxBankAcctNo
            // 
            this.TextBoxBankAcctNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxBankAcctNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBankAcctNo.Location = new System.Drawing.Point(160, 209);
            this.TextBoxBankAcctNo.Name = "TextBoxBankAcctNo";
            this.TextBoxBankAcctNo.Size = new System.Drawing.Size(216, 27);
            this.TextBoxBankAcctNo.TabIndex = 167;
            this.TextBoxBankAcctNo.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxBankAcctNo_Validating);
            this.TextBoxBankAcctNo.Validated += new System.EventHandler(this.TextBoxBankAcctNo_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 171;
            this.label6.Text = "BANK ACCT NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 170;
            this.label3.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 169;
            this.label2.Text = "BATCH NO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 175;
            this.label1.Text = "IQAMA";
            // 
            // errorProviderWithBank
            // 
            this.errorProviderWithBank.ContainerControl = this;
            // 
            // TextBoxName
            // 
            this.TextBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(160, 145);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(216, 27);
            this.TextBoxName.TabIndex = 166;
            this.TextBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxName_Validating);
            this.TextBoxName.Validated += new System.EventHandler(this.TextBoxName_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 22);
            this.label9.TabIndex = 174;
            this.label9.Text = "ADDRESS 1";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(184, 8);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(384, 27);
            this.TextBoxSearch.TabIndex = 176;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 173;
            this.label7.Text = "PROJECT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(406, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 22);
            this.label8.TabIndex = 172;
            this.label8.Text = "ADDRESS 3";
            // 
            // TextBoxIqama
            // 
            this.TextBoxIqama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxIqama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxIqama.Location = new System.Drawing.Point(160, 82);
            this.TextBoxIqama.Name = "TextBoxIqama";
            this.TextBoxIqama.Size = new System.Drawing.Size(216, 27);
            this.TextBoxIqama.TabIndex = 164;
            this.TextBoxIqama.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxIqama_Validating);
            this.TextBoxIqama.Validated += new System.EventHandler(this.TextBoxIqama_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 168;
            this.label4.Text = "BANK CODE";
            // 
            // WBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 550);
            this.Controls.Add(this.dataGridViewWBank);
            this.Controls.Add(this.ComboBoxStatusW);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxAddress3);
            this.Controls.Add(this.textBoxAddress2);
            this.Controls.Add(this.textBoxAddress1);
            this.Controls.Add(this.textBoxProject);
            this.Controls.Add(this.textBoxBankCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxBatchNo);
            this.Controls.Add(this.TextBoxBankAcctNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxIqama);
            this.Controls.Add(this.label4);
            this.Name = "WBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WBank";
            this.Load += new System.EventHandler(this.WBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWithBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWBank;
        private System.Windows.Forms.ComboBox ComboBoxStatusW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAddress3;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.TextBox textBoxProject;
        private System.Windows.Forms.TextBox textBoxBankCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonNew;
        public System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxBatchNo;
        private System.Windows.Forms.TextBox TextBoxBankAcctNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderWithBank;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxIqama;
        private System.Windows.Forms.Label label4;
    }
}