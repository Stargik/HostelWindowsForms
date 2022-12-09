using HostelWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelWindowsForms
{
    static class RecordMapper
    {
        public static List<Record> MapperToRecords(BindingList<RecordView> recordViews)
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
        public static BindingList<RecordView> MapperToRecordViews(List<Record> records)
        {
            var views = new BindingList<RecordView>();
            foreach (var item in records)
            {
                var recordView = new RecordView(item);
                views.Add(recordView);
            }
            return views;
        }
    }
}
