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

namespace ObservableCollectionDemo {
    public class AddressListViewModel {

        List<Address> mAddressFullList;

        /** Our observable collection. **/
        public AddressCollection ModelAddressOList;
        public int currentPage;
        public int itemsPerPage;

        public AddressListViewModel() {
            AddressData addData = new AddressData();
            this.currentPage = 0;
            this.itemsPerPage = 5;
            this.mAddressFullList = null;
            this.ModelAddressOList = new AddressCollection();
            this.mAddressFullList = addData.GetAddressFullList();
        }

        private List<Address> GetAddressItemsSelector(int pageToGet, int itemsToFetch)
        {
            List<Address> addressSelector = null;
            if (this.mAddressFullList != null) {
                addressSelector = this.mAddressFullList.Skip(itemsToFetch * (pageToGet - 1)).Take(itemsToFetch).ToList();
            }
            return addressSelector;
        }

        public bool AddNextDemandBatch() {
            this.currentPage++;
            List<Address> lstAddressItemsSelector = GetAddressItemsSelector(this.currentPage, this.itemsPerPage);

            if (lstAddressItemsSelector != null && lstAddressItemsSelector.Count > 0) {
                foreach (var objAddressItemsSelector in lstAddressItemsSelector) {
                    this.ModelAddressOList.Add(objAddressItemsSelector);
                }
                return true;
            }
            return false;
        }
    }

    public class AddressCollection : ObservableCollection<Address> {
        public AddressCollection() : base() {
        }
    }
}
