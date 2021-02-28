using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp_202101.Models
{
    /// <summary>
    /// Todoモデル
    /// </summary>
    /// モデル→DBにテーブル作成する。（Add-Migration)
    /// ①Enable-Migrations
    /// ②Add-Migration 202101111900
    /// ③Update-Database
    /// http://kaji-3.hatenablog.com/entry/2012/06/28/230753
    public class TodoModel
    {
        // TodoItemのID
        [Key]
        public long TodoId { get; set; }

        // 優先度
        [DisplayName("優先度")]
        public short Priority { get; set; }

        // 次のTODO
        [DisplayName("今後のTODO♪")]
        public long? NextTodoId { get; set; }

        // 今後のTODOリスト
        public List<long> NextList { get; set; }

        [DisplayName("カテゴリー")]
        public short TodoCategoryId { get; set; }

        [DisplayName("カテゴリーの内容")]
        public IEnumerable<SelectListItem> TodoCategoryContents { get; set; }

        [DisplayName("TODO")]
        public string TodoItem { get; set; }

        [DisplayName("TODOの内容")]
        public string TodoItemContents { get; set; }

        public List<TextModel> TextModels { get; set; }

        //public IEnumerable<SelectListItem> SelectedMember { get; set; } = new List<SelectListItem>();
        //public List<string> SelectedMemberKeyList { get; set; } = new List<string>();
        //public List<string> SelectedMemberValueList { get; set; } = new List<string>();

    }
}