using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//using dll_json;
using dll_sql;

namespace lab_6.Additions
{
    public static class UpdateFormHelper
    {
        public static MvcHtmlString UpdateForm(this HtmlHelper html,List<Record> phoneDictionary, Record selectedRecord)
        {
            TagBuilder form = new TagBuilder("form");
            form.AddCssClass("update-form");
            form.MergeAttribute("method", "POST");
            form.MergeAttribute("action", "/Dict/UpdateSave");

            TagBuilder linkList = new TagBuilder("div");
            linkList.AddCssClass("link-list");
            foreach (var record in phoneDictionary)
            {
                TagBuilder div = new TagBuilder("div");
                TagBuilder spanName = new TagBuilder("span");
                spanName.SetInnerText(record.Name + " ");
                TagBuilder spanPhone = new TagBuilder("span");
                spanPhone.SetInnerText(record.Phone);
                div.InnerHtml += spanName;
                div.InnerHtml += spanPhone;
                linkList.InnerHtml += div;
            }

            TagBuilder inputForm = new TagBuilder("div");
            inputForm.AddCssClass("input-form");
            TagBuilder inputRecordID = new TagBuilder("input");
            inputRecordID.MergeAttribute("id", "recordID");
            inputRecordID.MergeAttribute("name", "recordID");
            inputRecordID.MergeAttribute("type", "text");
            inputRecordID.MergeAttribute("value", selectedRecord.RecordID.ToString());
            inputRecordID.MergeAttribute("hidden", "true");
            TagBuilder inputName = new TagBuilder("input");
            inputName.MergeAttribute("id", "name");
            inputName.MergeAttribute("name", "name");
            inputName.MergeAttribute("type", "text");
            inputName.MergeAttribute("value", selectedRecord.Name);
            TagBuilder inputPhone = new TagBuilder("input");
            inputPhone.MergeAttribute("id", "phone");
            inputPhone.MergeAttribute("name", "phone");
            inputPhone.MergeAttribute("type", "text");
            inputPhone.MergeAttribute("value", selectedRecord.Phone);
            inputForm.InnerHtml += inputRecordID;
            inputForm.InnerHtml += inputName;
            inputForm.InnerHtml += inputPhone;

            TagBuilder secondDiv = new TagBuilder("div");
            TagBuilder inputButton = new TagBuilder("input");
            inputButton.AddCssClass("link-button");
            inputButton.MergeAttribute("id", "update_button");
            inputButton.MergeAttribute("value", "Изменить");
            inputButton.MergeAttribute("type", "submit");
            TagBuilder anchor = new TagBuilder("a");
            anchor.AddCssClass("cancel-link");
            anchor.MergeAttribute("href", "/Dict/Index");
            anchor.SetInnerText("Отказаться");
            secondDiv.InnerHtml += inputButton;
            secondDiv.InnerHtml += anchor;

            form.InnerHtml += linkList;
            form.InnerHtml += inputForm;
            form.InnerHtml += secondDiv;

            return MvcHtmlString.Create(form.ToString()); ;
        }
    }
}