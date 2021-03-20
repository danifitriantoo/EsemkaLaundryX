using EsemkaLaundryX.Models;
using EsemkaLaundryX.Setup;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemkaLaundryX.ViewModels
{
    public class PackageViewModel : INotifyPropertyChanged
    {
        public PackageViewModel()
        {
            dbconn = new DBConnection();
            model = new Package();
            collection = new ObservableCollection<Package>();

            //ASYNC TASK
            InsertCommand = new RelayCommand(async () => await InsertDataAsync());
        }

        //COMMAND
        public RelayCommand InsertCommand;

        //COLLECTION
        public ObservableCollection<Package> Collection
        {
            get
            {
                return collection;
            }
            set
            {
                collection = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }
        //MODELS
        public Package Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
            }
        }

        //ADD-ON PUBLIC
        public event PropertyChangedEventHandler PropertyChanged;
        public event Action OnCallBack;

        //PRIVATE
        private readonly DBConnection dbconn;
        private Package model;
        private ObservableCollection<Package> collection;


        //CRUD
        private async Task<object> InsertDataAsync()
        {
            await Task.Delay(0);
            return true;
        }
    }
}