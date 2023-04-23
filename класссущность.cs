using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr44
{
    public partial class Course
    {
        public int Idd { get; set; }
        public int Courss { get; set; }
        public Course()
        {
            this.Semestrr = new HashSet<Semestrr>();
        }
        public virtual ICollection<Semestrr> Semestrr { get; set; }
    }
    public partial class Semestrr 
    {
        public int Idd { get; set; }
        public string Studentt { get; set; }
        public int Courss { get; set; } 
        public string Attestaciaa { get; set; }
        public string Groupaa { get; set; }

        public virtual Course Course1 { get; set; }
    }
}
