using System.Collections.Generic;
using System.Web.Mvc;

namespace SampleApp_202101.Models
{
    public class Sample2Model
    {
        /// <summary>
        /// 話す内容
        /// </summary>
        public string Content { get; set; } = "";

        /// <summary>
        /// 言語
        /// </summary>
        public List<SelectListItem> Langs { get; } = new List<SelectListItem>()
        {
            new SelectListItem { Text = "日本語", Value = "ja-JP", Selected = true, },
            new SelectListItem { Text = "アメリカ英語", Value = "en-US", },
            new SelectListItem { Text = "イギリス英語", Value = "en-GB", },
            new SelectListItem { Text = "中国語", Value = "zh-CN", },
            new SelectListItem { Text = "韓国語", Value = "ko-KR", },
        };

        /// <summary>
        /// 速度
        /// </summary>
        public readonly double MinRate = 0.1;
        public readonly double MaxRate = 10;
        private double _rate = 1;
        public double Rate
        {
            get
            {
                return _rate;
            }
            set
            {
                if (value < MinRate)
                {
                    _rate = MinRate;
                    return;
                }
                if (MaxRate < value)
                {
                    _rate = MaxRate;
                    return;
                }

                _rate = value;
            }
        }

        /// <summary>
        /// 声の高さ
        /// </summary>
        public readonly double MinPitch = 0;
        public readonly double MaxPitch = 2;
        private double _pitch = 0.5;
        public double Pitch
        {
            get
            {
                return _pitch;
            }
            set
            {
                if (value < MinPitch)
                {
                    _pitch = MinPitch;
                    return;
                }
                if (MaxPitch < value)
                {
                    _pitch = MaxPitch;
                    return;
                }

                _pitch = value;
            }
        }

        /// <summary>
        /// 音量
        /// </summary>
        public readonly double MinVolume = 0;
        public readonly double MaxVolume = 1;
        private double _volume = 1;
        public double Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if (value < MinVolume)
                {
                    _volume = MinVolume;
                    return;
                }
                if (MaxVolume < value)
                {
                    _volume = MaxVolume;
                    return;
                }

                _volume = value;
            }
        }
    }
}