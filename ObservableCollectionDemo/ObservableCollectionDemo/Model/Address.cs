using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObservableCollectionDemo {
    public class Address : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public enum RegionType {
            RegionTypeState,
            RegionTypeProvince,
            RegionTypeTerritory,
            RegionTypeDistrict
        };

        private string m_sName;
        private string m_sBuilding;
        private string m_sStreet;
        private string m_sCity;
        private string m_sRegion;
        private string m_sCountry;
        private string m_sPostalCode;
        private string m_sPhone;

        public string Name { get { return m_sName; } set { SetField(ref m_sName, value, "Name"); } }
        public string Building { get { return m_sBuilding; } set { SetField(ref m_sBuilding, value, "Building"); } }
        public string Street { get { return m_sStreet; } set { SetField(ref m_sStreet, value, "Street"); } }
        public string City { get { return m_sCity; } set { SetField(ref m_sCity, value, "City"); } }
        public string Region { get { return m_sRegion; } set { SetField(ref m_sRegion, value, "Region"); } }
        public string Country { get { return m_sCountry; } set { SetField(ref m_sCountry, value, "Country"); } }
        public string PostalCode { get { return m_sPostalCode; } set { SetField(ref m_sPostalCode, value, "PostalCode"); } }
        public string Phone { get { return m_sPhone; } set { SetField(ref m_sPhone, value, "Phone"); } }


        public RegionType RegionTypeEnumValue { get; set; }
        public List<string> PostalCodePick { get; set; }

        public Address() {
            RegionTypeEnumValue = RegionType.RegionTypeState;
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged(this, new PropertyChangedEventArgs("Building"));
                PropertyChanged(this, new PropertyChangedEventArgs("Street"));
                PropertyChanged(this, new PropertyChangedEventArgs("City"));
                PropertyChanged(this, new PropertyChangedEventArgs("Region"));
                PropertyChanged(this, new PropertyChangedEventArgs("Country"));
                PropertyChanged(this, new PropertyChangedEventArgs("PostalCode"));
                PropertyChanged(this, new PropertyChangedEventArgs("Phone"));
            }
        }

        protected virtual void OnPropertyChanged(string sPropertyName) {
            if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs(sPropertyName));
        }

        protected bool SetField<T>(ref T field, T value, string propertyName) {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
