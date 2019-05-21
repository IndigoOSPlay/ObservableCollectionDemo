/**
 * ObservableCollectionDemo a demonstration of Telerik Xamarin RadDataGrid
 * LoadOnDemand, ObservableCollection usage and Xamarin.Forms ContentView.
 * 
 * Copyright (C) 2019  Indigo Olive Software
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
**/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Telerik.XamarinForms.DataGrid;

using Xamarin.Forms;

namespace ObservableCollectionDemo {
    public class AddressViewModel {

        List<AddressBinding> mAddressFullList;

        /** Our observable collection. **/
        public AddressCollection ModelAddressOList;
        public int currentPage;
        public int itemsPerPage;

        public AddressViewModel() {
            AddressData addData = new AddressData();
            this.currentPage = 0;
            this.itemsPerPage = 5;
            this.mAddressFullList = null;
            this.ModelAddressOList = new AddressCollection();
            this.mAddressFullList = addData.GetAddressFullList();
        }

        private List<AddressBinding> GetAddressItemsSelector(int pageToGet, int itemsToFetch)
        {
            List<AddressBinding> addressSelector = null;
            if (this.mAddressFullList != null) {
                addressSelector = this.mAddressFullList.Skip(itemsToFetch * (pageToGet - 1)).Take(itemsToFetch).ToList();
            }
            return addressSelector;
        }

        public bool AddNextDemandBatch(ref LoadOnDemandEventArgs e) {
            this.currentPage++;
            List<AddressBinding> lstAddressItemsSelector = GetAddressItemsSelector(this.currentPage, this.itemsPerPage);

            e.IsDataLoaded = true;

            if (lstAddressItemsSelector != null && lstAddressItemsSelector.Count > 0) {
                foreach (var objAddressItemsSelector in lstAddressItemsSelector) {
                    this.ModelAddressOList.Add(objAddressItemsSelector);
                }
                return true;
            }
            return false;
        }

        public void HandlePickerChanges(ref object sender) {
            var zipPicker = (Picker)sender;
            if (zipPicker != null)
            {
                AddressBinding addressItem = (AddressBinding)zipPicker.BindingContext;

                var currentSelectedZip = zipPicker.SelectedItem;
                if (currentSelectedZip != null)
                {
                    string pickerCurrentZip = currentSelectedZip as string;
                    /**
                     *   anAddress.PostalCodePick.Add("39567");
                     *   anAddress.PostalCodePick.Add("54328");
                     *   anAddress.PostalCodePick.Add("65788");
                     *   anAddress.PostalCodePick.Add("23444");
                     *   anAddress.PostalCodePick.Add("90909");
                     **/

                    if (pickerCurrentZip.Equals("39567")) {
                        addressItem.Name = "Changed Name 1";
                        addressItem.City = "Changed City 1";
                        addressItem.Region = "Changed Region 1";
                        addressItem.Phone = "111-1111";
                        addressItem.Building = "Changed Building 1";
                        addressItem.Country = "111";
                        addressItem.Street = "Changed Street 1";
                    } else if (pickerCurrentZip.Equals("54328")) {
                        addressItem.Name = "Changed Name 2";
                        addressItem.City = "Changed City 2";
                        addressItem.Region = "Changed Region 2";
                        addressItem.Phone = "222-2222";
                        addressItem.Building = "Changed Building 2";
                        addressItem.Country = "222";
                        addressItem.Street = "Changed Street 2";
                    } else if (pickerCurrentZip.Equals("54328")) {
                        addressItem.Name = "Changed Name 3";
                        addressItem.City = "Changed City 3";
                        addressItem.Region = "Changed Region 3";
                        addressItem.Phone = "333-3333";
                        addressItem.Building = "Changed Building 3";
                        addressItem.Country = "333";
                        addressItem.Street = "Changed Street 3";
                    } else if (pickerCurrentZip.Equals("65788")) {
                        addressItem.Name = "Changed Name 4";
                        addressItem.City = "Changed City 4";
                        addressItem.Region = "Changed Region 4";
                        addressItem.Phone = "444-4444";
                        addressItem.Building = "Changed Building 4";
                        addressItem.Country = "444";
                        addressItem.Street = "Changed Street 4";
                    } else if (pickerCurrentZip.Equals("23444")) {
                        addressItem.Name = "Changed Name 5";
                        addressItem.City = "Changed City 5";
                        addressItem.Region = "Changed Region 5";
                        addressItem.Phone = "555-5555";
                        addressItem.Building = "Changed Building 5";
                        addressItem.Country = "555";
                        addressItem.Street = "Changed Street 5";
                    } else if (pickerCurrentZip.Equals("90909")) {
                        addressItem.Name = "Changed Name 6";
                        addressItem.City = "Changed City 6";
                        addressItem.Region = "Changed Region 6";
                        addressItem.Phone = "666-6666";
                        addressItem.Building = "Changed Building 6";
                        addressItem.Country = "666";
                        addressItem.Street = "Changed Street 6";
                    }

                    addressItem.PostalCode = pickerCurrentZip;
                }
            }
        }
    }

    public class AddressCollection : ObservableCollection<AddressBinding> {
        public AddressCollection() : base() {
        }
    }
}
