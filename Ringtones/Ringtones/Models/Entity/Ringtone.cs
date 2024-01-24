using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ringtones.Models.Entity
{
    public class Ringtone
    {
        public int RingtoneId { get; set; }
        public string Name { get; set; }

        public string FilePath { get; set; }

        public int CategoryId { get; set; }

        public int DurationInSeconds { get; set; }

        public string RelaseDate { get; set; }

        public string Descriptions { get; set; }
    }
}