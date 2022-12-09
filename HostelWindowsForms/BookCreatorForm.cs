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
    public partial class BookCreatorForm : Form
    {
        public RecordView RecordView { get; private set; } 
        public BookCreatorForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
