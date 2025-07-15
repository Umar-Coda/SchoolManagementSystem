using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SMSModels.Models {
    public class Attendance {
        public int AttendanceId { get; set; }
        public string Status { get; set; } = string.Empty;

        // Related Tables
        public int TimetableId { get; set; }
        public Timetable? Timetable { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
