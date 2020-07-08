using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//using dll_json;
using dll_sql;

namespace lab_6.Additions
{
    public static class AddFormHelper
    {
        public static MvcHtmlString AddForm(this HtmlHelper html, List<Record> phoneDictionary)
        {
            TagBuilder form = new TagBuilder("form");
            form.AddCssClass("add-form");
            form.MergeAttribute("method", "POST");
            form.MergeAttribute("action", "/Dict/AddSave");

            TagBuilder linkList = new TagBuilder("div");
            linkList.AddCssClass("link-list");
            foreach(var record in phoneDictionary)
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
            TagBuilder inputName = new TagBuilder("input");
            inputName.MergeAttribute("name", "name");
            inputName.MergeAttribute("type", "text");
            TagBuilder inputPhone = new TagBuilder("input");
            inputPhone.MergeAttribute("name", "phone");
            inputPhone.MergeAttribute("type", "text");
            inputForm.InnerHtml += inputName;
            inputForm.InnerHtml += inputPhone;

            TagBuilder secondDiv = new TagBuilder("div");
            TagBuilder inputButton = new TagBuilder("input");
            inputButton.AddCssClass("link-button");
            inputButton.MergeAttribute("value", "Добавить");
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