using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Business
{
    public static class DomainEntities1
    {
        public static List<Appraisal> Appraisals { get; set; } = new List<Appraisal> {
                new Appraisal {EmployeeId = 1, Appraisee="Kiran", Appraiser="Varun", Rating=1 },
                new Appraisal {EmployeeId = 7, Appraisee="Jagadeesh", Appraiser="Suresh", Rating=3 },
                new Appraisal {EmployeeId = 9, Appraisee="Ananth", Appraiser="Prasanth", Rating=4 },
                new Appraisal {EmployeeId = 10, Appraisee="Ram", Appraiser="Krishna", Rating=1 }
            };
        public static List<Appraisal> GetAll()
        {
            return Appraisals;
        }

        public static Appraisal GetAppraisal(int id)
        {
            return Appraisals.Find(m => m.EmployeeId == id);
        }
    }

    public class DomainEntities2
    {
        public static List<Appraisal> Appraisals { get; set; } = new List<Appraisal> {
                new Appraisal {EmployeeId = 1, Appraisee="Kiran", Appraiser="Varun", Rating=1 },
                new Appraisal {EmployeeId = 7, Appraisee="Jagadeesh", Appraiser="Suresh", Rating=3 },
                new Appraisal {EmployeeId = 9, Appraisee="Ananth", Appraiser="Prasanth", Rating=4 },
                new Appraisal {EmployeeId = 10, Appraisee="Ram", Appraiser="Krishna", Rating=1 }
            };
        public static List<Appraisal> GetAll()
        {
            return Appraisals;
        }

        public static Appraisal GetAppraisal(int id)
        {
            return Appraisals.Find(m => m.EmployeeId == id);
        }
    }

    public class DomainEntities
    {
        private static DomainEntities _instance;
        private DomainEntities() { }

        public static DomainEntities Instance {
            get {
                if (_instance == null)
                {
                    _instance = new DomainEntities();
                }
                return _instance;
            }
        }
        public static List<Appraisal> Appraisals { get; set; } = new List<Appraisal> {
                new Appraisal {EmployeeId = 1, Appraisee="Kiran", Appraiser="Varun", Rating=1 },
                new Appraisal {EmployeeId = 7, Appraisee="Jagadeesh", Appraiser="Suresh", Rating=3 },
                new Appraisal {EmployeeId = 9, Appraisee="Ananth", Appraiser="Prasanth", Rating=4 },
                new Appraisal {EmployeeId = 10, Appraisee="Ram", Appraiser="Krishna", Rating=1 }
            };
        public List<Appraisal> GetAll()
        {
            return Appraisals;
        }

        public Appraisal GetAppraisal(int id)
        {
            return Appraisals.Find(m => m.EmployeeId == id);
        }
    }

    //crud
    //read

    //create
}