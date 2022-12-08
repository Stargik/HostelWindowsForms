namespace HostelWindowsForms
{
    partial class Form3
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ToDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RoomNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CourceLabelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HouseAddressTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.SurNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.ToDateLabel = new System.Windows.Forms.Label();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.RoomNumberLabel = new System.Windows.Forms.Label();
            this.HouseAddressLabel = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.CourceLabel = new System.Windows.Forms.Label();
            this.SurNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoomNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourceLabelNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(125, 292);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 40;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(44, 292);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 39;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ToDateDateTimePicker
            // 
            this.ToDateDateTimePicker.Location = new System.Drawing.Point(146, 250);
            this.ToDateDateTimePicker.Name = "ToDateDateTimePicker";
            this.ToDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ToDateDateTimePicker.TabIndex = 38;
            // 
            // FromDateDateTimePicker
            // 
            this.FromDateDateTimePicker.Location = new System.Drawing.Point(146, 222);
            this.FromDateDateTimePicker.Name = "FromDateDateTimePicker";
            this.FromDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FromDateDateTimePicker.TabIndex = 37;
            // 
            // RoomNumberNumericUpDown
            // 
            this.RoomNumberNumericUpDown.Location = new System.Drawing.Point(146, 196);
            this.RoomNumberNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.RoomNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RoomNumberNumericUpDown.Name = "RoomNumberNumericUpDown";
            this.RoomNumberNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.RoomNumberNumericUpDown.TabIndex = 36;
            this.RoomNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CourceLabelNumericUpDown
            // 
            this.CourceLabelNumericUpDown.Location = new System.Drawing.Point(146, 113);
            this.CourceLabelNumericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.CourceLabelNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CourceLabelNumericUpDown.Name = "CourceLabelNumericUpDown";
            this.CourceLabelNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.CourceLabelNumericUpDown.TabIndex = 35;
            this.CourceLabelNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HouseAddressTextBox
            // 
            this.HouseAddressTextBox.Location = new System.Drawing.Point(146, 167);
            this.HouseAddressTextBox.Name = "HouseAddressTextBox";
            this.HouseAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.HouseAddressTextBox.TabIndex = 34;
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Location = new System.Drawing.Point(146, 141);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.Size = new System.Drawing.Size(200, 20);
            this.DepartmentTextBox.TabIndex = 33;
            // 
            // SurNameTextBox
            // 
            this.SurNameTextBox.Location = new System.Drawing.Point(146, 86);
            this.SurNameTextBox.Name = "SurNameTextBox";
            this.SurNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.SurNameTextBox.TabIndex = 32;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(146, 59);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.LastNameTextBox.TabIndex = 31;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(146, 33);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.FirstNameTextBox.TabIndex = 30;
            // 
            // ToDateLabel
            // 
            this.ToDateLabel.AutoSize = true;
            this.ToDateLabel.Location = new System.Drawing.Point(41, 256);
            this.ToDateLabel.Name = "ToDateLabel";
            this.ToDateLabel.Size = new System.Drawing.Size(43, 13);
            this.ToDateLabel.TabIndex = 29;
            this.ToDateLabel.Text = "ToDate";
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.AutoSize = true;
            this.FromDateLabel.Location = new System.Drawing.Point(41, 229);
            this.FromDateLabel.Name = "FromDateLabel";
            this.FromDateLabel.Size = new System.Drawing.Size(53, 13);
            this.FromDateLabel.TabIndex = 28;
            this.FromDateLabel.Text = "FromDate";
            // 
            // RoomNumberLabel
            // 
            this.RoomNumberLabel.AutoSize = true;
            this.RoomNumberLabel.Location = new System.Drawing.Point(41, 203);
            this.RoomNumberLabel.Name = "RoomNumberLabel";
            this.RoomNumberLabel.Size = new System.Drawing.Size(72, 13);
            this.RoomNumberLabel.TabIndex = 27;
            this.RoomNumberLabel.Text = "RoomNumber";
            // 
            // HouseAddressLabel
            // 
            this.HouseAddressLabel.AutoSize = true;
            this.HouseAddressLabel.Location = new System.Drawing.Point(41, 174);
            this.HouseAddressLabel.Name = "HouseAddressLabel";
            this.HouseAddressLabel.Size = new System.Drawing.Size(76, 13);
            this.HouseAddressLabel.TabIndex = 26;
            this.HouseAddressLabel.Text = "HouseAddress";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(41, 148);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(62, 13);
            this.DepartmentLabel.TabIndex = 25;
            this.DepartmentLabel.Text = "Department";
            // 
            // CourceLabel
            // 
            this.CourceLabel.AutoSize = true;
            this.CourceLabel.Location = new System.Drawing.Point(41, 120);
            this.CourceLabel.Name = "CourceLabel";
            this.CourceLabel.Size = new System.Drawing.Size(40, 13);
            this.CourceLabel.TabIndex = 24;
            this.CourceLabel.Text = "Course";
            // 
            // SurNameLabel
            // 
            this.SurNameLabel.AutoSize = true;
            this.SurNameLabel.Location = new System.Drawing.Point(41, 93);
            this.SurNameLabel.Name = "SurNameLabel";
            this.SurNameLabel.Size = new System.Drawing.Size(51, 13);
            this.SurNameLabel.TabIndex = 23;
            this.SurNameLabel.Text = "SurName";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(41, 66);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(55, 13);
            this.LastNameLabel.TabIndex = 22;
            this.LastNameLabel.Text = "LastName";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(41, 40);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FirstNameLabel.TabIndex = 21;
            this.FirstNameLabel.Text = "FirstName";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorLabel.Location = new System.Drawing.Point(44, 335);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(152, 30);
            this.ErrorLabel.TabIndex = 41;
            this.ErrorLabel.Text = "Incorrect value";
            this.ErrorLabel.UseCompatibleTextRendering = true;
            this.ErrorLabel.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ToDateDateTimePicker);
            this.Controls.Add(this.FromDateDateTimePicker);
            this.Controls.Add(this.RoomNumberNumericUpDown);
            this.Controls.Add(this.CourceLabelNumericUpDown);
            this.Controls.Add(this.HouseAddressTextBox);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.SurNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.ToDateLabel);
            this.Controls.Add(this.FromDateLabel);
            this.Controls.Add(this.RoomNumberLabel);
            this.Controls.Add(this.HouseAddressLabel);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.CourceLabel);
            this.Controls.Add(this.SurNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "Form3";
            this.Text = "BookUpdater";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourceLabelNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.DateTimePicker ToDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDateDateTimePicker;
        private System.Windows.Forms.NumericUpDown RoomNumberNumericUpDown;
        private System.Windows.Forms.NumericUpDown CourceLabelNumericUpDown;
        private System.Windows.Forms.TextBox HouseAddressTextBox;
        private System.Windows.Forms.TextBox DepartmentTextBox;
        private System.Windows.Forms.TextBox SurNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label ToDateLabel;
        private System.Windows.Forms.Label FromDateLabel;
        private System.Windows.Forms.Label RoomNumberLabel;
        private System.Windows.Forms.Label HouseAddressLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label CourceLabel;
        private System.Windows.Forms.Label SurNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}