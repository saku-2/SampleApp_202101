using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApp_202101.Models
{
    public class 口座
    {
        public string 口座番号 { get; set; }
        public string 名義 { get; set; }
        public short 種別 { get; set; }
        public int 残高 { get; set; }
        public DateTime? 更新日 { get; set; }
    }
}