using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Base
    {
        public int Id { get; set; }
        public string Handle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeletionDate { get; set; }

        public bool IsDeleted()
        {
            return DeletionDate != null && DeletionDate < DateTime.Now;
        }
    }
}
