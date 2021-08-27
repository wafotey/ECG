using System;
using System.ComponentModel;

namespace ECG.Models
{
    public class Catalog : INotifyPropertyChanged
    {
        private Guid _id;
        private string _name;
        private string _description;
        private decimal _price;
        private int _quantity;
        private string _image;

        public Guid Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(nameof(Id));
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                RaisePropertyChanged(nameof(Description));
            }
        }

        public string Image 
        {
            get => _image;
            set
            {
                _image = value;
                RaisePropertyChanged(nameof(Image));
            }
        }

        public decimal Price 
        {
            get => _price;
            set
            {
                _price = value;
                RaisePropertyChanged(nameof(Price));
            }
        }
        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                RaisePropertyChanged(nameof(Quantity));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
