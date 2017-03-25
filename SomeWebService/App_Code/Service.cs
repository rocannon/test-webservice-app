using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://localhost/")]
[WebServiceBinding(ConformsTo = WsiProfiles.None)]
// Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку.
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service()
    {

        //Раскомментируйте следующую строку в случае использования сконструированных компонентов 
        //InitializeComponent(); 
    }

    [WebMethod(MessageName = "GetSettings")]
    public List<Setting> GetSettings(string searchField)
    {
        var keys = searchField.Split(' ');
        var list = new List<Setting>();
        foreach (var key in keys)
        {
            list.Add(new Setting { Key = key, Value = "SomeValue" });
        }
        return list;
    }

    [WebMethod(MessageName = "GetSettingsWithoutParams")]
    public string GetSettings()
    {
        return "default_settings";
    }

}
