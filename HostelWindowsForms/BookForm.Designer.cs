namespace HostelWindowsForms
{
    partial class BookForm
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
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SurNameFilter = new System.Windows.Forms.TextBox();
            this.CourceFilter = new System.Windows.Forms.NumericUpDown();
            this.FromDateFilter = new System.Windows.Forms.DateTimePicker();
            this.ToDateFilter = new System.Windows.Forms.DateTimePicker();
            this.SurNameLabel = new System.Windows.Forms.Label();
            this.CourceLabel = new System.Windows.Forms.Label();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.ToDateLabel = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SurNameFilterActivator = new System.Windows.Forms.CheckBox();
            this.CourceFilterActivator = new System.Windows.Forms.CheckBox();
            this.DateFilterActivator = new System.Windows.Forms.CheckBox();
            this.GeneralInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourceFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.surNameDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.houseAddressDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.fromDateDataGridViewTextBoxColumn,
            this.toDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recordViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1372, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            this.surNameDataGridViewTextBoxColumn.HeaderText = "SurName";
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // houseAddressDataGridViewTextBoxColumn
            // 
            this.houseAddressDataGridViewTextBoxColumn.DataPropertyName = "HouseAddress";
            this.houseAddressDataGridViewTextBoxColumn.HeaderText = "HouseAddress";
            this.houseAddressDataGridViewTextBoxColumn.Name = "houseAddressDataGridViewTextBoxColumn";
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // fromDateDataGridViewTextBoxColumn
            // 
            this.fromDateDataGridViewTextBoxColumn.DataPropertyName = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.HeaderText = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.Name = "fromDateDataGridViewTextBoxColumn";
            // 
            // toDateDataGridViewTextBoxColumn
            // 
            this.toDateDataGridViewTextBoxColumn.DataPropertyName = "ToDate";
            this.toDateDataGridViewTextBoxColumn.HeaderText = "ToDate";
            this.toDateDataGridViewTextBoxColumn.Name = "toDateDataGridViewTextBoxColumn";
            // 
            // recordViewBindingSource
            // 
            this.recordViewBindingSource.DataSource = typeof(HostelWindowsForms.Models.RecordView);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(174, 198);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 198);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(93, 198);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(255, 198);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SurNameFilter
            // 
            this.SurNameFilter.Location = new System.Drawing.Point(66, 268);
            this.SurNameFilter.Name = "SurNameFilter";
            this.SurNameFilter.Size = new System.Drawing.Size(200, 20);
            this.SurNameFilter.TabIndex = 6;
            // 
            // CourceFilter
            // 
            this.CourceFilter.Location = new System.Drawing.Point(66, 295);
            this.CourceFilter.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.CourceFilter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CourceFilter.Name = "CourceFilter";
            this.CourceFilter.Size = new System.Drawing.Size(200, 20);
            this.CourceFilter.TabIndex = 7;
            this.CourceFilter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FromDateFilter
            // 
            this.FromDateFilter.Location = new System.Drawing.Point(66, 323);
            this.FromDateFilter.Name = "FromDateFilter";
            this.FromDateFilter.Size = new System.Drawing.Size(200, 20);
            this.FromDateFilter.TabIndex = 8;
            // 
            // ToDateFilter
            // 
            this.ToDateFilter.Location = new System.Drawing.Point(66, 350);
            this.ToDateFilter.Name = "ToDateFilter";
            this.ToDateFilter.Size = new System.Drawing.Size(200, 20);
            this.ToDateFilter.TabIndex = 9;
            // 
            // SurNameLabel
            // 
            this.SurNameLabel.AutoSize = true;
            this.SurNameLabel.Location = new System.Drawing.Point(12, 275);
            this.SurNameLabel.Name = "SurNameLabel";
            this.SurNameLabel.Size = new System.Drawing.Size(51, 13);
            this.SurNameLabel.TabIndex = 10;
            this.SurNameLabel.Text = "SurName";
            // 
            // CourceLabel
            // 
            this.CourceLabel.AutoSize = true;
            this.CourceLabel.Location = new System.Drawing.Point(12, 302);
            this.CourceLabel.Name = "CourceLabel";
            this.CourceLabel.Size = new System.Drawing.Size(41, 13);
            this.CourceLabel.TabIndex = 11;
            this.CourceLabel.Text = "Cource";
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.AutoSize = true;
            this.FromDateLabel.Location = new System.Drawing.Point(12, 330);
            this.FromDateLabel.Name = "FromDateLabel";
            this.FromDateLabel.Size = new System.Drawing.Size(30, 13);
            this.FromDateLabel.TabIndex = 12;
            this.FromDateLabel.Text = "From";
            // 
            // ToDateLabel
            // 
            this.ToDateLabel.AutoSize = true;
            this.ToDateLabel.Location = new System.Drawing.Point(12, 356);
            this.ToDateLabel.Name = "ToDateLabel";
            this.ToDateLabel.Size = new System.Drawing.Size(20, 13);
            this.ToDateLabel.TabIndex = 13;
            this.ToDateLabel.Text = "To";
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(12, 380);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(254, 23);
            this.FilterButton.TabIndex = 14;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // SurNameFilterActivator
            // 
            this.SurNameFilterActivator.AutoSize = true;
            this.SurNameFilterActivator.Location = new System.Drawing.Point(272, 270);
            this.SurNameFilterActivator.Name = "SurNameFilterActivator";
            this.SurNameFilterActivator.Size = new System.Drawing.Size(45, 17);
            this.SurNameFilterActivator.TabIndex = 15;
            this.SurNameFilterActivator.Text = "Add";
            this.SurNameFilterActivator.UseVisualStyleBackColor = true;
            // 
            // CourceFilterActivator
            // 
            this.CourceFilterActivator.AutoSize = true;
            this.CourceFilterActivator.Location = new System.Drawing.Point(272, 298);
            this.CourceFilterActivator.Name = "CourceFilterActivator";
            this.CourceFilterActivator.Size = new System.Drawing.Size(45, 17);
            this.CourceFilterActivator.TabIndex = 16;
            this.CourceFilterActivator.Text = "Add";
            this.CourceFilterActivator.UseVisualStyleBackColor = true;
            // 
            // DateFilterActivator
            // 
            this.DateFilterActivator.AutoSize = true;
            this.DateFilterActivator.Location = new System.Drawing.Point(272, 339);
            this.DateFilterActivator.Name = "DateFilterActivator";
            this.DateFilterActivator.Size = new System.Drawing.Size(45, 17);
            this.DateFilterActivator.TabIndex = 17;
            this.DateFilterActivator.Text = "Add";
            this.DateFilterActivator.UseVisualStyleBackColor = true;
            // 
            // GeneralInfoButton
            // 
            this.GeneralInfoButton.Location = new System.Drawing.Point(336, 198);
            this.GeneralInfoButton.Name = "GeneralInfoButton";
            this.GeneralInfoButton.Size = new System.Drawing.Size(254, 23);
            this.GeneralInfoButton.TabIndex = 18;
            this.GeneralInfoButton.Text = "General information";
            this.GeneralInfoButton.UseVisualStyleBackColor = true;
            this.GeneralInfoButton.Click += new System.EventHandler(this.GeneralInfoButton_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 654);
            this.Controls.Add(this.GeneralInfoButton);
            this.Controls.Add(this.DateFilterActivator);
            this.Controls.Add(this.CourceFilterActivator);
            this.Controls.Add(this.SurNameFilterActivator);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.ToDateLabel);
            this.Controls.Add(this.FromDateLabel);
            this.Controls.Add(this.CourceLabel);
            this.Controls.Add(this.SurNameLabel);
            this.Controls.Add(this.ToDateFilter);
            this.Controls.Add(this.FromDateFilter);
            this.Controls.Add(this.CourceFilter);
            this.Controls.Add(this.SurNameFilter);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookForm";
            this.Text = "Book";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourceFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recordViewBindingSource;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SurNameFilter;
        private System.Windows.Forms.NumericUpDown CourceFilter;
        private System.Windows.Forms.DateTimePicker FromDateFilter;
        private System.Windows.Forms.DateTimePicker ToDateFilter;
        private System.Windows.Forms.Label SurNameLabel;
        private System.Windows.Forms.Label CourceLabel;
        private System.Windows.Forms.Label FromDateLabel;
        private System.Windows.Forms.Label ToDateLabel;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.CheckBox SurNameFilterActivator;
        private System.Windows.Forms.CheckBox CourceFilterActivator;
        private System.Windows.Forms.CheckBox DateFilterActivator;
        private System.Windows.Forms.Button GeneralInfoButton;
    }
}

