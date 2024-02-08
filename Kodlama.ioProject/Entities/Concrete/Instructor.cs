using Kodlama.io_Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io_Project.Entities.Concrete
{
    public class Instructor : IEntity
    {
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<Course> Course { get; set; }
    }
}
