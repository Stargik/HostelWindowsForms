using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelWindowsForms.Models;

namespace HostelWindowsForms
{
    public class Filter
    {
        public BindingList<RecordView> RecordViews { get; set; } 
        public BindingList<RecordView> FilteredRecordViews { get; set; }
        public Filter(BindingList<RecordView> recordViews)
        {
            this.RecordViews = recordViews;
            FilteredRecordViews = recordViews;
        }
        public void FilterBySurName(string surname)
        {
            FilteredRecordViews = new BindingList<RecordView>(FilteredRecordViews.Where(r => r.SurName.ToLower().Contains(surname.ToLower())).ToList());
        }
        public void FilterByCource(int cource)
        {
            FilteredRecordViews = new BindingList<RecordView>(FilteredRecordViews.Where(r => r.Course == cource).ToList());
        }
        public void FilterByDate(DateTime from, DateTime to)
        {
            FilteredRecordViews = new BindingList<RecordView>(FilteredRecordViews.Where(r => r.FromDate >= from && r.ToDate <= to).ToList());
        }
        public void FilterCancel()
        {
            FilteredRecordViews = new BindingList<RecordView>(RecordViews.ToList());
        }

    }
}
