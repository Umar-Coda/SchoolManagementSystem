using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSDataLayer.Interfaces {
    public interface ISubjectRepository : IRepository<Subject> {
        public string FindDuplicateSubjectCode(string subjectCode);
        public Dictionary<string, string> GetSubjectGridData();
        public HashSet<string> GetSubjectCodes();
    }
}
