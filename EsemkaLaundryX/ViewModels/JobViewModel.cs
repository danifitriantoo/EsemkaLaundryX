using EsemkaLaundryX.Models;
using EsemkaLaundryX.Setup;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Windows.Controls;
using EsemkaLaundryX.Views;

namespace EsemkaLaundryX.ViewModels
{
    public class JobViewModel : INotifyPropertyChanged
    {
        public JobViewModel()
        {
            dbconn = new DBConnection();
            model = new Job();
            collection = new ObservableCollection<Job>();

            //ASYNC TASK
            InsertCommand = new RelayCommand(async () => await InsertDataAsync());
            UpdateCommand = new RelayCommand(async () => await UpdateDataAsync());
            DeleteCommand = new RelayCommand(async () => await DeleteDataAsync());
            ReadDataCommand = new RelayCommand(async () => await ReadDataAsync());

        }

        //COMMAND
        public RelayCommand InsertCommand { get; set; }
        public RelayCommand UpdateCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand ReadDataCommand { get; set; }

        //COLLECTION
        public ObservableCollection<Job> Collection
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
        public Job Model
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
        public event System.Action OnCallBack;

        //PRIVATE
        private readonly DBConnection dbconn;
        private Job model;
        private ObservableCollection<Job> collection;


        //CRUD
        private async Task InsertDataAsync()
        {
            dbconn.conn.Open();
            await Task.Delay(0);
            var query = $"INSERT INTO Job VALUES('{model.Name}')";
            var cmd = new SqlCommand(query, dbconn.conn);
            var dr = cmd.ExecuteNonQuery();
            dbconn.conn.Close();
        }

        private async Task ReadDataAsync()
        {
            dbconn.conn.Open();
            await Task.Delay(0);
            var query = "SELECT * FROM Job";
            var cmd = new SqlCommand(query, dbconn.conn);
            var dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                MessageBox.Show("OK");
                collection.Clear();
                while (dr.Read())
                {
                    collection.Add(new Job
                    {
                        Id = dr[0].ToString(),
                        Name = dr[1].ToString()
                });
                }
            }
            else
            {
                MessageBox.Show("Failed");
            }
            dbconn.conn.Close();
        }

        private async Task DeleteDataAsync()
        {
            await Task.Delay(0);

        }

        private async Task UpdateDataAsync()
        {
            await Task.Delay(0);
        }
    }
}
