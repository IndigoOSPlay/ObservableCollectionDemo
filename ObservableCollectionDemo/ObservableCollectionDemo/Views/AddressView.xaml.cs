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
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Telerik.XamarinForms.DataGrid;

namespace ObservableCollectionDemo {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddressView : ContentView {
        AddressViewModel m_vmViewModel;

        public AddressView() {
            this.m_vmViewModel = new AddressViewModel();

            InitializeComponent();

            TAddressListNew.ItemsSource = null;
            TAddressListNew.ItemsSource = this.m_vmViewModel.ModelAddressOList;
        }

        public void OnAppearing() {
            this.TAddressListNew.LoadOnDemand += TAddressListNew_LoadOnDemand;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e) {
            this.m_vmViewModel.HandlePickerChanges(ref sender);
        }

        private void TAddressListNew_LoadOnDemand(object sender, LoadOnDemandEventArgs e) {
            if (!this.m_vmViewModel.AddNextDemandBatch(ref e)) {
                this.TAddressListNew.LoadOnDemand -= TAddressListNew_LoadOnDemand;
            }
        }
    }
}