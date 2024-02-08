using Kodlama.io_Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Project.Entities.Concrete
{

    //Çıplak class kalmasın.
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Course> Courses { get; set; }
    }

}
