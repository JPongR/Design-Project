﻿namespace Despro
{
    partial class loginDatabase
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.accountButton = new System.Windows.Forms.Button();
            this.deviceButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.desproDatabaseDataSet2 = new Despro.desproDatabaseDataSet2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desproDatabaseDataSetAdmin = new Despro.desproDatabaseDataSetAdmin();
            this.adminTableAdapter = new Despro.desproDatabaseDataSetAdminTableAdapters.adminTableAdapter();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Despro.desproDatabaseDataSet2TableAdapters.loginTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.exportButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.givenNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desproDatabaseDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desproDatabaseDataSetAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.label1);
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(800, 51);
            this.titlePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "DESPRO TITLE HERE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 51);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.accountButton);
            this.menuPanel.Controls.Add(this.deviceButton);
            this.menuPanel.Controls.Add(this.loginButton);
            this.menuPanel.Controls.Add(this.studentButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 51);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(182, 399);
            this.menuPanel.TabIndex = 1;
            // 
            // accountButton
            // 
            this.accountButton.BackColor = System.Drawing.Color.IndianRed;
            this.accountButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountButton.Enabled = false;
            this.accountButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountButton.Location = new System.Drawing.Point(0, 300);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(182, 100);
            this.accountButton.TabIndex = 3;
            this.accountButton.Text = "Accounts";
            this.accountButton.UseVisualStyleBackColor = false;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // deviceButton
            // 
            this.deviceButton.BackColor = System.Drawing.Color.IndianRed;
            this.deviceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deviceButton.Enabled = false;
            this.deviceButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceButton.Location = new System.Drawing.Point(0, 200);
            this.deviceButton.Name = "deviceButton";
            this.deviceButton.Size = new System.Drawing.Size(182, 100);
            this.deviceButton.TabIndex = 2;
            this.deviceButton.Text = "Device Database";
            this.deviceButton.UseVisualStyleBackColor = false;
            this.deviceButton.Click += new System.EventHandler(this.deviceButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.IndianRed;
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginButton.Enabled = false;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(0, 100);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(182, 100);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login Database";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.BackColor = System.Drawing.Color.IndianRed;
            this.studentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentButton.Enabled = false;
            this.studentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentButton.Location = new System.Drawing.Point(0, 0);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(182, 100);
            this.studentButton.TabIndex = 0;
            this.studentButton.Text = "Student Database";
            this.studentButton.UseVisualStyleBackColor = false;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.panel2);
            this.bodyPanel.Controls.Add(this.panel1);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(182, 51);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(618, 399);
            this.bodyPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 360);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.givenNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.studentNumberDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.collegeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.entranceDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn,
            this.exitDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(618, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // loginBindingSource1
            // 
            this.loginBindingSource1.DataMember = "login";
            this.loginBindingSource1.DataSource = this.desproDatabaseDataSet2;
            // 
            // desproDatabaseDataSet2
            // 
            this.desproDatabaseDataSet2.DataSetName = "desproDatabaseDataSet2";
            this.desproDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 39);
            this.panel1.TabIndex = 1;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            this.adminBindingSource.DataSource = this.desproDatabaseDataSetAdmin;
            // 
            // desproDatabaseDataSetAdmin
            // 
            this.desproDatabaseDataSetAdmin.DataSetName = "desproDatabaseDataSetAdmin";
            this.desproDatabaseDataSetAdmin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.desproDatabaseDataSet2;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 40);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(150, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(468, 40);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.exportButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(311, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(157, 40);
            this.panel7.TabIndex = 2;
            // 
            // exportButton
            // 
            this.exportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportButton.Location = new System.Drawing.Point(0, 0);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(157, 40);
            this.exportButton.TabIndex = 0;
            this.exportButton.Text = "EXPORT";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.deleteButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(154, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(157, 40);
            this.panel6.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(0, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(157, 40);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.editButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(154, 40);
            this.panel5.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.Location = new System.Drawing.Point(0, 0);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(154, 40);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.addButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(150, 40);
            this.panel8.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 40);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 83;
            // 
            // givenNameDataGridViewTextBoxColumn
            // 
            this.givenNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.givenNameDataGridViewTextBoxColumn.DataPropertyName = "givenName";
            this.givenNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.givenNameDataGridViewTextBoxColumn.Name = "givenNameDataGridViewTextBoxColumn";
            this.givenNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.givenNameDataGridViewTextBoxColumn.Width = 82;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "middleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.middleNameDataGridViewTextBoxColumn.Width = 94;
            // 
            // studentNumberDataGridViewTextBoxColumn
            // 
            this.studentNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.studentNumberDataGridViewTextBoxColumn.DataPropertyName = "studentNumber";
            this.studentNumberDataGridViewTextBoxColumn.HeaderText = "Student Number";
            this.studentNumberDataGridViewTextBoxColumn.Name = "studentNumberDataGridViewTextBoxColumn";
            this.studentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseDataGridViewTextBoxColumn.Width = 65;
            // 
            // collegeDataGridViewTextBoxColumn
            // 
            this.collegeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.collegeDataGridViewTextBoxColumn.DataPropertyName = "college";
            this.collegeDataGridViewTextBoxColumn.HeaderText = "College";
            this.collegeDataGridViewTextBoxColumn.Name = "collegeDataGridViewTextBoxColumn";
            this.collegeDataGridViewTextBoxColumn.ReadOnly = true;
            this.collegeDataGridViewTextBoxColumn.Width = 67;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date Recorded";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 96;
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            this.timeInDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeInDataGridViewTextBoxColumn.DataPropertyName = "timeIn";
            this.timeInDataGridViewTextBoxColumn.HeaderText = "Time In";
            this.timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            this.timeInDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeInDataGridViewTextBoxColumn.Width = 62;
            // 
            // entranceDataGridViewTextBoxColumn
            // 
            this.entranceDataGridViewTextBoxColumn.DataPropertyName = "entrance";
            this.entranceDataGridViewTextBoxColumn.HeaderText = "Entry Point";
            this.entranceDataGridViewTextBoxColumn.Name = "entranceDataGridViewTextBoxColumn";
            this.entranceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "timeOut";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "Time Out";
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            this.timeOutDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeOutDataGridViewTextBoxColumn.Width = 69;
            // 
            // exitDataGridViewTextBoxColumn
            // 
            this.exitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.exitDataGridViewTextBoxColumn.DataPropertyName = "exit";
            this.exitDataGridViewTextBoxColumn.HeaderText = "Exit Point";
            this.exitDataGridViewTextBoxColumn.Name = "exitDataGridViewTextBoxColumn";
            this.exitDataGridViewTextBoxColumn.ReadOnly = true;
            this.exitDataGridViewTextBoxColumn.Width = 70;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Bus Exit Point";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 89;
            // 
            // loginDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.titlePanel);
            this.Name = "loginDatabase";
            this.Text = "Login Database";
            this.Load += new System.EventHandler(this.loginDatabase_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desproDatabaseDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desproDatabaseDataSetAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.Button deviceButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private desproDatabaseDataSetAdmin desproDatabaseDataSetAdmin;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private desproDatabaseDataSetAdminTableAdapters.adminTableAdapter adminTableAdapter;
        private desproDatabaseDataSet2 desproDatabaseDataSet2;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private desproDatabaseDataSet2TableAdapters.loginTableAdapter loginTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource loginBindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn givenNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
    }
}