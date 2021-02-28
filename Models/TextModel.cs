using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleApp_202101.Models
{
    /// <summary>
    /// テキスト情報
    /// </summary>
    public class TextModel
    {
        [Key]
        public int TodoId { get; set; }


        [DisplayName("TODOのページ全体数")]
        public string TodoItemPageCount { get; set; }

        [DisplayName("TODOの完了済のページ数")]
        public string TodoItemCompletePageCount { get; set; }

        [DisplayName("進捗度")]
        public short Percent { get; set; }


        [DisplayName("TODOでの使用するテキスト1")]
        public string TodoItemText1 { get; set; }

        [DisplayName("テキスト1の開始ページ")]
        public short TodoItemText1StartPage { get; set; }

        [DisplayName("テキスト1の終了ページ")]
        public short TodoItemText1EndPage { get; set; }

        [DisplayName("TODOでの使用するテキスト2")]
        public string TodoItemText2 { get; set; }

        [DisplayName("テキスト2の開始ページ")]
        public short TodoItemText2StartPage { get; set; }

        [DisplayName("テキスト2の終了ページ")]
        public short TodoItemText2EndPage { get; set; }

        [DisplayName("TODOでの使用するテキスト3")]
        public string TodoItemText3 { get; set; }

        [DisplayName("テキスト3の開始ページ")]
        public short TodoItemText3StartPage { get; set; }

        [DisplayName("テキスト3の終了ページ")]
        public short TodoItemText3EndPage { get; set; }

        [DisplayName("TODOでの使用するテキスト4")]
        public string TodoItemText4 { get; set; }

        [DisplayName("テキスト4の開始ページ")]
        public short TodoItemText4StartPage { get; set; }

        [DisplayName("テキストの終了ページ")]
        public short TodoItemText4EndPage { get; set; }

        [DisplayName("TODOでの使用するテキスト5")]
        public string TodoItemText5 { get; set; }

        [DisplayName("テキスト5の開始ページ")]
        public short TodoItemText5StartPage { get; set; }

        [DisplayName("テキストの終了ページ")]
        public short TodoItemText5EndPage { get; set; }

        [DisplayName("TODOでの使用するテキスト6")]
        public string TodoItemText6 { get; set; }

        [DisplayName("テキスト6の開始ページ")]
        public short TodoItemText6StartPage { get; set; }

        [DisplayName("テキスト6の終了ページ")]
        public short TodoItemText6EndPage { get; set; }

        [DisplayName("TODOでの使用するテキスト7")]
        public string TodoItemText7 { get; set; }

        [DisplayName("テキスト7の開始ページ")]
        public short TodoItemText7StartPage { get; set; }

        [DisplayName("テキスト7の終了ページ")]
        public short TodoItemText7EndPage { get; set; }

        [DisplayName("TODOでの使用するテキスト8")]
        public string TodoItemText8 { get; set; }

        [DisplayName("テキスト8の開始ページ")]
        public short TodoItemText8StartPage { get; set; }

        [DisplayName("テキストの終了ページ")]
        public short TodoItemText8EndPage { get; set; }

        [DisplayName("TODOでの使用するテキスト9")]
        public string TodoItemText9 { get; set; }

        [DisplayName("テキスト9の開始ページ")]
        public short TodoItemText9StartPage { get; set; }

        [DisplayName("テキスト9の終了ページ")]
        public short TodoItemText9EndPage { get; set; }
        [DisplayName("TODOでの使用するテキスト10")]
        public string TodoItemText10 { get; set; }

        [DisplayName("テキストの開始ページ")]
        public short TodoItemText10StartPage { get; set; }

        [DisplayName("テキストの終了ページ")]
        public short TodoItemText10EndPage { get; set; }



    }
}