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
    public partial class Form1 : Form
    {
        private BindingList<RecordView> recordViews;
        private Filter filter;
        public JsonService<Record> JsonService { get; set; }
        public Form1()
        {
            InitializeComponent();
            JsonService = new JsonService<Record>("HostelJson.json");
            recordViews = new BindingList<RecordView>();
            var records = JsonService.GetContent();
            recordViews = MapperToRecordViews(records);
            filter = new Filter(recordViews);
            dataGridView1.DataSource = filter.FilteredRecordViews;
            filter.FilterCancel();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!(dataGridView1.CurrentRow is null))
            {
                int index = dataGridView1.CurrentRow.Index;
                recordViews.RemoveAt(recordViews.IndexOf(filter.FilteredRecordViews[index]));
                filter.FilteredRecordViews.RemoveAt(index);
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            var res = form.ShowDialog();
            if (res == DialogResult.Yes)
            {
                filter.FilteredRecordViews.Add(form.RecordView);
                filter.RecordViews.Add(form.RecordView);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            if (!(dataGridView1.CurrentRow is null))
            {
                var form = new Form3()
                {
                    OldRecordView = filter.FilteredRecordViews[dataGridView1.CurrentRow.Index]
                };
                var res = form.ShowDialog();
                if (res == DialogResult.Yes)
                {
                    recordViews[recordViews.IndexOf(filter.FilteredRecordViews[dataGridView1.CurrentRow.Index])] = form.RecordView;
                    filter.FilteredRecordViews[dataGridView1.CurrentRow.Index] = form.RecordView;
                }
            }

            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var records = MapperToRecords(recordViews);
            JsonService.UpdateContent(records);
        }

        private List<Record> MapperToRecords(BindingList<RecordView> recordViews)
        {
            var records = new List<Record>();
            foreach (var item in recordViews)
            {
                var record = new Record
                {
                    Address = new Address { HouseAddress = item.HouseAddress, RoomNumber = item.RoomNumber },
                    Student = new Student { FirstName = item.FirstName, LastName = item.LastName, SurName = item.SurName, Course = item.Course, Department = item.Department },
                    FromDate = item.FromDate,
                    ToDate = item.ToDate
                };
                records.Add(record);
            }
            return records;
        }
        private BindingList<RecordView> MapperToRecordViews(List<Record> records)
        {
            var views = new BindingList<RecordView>();
            foreach (var item in records)
            {
                var recordView = new RecordView(item);
                views.Add(recordView);
            }
            return views;
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            filter.FilterCancel();
            if (SurNameFilterActivator.Checked)
            {
                filter.FilterBySurName(SurNameFilter.Text);
            }
            if (CourceFilterActivator.Checked)
            {
                filter.FilterByCource((int)CourceFilter.Value);
            }
            if (DateFilterActivator.Checked)
            {
                filter.FilterByDate(FromDateFilter.Value, ToDateFilter.Value);
            }
            dataGridView1.DataSource = filter.FilteredRecordViews;
        }

        private void GeneralInfoButton_Click(object sender, EventArgs e)
        {
            var form = new Form4();
            form.ShowDialog();
        }
    }
}
