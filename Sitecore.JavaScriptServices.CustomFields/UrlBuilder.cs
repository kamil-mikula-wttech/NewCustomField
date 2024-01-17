using Sitecore.Data.Items;
using Sitecore.JavaScriptServices.Configuration;
using Sitecore.Web.UI.HtmlControls;
using Sitecore.Web.UI.Sheer;
using System.Web.UI;


//#nullable disable
namespace Sitecore.JavaScriptServices.CustomFields
{
    public class UrlBuilder: Sitecore.Shell.Applications.ContentEditor.Text
    {
        public string Token { get; set; }
        protected override void DoRender(HtmlTextWriter output)
        {
            //metoda szablonowa
            base.DoRender(output);
        }
        protected override void RenderChildren(HtmlTextWriter writer)
        {
            //aby zrobić kontrolkęktóra składa się z 2 kontrolek
            //tutaj dodajemy do istniejącej kontrolki
            base.RenderChildren(writer);
        }

        public string ItemID
        {
            get => this.GetViewStateString(nameof(ItemID));
            set => this.SetViewStateString(nameof(ItemID), value);
        }
        protected override string GetFieldValue(string field)
        {
            return base.GetFieldValue(field);
        }
        public override void HandleMessage(Message message)
        {
            base.HandleMessage(message);
        }
        protected override bool LoadPostData(string value)
        {
            return base.LoadPostData(value);
            //Rozbicie value na 2 części i zapis do bazy 
        }
    }
}