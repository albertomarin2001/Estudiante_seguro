using System.Data.Entity;

namespace admStudentSecurity.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<admStudentSecurity.Models.Student> Students { get; set; }
    }
}