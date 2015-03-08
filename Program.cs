using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumeAdmin.Data;

namespace ResumeAdminConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ResumeDbContext();
            var resumes = db.Resumes.ToList();
        }
    }
}
