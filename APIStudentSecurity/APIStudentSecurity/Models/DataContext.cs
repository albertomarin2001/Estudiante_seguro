﻿

namespace APIStudentSecurity.Models
{
    using System.Data.Entity;
    public class DataContext: DbContext
    {
        public DataContext():base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<APIStudentSecurity.Models.Student> Students { get; set; }
    }
}