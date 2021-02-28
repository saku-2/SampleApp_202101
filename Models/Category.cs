using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleApp_202101.Models
{
    /// <summary>
    /// カテゴリーモデル
    /// </summary>
    public class Category
    {
        [Key]
        public long CategoryId { get; set; }

        [DisplayName("カテゴリーの内容")]
        public string TodoCategoryContents { get; set; }

        public long UserId { get; set; }

    }
}