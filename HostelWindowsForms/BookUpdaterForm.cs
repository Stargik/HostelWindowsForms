using HostelWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelWindowsForms
{
    public partial class BookUpdaterForm : Form
    {
        public RecordView OldRecordView { get; set; }
        public RecordView RecordView { get; private set; }
        public BookUpdaterForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = OldRecordView.FirstName;
            LastNameTextBox.Text = OldRecordView.LastName;
            SurNameTextBox.Text = OldRecordView.SurName;
            CourceLabelNumericUpDown.Value = OldRecordView.Course;
            DepartmentTextBox.Text = OldRecordView.Department;
            HouseAddressTextBox.Text = OldRecordView.HouseAddress;
            RoomNumberNumericUpDown.Value = OldRecordView.RoomNumber;
            FromDateDateTimePicker.Value = OldRecordView.FromDate;
            ToDateDateTimePicker.Value = OldRecordView.ToDate;
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!FormValidator.IsValid(FirstNameTextBox.Text, LastNameTextBox.Text, SurNameTextBox.Text, DepartmentTextBox.Text, HouseAddressTextBox.Text) || !FormValidator.IsDateValid(FromDateDateTimePicker.Value, ToDateDateTimePicker.Value))
            {
                ErrorLabel.Visible = true;
            }
            else
            {
                RecordView = new RecordView()
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    SurName = SurNameTextBox.Text,
                    Course = (int)CourceLabelNumericUpDown.Value,
                    Department = DepartmentTextBox.Text,
                    HouseAddress = HouseAddressTextBox.Text,
                    RoomNumber = (int)RoomNumberNumericUpDown.Value,
                    FromDate = FromDateDateTimePicker.Value,
                    ToDate = ToDateDateTimePicker.Value
                };
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
