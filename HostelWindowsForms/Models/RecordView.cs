using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelWindowsForms.Models
{
    public class RecordView
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }
        public int Course { get; set; }
        public string Department { get; set; }
        public string HouseAddress { get; set; }
        public int RoomNumber { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public RecordView()
        {

        }
        public RecordView(Record record)
        {
            Id = Guid.NewGuid();
            FirstName = record.Student.FirstName;
            LastName = record.Student.LastName;
            SurName = record.Student.SurName;
            Course = record.Student.Course;
            Department = record.Student.Department;
            HouseAddress = record.Address.HouseAddress;
            RoomNumber = record.Address.RoomNumber;
            FromDate = record.FromDate;
            ToDate = record.ToDate;

        }
    }
}
