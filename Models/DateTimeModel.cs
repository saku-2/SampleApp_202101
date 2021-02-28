using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleApp_202101.Models
{
    public class DateTimeModel
    {
        [Key]
        public int TodoId { get; set; }

        [DisplayName("開始予定日")]
        public DateTime? StartDate { get; set; }

        [DisplayName("完了予定日")]
        public DateTime? EndDate1 { get; set; }

        [DisplayName("これからの予定=0、進行中=1、完了済=2、" +
            "復習１回目予定=3、復習２回目予定=4、4復習３回目予定=5、復習４回目予定=6、復習５回目予定=7")]
        public short TodoFlg { get; set; }

        [DisplayName("経過時間")]
        public DateTime? DoingTime { get; set; }

        [DisplayName("完了までの時間")]
        public DateTime? CompleteTime { get; set; }
    }
}