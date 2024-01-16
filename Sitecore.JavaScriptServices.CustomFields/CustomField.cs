using Sitecore.Data.Items;
using Sitecore.JavaScriptServices.Configuration;
using Sitecore.Web.UI.HtmlControls;
using Sitecore.Web.UI.Sheer;
using System.Web.UI;


//#nullable disable
namespace Sitecore.JavaScriptServices.CustomFields
{
    public class CustomField: Sitecore.Shell.Applications.ContentEditor.Text
    {
        private readonly IConfigurationResolver _configurationResolver;
        //private readonly IGraphQLEndpointManager _graphQLEndpointManager;
        private string Something;
        public string Token { get; set; }
        //override
        protected override void DoRender(HtmlTextWriter output)
        {
            //przed 
            //podczas renderowania zapis do później, do momentu jak będzie serializowany w JSS
            //Można rozszerzyć o walidację/ jeżeli nie ma TOKENA w linku to wywal błąd
            //Jak dodać textbox aby wklepać więcej textboxów 
            //metoda szablonowa
            //base.DoRender(output);
            //kod do zmiany url nie znajduje się w kontrolce
        }
        protected override void RenderChildren(HtmlTextWriter writer)
        {
            //aby zrobić kontrolkęktóra składa się z 2 kontrolek
            //tutaj dodajemy do istniejącej kontrolki
            base.RenderChildren(writer);
        }
        private string mySetting;
        //protected CustomField(
        //  IConfigurationResolver configurationResolver)
        //  //IGraphQLEndpointManager graphQLEndpointManager)
        //{
        //    //W jaki sposób sitecore zapisuje pola?
        //    //zapis do bazy danych  -> check 

        //    //Czytanie z configa z jakiego itema na sitecore czytać value (Dictionary)
        //    //
        //    this._configurationResolver = configurationResolver;
        //    //this._graphQLEndpointManager = graphQLEndpointManager;

        //    //wyciągnięcie klucza 
            
        //    mySetting = Sitecore.Configuration.Settings.GetSetting("api-url");
        //  //  .where()
        //    // podczas kiedy service layer wysyła dane 
        //    //wyciągnij token i zapisz do pola obok aby pole było zapisane przez sitecore do bazy danych
        //    //żeby podczas renderowania można się dobrać do wartości 


        //    //składowanie linka?
        //    //->> w jaki sposób sitecore wykonuje zapis 

        //    //jak działa serializer 
        //    ///wyciągnięcie klucza i zapisanie w dodakowym property
        //}

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