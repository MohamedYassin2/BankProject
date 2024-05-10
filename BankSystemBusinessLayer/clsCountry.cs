using Bank_System_Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBusinessLayer
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        private clsCountry(int CountryID ,string CountryName) 
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }


        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;
            if (clsCountryData.GetCountryInfoByName(ref CountryID, ref CountryName))
                return new clsCountry(CountryID, CountryName);

            return null;
        }


        public static string GetCountryName(int CountryID)
        {
            string CountryName = "";
            if (clsCountryData.GetCountryInfoByID(ref CountryID, ref CountryName))
            {
                clsCountry C = new clsCountry(CountryID, CountryName);
                return C.CountryName;
            }
            return null;
                 
        }
        public static DataTable GetAllCountries()
        {
           return clsCountryData.GetAllCountries();
        }

    }
}
