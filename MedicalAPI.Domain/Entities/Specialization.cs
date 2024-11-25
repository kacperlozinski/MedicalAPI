﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAPI.Domain.Entities
{
    public class Specialization
    {
        [Key]
        public int SpecId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        /* public virtual Doctors Doctors { get; set; }*/

        public virtual ICollection<Doctor> Doctors { get; set; }

    }
}
