using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class BaseEntity
    {
        
        public virtual int Id { get; set; }
        public DateTime Create_Date { get; set; }
        public DateTime Update_Date { get; set; }
    }
}
