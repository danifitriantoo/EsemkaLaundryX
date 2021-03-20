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
    public class CustomerViewModel : INotifyPropertyChanged
    {
        public CustomerViewModel()
        {
            dbconn = new DBConnection();
            model = new Customer();
            collection = new ObservableCollection<Customer>();

            //ASYNC TASK
            InsertCommand = new RelayCommand(async () => await InsertDataAsync());
        }

        //COMMAND
        public RelayCommand InsertCommand;

        //COLLECTION
        public ObservableCollection<Customer> Collection
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
        public Customer Model
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
        private Customer model;
        private ObservableCollection<Customer> collection;


        //CRUD
        private async Task<object> InsertDataAsync()
        {
            await Task.Delay(0);
            return true;
        }
    }
}


