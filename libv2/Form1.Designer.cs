namespace libv2
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
            this.ChkL = new System.Windows.Forms.CheckedListBox();
            this.txtBookNameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvSearch = new System.Windows.Forms.DataGridView();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.cmbUserList = new System.Windows.Forms.ComboBox();
            this.btnBookConfirm = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnSeachDate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvCredit = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.cmbCreditUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpCredit = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // ChkL
            // 
            this.ChkL.FormattingEnabled = true;
            this.ChkL.Location = new System.Drawing.Point(17, 302);
            this.ChkL.Name = "ChkL";
            this.ChkL.Size = new System.Drawing.Size(660, 94);
            this.ChkL.TabIndex = 1;
            // 
            // txtBookNameSearch
            // 
            this.txtBookNameSearch.Location = new System.Drawing.Point(17, 57);
            this.txtBookNameSearch.Name = "txtBookNameSearch";
            this.txtBookNameSearch.Size = new System.Drawing.Size(224, 20);
            this.txtBookNameSearch.TabIndex = 2;
            this.txtBookNameSearch.TextChanged += new System.EventHandler(this.txtBookNameSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Axtarış";
            // 
            // DgvSearch
            // 
            this.DgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvSearch.Location = new System.Drawing.Point(17, 96);
            this.DgvSearch.Name = "DgvSearch";
            this.DgvSearch.Size = new System.Drawing.Size(660, 136);
            this.DgvSearch.TabIndex = 4;
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.Location = new System.Drawing.Point(17, 251);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(75, 23);
            this.BtnAddBook.TabIndex = 5;
            this.BtnAddBook.Text = "Əlavə et";
            this.BtnAddBook.UseVisualStyleBackColor = true;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // cmbUserList
            // 
            this.cmbUserList.FormattingEnabled = true;
            this.cmbUserList.Location = new System.Drawing.Point(226, 251);
            this.cmbUserList.Name = "cmbUserList";
            this.cmbUserList.Size = new System.Drawing.Size(342, 21);
            this.cmbUserList.TabIndex = 6;
            this.cmbUserList.Click += new System.EventHandler(this.cmbUserList_Click);
            // 
            // btnBookConfirm
            // 
            this.btnBookConfirm.Location = new System.Drawing.Point(17, 411);
            this.btnBookConfirm.Name = "btnBookConfirm";
            this.btnBookConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnBookConfirm.TabIndex = 7;
            this.btnBookConfirm.Text = "Təsdiqlə";
            this.btnBookConfirm.UseVisualStyleBackColor = true;
            this.btnBookConfirm.Click += new System.EventHandler(this.btnBookConfirm_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(578, 249);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(98, 23);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Yeni istifadəçi";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.ChkL);
            this.panel1.Controls.Add(this.btnBookConfirm);
            this.panel1.Controls.Add(this.txtBookNameSearch);
            this.panel1.Controls.Add(this.cmbUserList);
            this.panel1.Controls.Add(this.DgvSearch);
            this.panel1.Controls.Add(this.BtnAddBook);
            this.panel1.Location = new System.Drawing.Point(-2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 507);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnSearchUser);
            this.panel2.Controls.Add(this.btnSeachDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.DgvCredit);
            this.panel2.Controls.Add(this.txtIncrement);
            this.panel2.Controls.Add(this.cmbCreditUsers);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DtpCredit);
            this.panel2.Location = new System.Drawing.Point(707, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 507);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.btnReturn);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(15, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 100);
            this.panel3.TabIndex = 10;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(260, 52);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(149, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Seçilmiş kitabları qaytar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(245, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kitablaın qaytarılması";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(309, 160);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(127, 23);
            this.btnSearchUser.TabIndex = 9;
            this.btnSearchUser.Text = "Istifadəçiyə görə axtar";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnSeachDate
            // 
            this.btnSeachDate.Location = new System.Drawing.Point(15, 160);
            this.btnSeachDate.Name = "btnSeachDate";
            this.btnSeachDate.Size = new System.Drawing.Size(137, 23);
            this.btnSeachDate.TabIndex = 8;
            this.btnSeachDate.Text = "Tarixə görə axtar";
            this.btnSeachDate.UseVisualStyleBackColor = true;
            this.btnSeachDate.Click += new System.EventHandler(this.btnSeachDate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(306, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "İstifadəçiyə görə axtarış";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(208, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gün qalıb:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarixə görə axtarış";
            // 
            // DgvCredit
            // 
            this.DgvCredit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCredit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCredit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column14});
            this.DgvCredit.Location = new System.Drawing.Point(15, 200);
            this.DgvCredit.Name = "DgvCredit";
            this.DgvCredit.Size = new System.Drawing.Size(665, 150);
            this.DgvCredit.TabIndex = 4;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "id";
            this.Column13.Name = "Column13";
            this.Column13.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ad";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Soyad";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Telefon";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Kitabın adı";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Qaytarılma tarixi";
            this.Column12.Name = "Column12";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Qiymət";
            this.Column14.Name = "Column14";
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(222, 124);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(22, 20);
            this.txtIncrement.TabIndex = 3;
            this.txtIncrement.Text = "0";
            // 
            // cmbCreditUsers
            // 
            this.cmbCreditUsers.FormattingEnabled = true;
            this.cmbCreditUsers.Location = new System.Drawing.Point(309, 122);
            this.cmbCreditUsers.Name = "cmbCreditUsers";
            this.cmbCreditUsers.Size = new System.Drawing.Size(277, 21);
            this.cmbCreditUsers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(245, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Götürülmüş kitabların axtarışı";
            // 
            // DtpCredit
            // 
            this.DtpCredit.Location = new System.Drawing.Point(15, 124);
            this.DtpCredit.Name = "DtpCredit";
            this.DtpCredit.Size = new System.Drawing.Size(200, 20);
            this.DtpCredit.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kitabın adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mərtəbə";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Şkaf";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Rəf";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Qiymət";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1399, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library v1.0 (By RuslanBerz & KamranMirzeyev)";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCredit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox ChkL;
        private System.Windows.Forms.TextBox txtBookNameSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvSearch;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.ComboBox cmbUserList;
        private System.Windows.Forms.Button btnBookConfirm;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIncrement;
        private System.Windows.Forms.ComboBox cmbCreditUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpCredit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvCredit;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnSeachDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

