using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcBasic.Models
{
    public class MvcBasicContext: DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}