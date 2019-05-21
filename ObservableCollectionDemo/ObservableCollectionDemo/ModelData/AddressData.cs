using System;
using System.Collections.Generic;
using System.Text;

namespace ObservableCollectionDemo {
    public class AddressData{
        public AddressData() {
        }

        public List <AddressBinding> GetAddressFullList() {
            List <AddressBinding> addressListReturned = new List<AddressBinding>();
            int nStartIndex = 0;
            AddressBinding anAddress = null;
            AddressData ad = new AddressData();

            foreach (var addr in addressesGiven) {
                switch (nStartIndex) {
                    case 0:
                        anAddress = new AddressBinding();
                        anAddress.Name = addr;
                        break;
                    case 1:
                        anAddress.Building = addr;
                        break;
                    case 2:
                        anAddress.Street = addr;
                        break;
                    case 3:
                        anAddress.City = addr;
                        break;
                    case 4:
                        anAddress.Region = addr;
                        anAddress.Country = "USA";
                        break;
                    case 5:
                        anAddress.PostalCode = addr;
                        anAddress.PostalCodePick = new List<string>();
                        anAddress.PostalCodePick.Add(anAddress.PostalCode);
                        anAddress.PostalCodePick.Add("39567");
                        anAddress.PostalCodePick.Add("54328");
                        anAddress.PostalCodePick.Add("65788");
                        anAddress.PostalCodePick.Add("23444");
                        anAddress.PostalCodePick.Add("90909");
                        break;
                    case 6:
                        anAddress.Phone = addr;
                        break;
                }
                nStartIndex++;
                if (nStartIndex == 7) {
                    addressListReturned.Add(anAddress);
                    nStartIndex = 0;
                }
            }

            return addressListReturned;
        }

        /** Some demo data. **/
        string[] addressesGiven = {
                    "Cecilia Chapman",
                    "711-2880",
                    "Nulla St.",
                    "Mankato",
                    "Mississippi",
                    "96522",
                    "(257) 563-7401",

                    "Iris Watson",
                    "P.O. Box 283 8562",
                    "Fusce Rd.",
                    "Frederick",
                    "Nebraska",
                    "20620",
                    "(372) 587-2335",

                    "Celeste Slater",
                    "606-3727",
                    "Ullamcorper. Street",
                    "Roseville",
                    "NH",
                    "11523",
                    "(786) 713-8616",

                    "Theodore Lowe",
                    "Ap #867-859",
                    "Sit Rd.",
                    "Azusa",
                    "New York",
                    "39531",
                    "(793) 151-6230",

                    "Calista Wise",
                    "7292",
                    "Dictum Av.",
                    "San Antonio",
                    "MI",
                    "47096",
                    "(492) 709-6392",

                    "Kyla Olsen",
                    "Ap #651-8679",
                    "Sodales Av.",
                    "Tamuning",
                    "PA",
                    "10855",
                    "(654) 393-5734",

                    "Forrest Ray",
                    "191-103",
                    "Integer Rd.",
                    "Corona",
                    "New Mexico",
                    "08219",
                    "(404) 960-3807",

                    "Hiroko Potter",
                    "P.O. Box 887 2508",
                    "Dolor. Av.",
                    "Muskegon",
                    "KY",
                    "12482",
                    "(314) 244-6306",

                    "Nyssa Vazquez",
                    "511-5762",
                    "At Rd.",
                    "Chelsea",
                    "MI",
                    "67708",
                    "(947) 278-5929",

                    "Lawrence Moreno",
                    "935-9940",
                    "Tortor. Street",
                    "Santa Rosa",
                    "MN",
                    "98804",
                    "(684) 579-1879",

                    "Ina Moran",
                    "P.O. Box 929 4189",
                    "Nunc Road",
                    "Lebanon",
                    "KY",
                    "69409",
                    "(389) 737-2852",

                    "Aaron Hawkins",
                    "5587",
                    "Nunc. Avenue",
                    "Erie",
                    "Rhode Island",
                    "24975",
                    "(660) 663-4518",

                    "Hedy Greene",
                    "Ap #696-3279",
                    "Viverra. Avenue",
                    "Latrobe",
                    "DE",
                    "38100",
                    "(608) 265-2215",

                    "Melvin Porter",
                    "P.O. Box 132 1599",
                    "Curabitur Rd.",
                    "Bandera",
                    "South Dakota",
                    "45149",
                    "(959) 119-8364",

                    "Keefe Sellers",
                    "347-7666",
                    "Iaculis St.",
                    "Woodruff",
                    "SC",
                    "49854",
                    "(468) 353-2641",

                    "Joan Romero",
                    "666-4366",
                    "Lacinia Avenue",
                    "Idaho Falls",
                    "Ohio",
                    "19253",
                    "(248) 675-4007",

                    "Davis Patrick",
                    "P.O. Box 147 2546",
                    "Sociosqu Rd.",
                    "Bethlehem",
                    "Utah",
                    "02913",
                    "(939) 353-1107",

                    "Leilani Boyer",
                    "557-6308",
                    "Lacinia Road",
                    "San Bernardino",
                    "ND",
                    "09289",
                    "(570) 873-7090",

                    "Colby Bernard",
                    "Ap #285-7193",
                    "Ullamcorper Avenue",
                    "Amesbury",
                    "HI",
                    "93373",
                    "(302) 259-2375",

                    "Bryar Pitts",
                    "5543",
                    "Aliquet St.",
                    "Fort Dodge",
                    "GA",
                    "20783",
                    "(717) 450-4729"
                };
    }
}
