using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Ringtones.Models.Entity;

namespace Ringtones.Models.Entity
{
    public class Context:DbContext
    {
        public DbSet<Ringtone> Ringtones { get; set; }


        }
    }
