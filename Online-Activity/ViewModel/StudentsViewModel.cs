using Online_Activity.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Activity.ViewModel
{
    public class StudentsViewModel
    {
        public ObservableCollection<Students> Students { get; set; }

        public StudentsViewModel()
        {
            // Initialize collection with at least 5 student records
            Students = new ObservableCollection<Students>
            {
                new Students
                {
                    StudentID = 1,
                    FirstName = "Kirk Justine",
                    LastName = "Cimafranca",
                    YearLevel = 2,
                    Program = "BSIT",
                    ContactNumber = 09234234423
                },
                new Students
                {
                    StudentID = 2,
                    FirstName = "Marven",
                    LastName = "Bas",
                    YearLevel = 1,
                    Program = "BSCS",
                    ContactNumber = 09123456789
                },
                new Students
                {
                    StudentID = 3,
                    FirstName = "Carlo",
                    LastName = "Aquino",
                    YearLevel = 3,
                    Program = "BSIT",
                    ContactNumber = 09987654321
                },
                new Students
                {
                    StudentID = 4,
                    FirstName = "Ana",
                    LastName = "Garcia",
                    YearLevel = 2,
                    Program = "BSCS",
                    ContactNumber = 09555666777
                },
                new Students
                {
                    StudentID = 5,
                    FirstName = "Anne",
                    LastName = "Fernandez",
                    YearLevel = 4,
                    Program = "BSIT",
                    ContactNumber = 09888999000
                }
            };
        }
    }
}
