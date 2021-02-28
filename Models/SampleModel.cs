using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp_202101.Models
{
    public class SampleModel
    {
        [Key]
        public long SampleId { get; set; }

        [Required]
        [Display(Name = "RadioName")]
        public string RadioName { get; set; }

        public short TodoCategoryId { get; set; }
        public string TodoCategoryContents { get; set; }
        //public List<SelectListItem> TodoCategoryContentsList { get; set; }
        public IEnumerable<SelectListItem> TodoCategoryContentsList { get; set; }

    }
}