using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleApp_202101.Models
{
    public class User
    {
        [Key]
        public long UserId { get; set; }

    }
}