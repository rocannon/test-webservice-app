
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomeUwpApp.SomeService;
using System.Collections.ObjectModel;

namespace SomeUwpApp.Services
{
    public class SoapWebService : IWebService
    {
        SomeService.ServiceSoapClient _soapServiceClient = new SomeService.ServiceSoapClient();



        public async Task<ObservableCollection<Setting>> GetSettings(string parametrs)
        {
            var response = await _soapServiceClient.GetSettingsAsync(parametrs);
            
            return response.Body.GetSettingsResult;
        }
    }
}
