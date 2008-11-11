﻿namespace VGUILocalizationTool
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnglishTextChanged = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEnglish = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbUseSlashN = new System.Windows.Forms.CheckBox();
            this.cbSaveWithEnglish = new System.Windows.Forms.CheckBox();
            this.cbDontSaveNotLocalized = new System.Windows.Forms.CheckBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPerc = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btFind = new System.Windows.Forms.Button();
            this.localizationDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.englishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localizationDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.englishDataGridViewTextBoxColumn,
            this.EnglishTextChanged,
            this.localizedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.localizationDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(832, 244);
            this.dataGridView1.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // EnglishTextChanged
            // 
            this.EnglishTextChanged.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EnglishTextChanged.DataPropertyName = "EnglishTextChanged";
            this.EnglishTextChanged.FillWeight = 40F;
            this.EnglishTextChanged.HeaderText = "English Text Changed";
            this.EnglishTextChanged.Name = "EnglishTextChanged";
            this.EnglishTextChanged.Width = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "English";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Localized";
            // 
            // tbEnglish
            // 
            this.tbEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEnglish.Location = new System.Drawing.Point(105, 9);
            this.tbEnglish.Name = "tbEnglish";
            this.tbEnglish.ReadOnly = true;
            this.tbEnglish.Size = new System.Drawing.Size(658, 22);
            this.tbEnglish.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(769, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 24);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbLocal
            // 
            this.cbLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Location = new System.Drawing.Point(103, 43);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(579, 24);
            this.cbLocal.TabIndex = 4;
            this.cbLocal.SelectedIndexChanged += new System.EventHandler(this.cbLocal_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(688, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 27);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(769, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btFind);
            this.panel1.Controls.Add(this.cbUseSlashN);
            this.panel1.Controls.Add(this.cbSaveWithEnglish);
            this.panel1.Controls.Add(this.cbDontSaveNotLocalized);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblPerc);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 211);
            this.panel1.TabIndex = 0;
            // 
            // cbUseSlashN
            // 
            this.cbUseSlashN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUseSlashN.AutoSize = true;
            this.cbUseSlashN.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.localizationDataBindingSource, "UseSlashN", true));
            this.cbUseSlashN.Location = new System.Drawing.Point(749, 179);
            this.cbUseSlashN.Name = "cbUseSlashN";
            this.cbUseSlashN.Size = new System.Drawing.Size(71, 21);
            this.cbUseSlashN.TabIndex = 5;
            this.cbUseSlashN.Text = "Use \\n";
            this.cbUseSlashN.UseVisualStyleBackColor = true;
            // 
            // cbSaveWithEnglish
            // 
            this.cbSaveWithEnglish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSaveWithEnglish.AutoSize = true;
            this.cbSaveWithEnglish.Location = new System.Drawing.Point(473, 9);
            this.cbSaveWithEnglish.Name = "cbSaveWithEnglish";
            this.cbSaveWithEnglish.Size = new System.Drawing.Size(165, 21);
            this.cbSaveWithEnglish.TabIndex = 6;
            this.cbSaveWithEnglish.Text = "Save with english text";
            this.cbSaveWithEnglish.UseVisualStyleBackColor = true;
            // 
            // cbDontSaveNotLocalized
            // 
            this.cbDontSaveNotLocalized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDontSaveNotLocalized.AutoSize = true;
            this.cbDontSaveNotLocalized.Location = new System.Drawing.Point(644, 9);
            this.cbDontSaveNotLocalized.Name = "cbDontSaveNotLocalized";
            this.cbDontSaveNotLocalized.Size = new System.Drawing.Size(180, 21);
            this.cbDontSaveNotLocalized.TabIndex = 7;
            this.cbDontSaveNotLocalized.Text = "Don\'t save not localized";
            this.cbDontSaveNotLocalized.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.localizationDataBindingSource, "ID", true));
            this.lblID.Location = new System.Drawing.Point(15, 10);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(452, 17);
            this.lblID.TabIndex = 0;
            // 
            // lblPerc
            // 
            this.lblPerc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerc.Location = new System.Drawing.Point(754, 142);
            this.lblPerc.Name = "lblPerc";
            this.lblPerc.Size = new System.Drawing.Size(65, 17);
            this.lblPerc.TabIndex = 9;
            this.lblPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(749, 67);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.localizationDataBindingSource, "Localized", true));
            this.textBox2.Location = new System.Drawing.Point(91, 122);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(652, 78);
            this.textBox2.TabIndex = 4;
            this.textBox2.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Localized";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "English";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.localizationDataBindingSource, "English", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBox1.Location = new System.Drawing.Point(91, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(652, 78);
            this.textBox1.TabIndex = 2;
            this.textBox1.WordWrap = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "English text|*_english.txt|All files|*.txt *.res";
            this.openFileDialog1.InitialDirectory = global::VGUILocalizationTool.Properties.Settings.Default.InitialDir;
            // 
            // btFind
            // 
            this.btFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFind.Location = new System.Drawing.Point(749, 38);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 8;
            this.btFind.Text = "Find...";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // localizationDataBindingSource
            // 
            this.localizationDataBindingSource.AllowNew = false;
            this.localizationDataBindingSource.DataSource = typeof(VGUILocalizationTool.LocalizationData);
            // 
            // englishDataGridViewTextBoxColumn
            // 
            this.englishDataGridViewTextBoxColumn.DataPropertyName = "English";
            this.englishDataGridViewTextBoxColumn.FillWeight = 67.47509F;
            this.englishDataGridViewTextBoxColumn.HeaderText = "English";
            this.englishDataGridViewTextBoxColumn.Name = "englishDataGridViewTextBoxColumn";
            this.englishDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localizedDataGridViewTextBoxColumn
            // 
            this.localizedDataGridViewTextBoxColumn.DataPropertyName = "Localized";
            this.localizedDataGridViewTextBoxColumn.FillWeight = 67.47509F;
            this.localizedDataGridViewTextBoxColumn.HeaderText = "Localized";
            this.localizedDataGridViewTextBoxColumn.Name = "localizedDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbLocal);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbEnglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "VGUI Localization Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localizationDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEnglish;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource localizationDataBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPerc;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.CheckBox cbDontSaveNotLocalized;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EnglishTextChanged;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizedDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox cbSaveWithEnglish;
        private System.Windows.Forms.CheckBox cbUseSlashN;
        private System.Windows.Forms.Button btFind;
    }
}

