
using SomeUwpApp.Services;
using SomeUwpApp.SomeService;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SomeUwpApp.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        IRepository _repository;
        IWebService _webService;

        public MainPageViewModel(IWebService webService, IRepository repository)
        {
            _repository = repository;
            _webService = webService;

            GetSettingsCommand = new RelayCommand( async () => {
                Settings = await _webService.GetSettings(Params); });
        }

        public string Params { get; set; }


        public ICommand GetSettingsCommand { get; private set; }
       
      

        public event PropertyChangedEventHandler PropertyChanged;

        

        private ObservableCollection<Setting> _settings;
        public ObservableCollection<Setting> Settings {
            get { return _settings; }
            set
            {
                _settings = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Settings"));
            }
        }


    }
}
