using HostelWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelWindowsForms
{
    public partial class BookForm : Form
    {
        private BindingList<RecordView> recordViews;
        private Filter filter;
        public JsonService JsonService { get; set; }
        public BookForm()
        {
            InitializeComponent();
            JsonService = new JsonService(ConfigurationManager.AppSettings["filePath"]);
            recordViews = new BindingList<RecordView>();
            var records = JsonService.GetContent<Record>();
            recordViews = RecordMapper.MapperToRecordViews(records);
            filter = new Filter(recordViews);
            dataGridView1.DataSource = filter.FilteredRecordViews;
            filter.FilterCancel();
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
            var form = new BookCreatorForm();
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
                var form = new BookUpdaterForm()
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
            var records = RecordMapper.MapperToRecords(recordViews);
            JsonService.UpdateContent<Record>(records);
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
            var form = new BookInfoForm();
            form.ShowDialog();
        }
    }
}
