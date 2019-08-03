using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CriminalRecordManagement.DataLayer
{
    public class clsCriminalRegistration
    {
        private int criminalNo;
        private string criminalName;
        private string criminalNickName;
        private int age;
        private string occupation;
        private string crimeType;
        private string address;
        private string mostWanted;

        public int CriminalNo { get => criminalNo; set => criminalNo = value; }
        public string CriminalName { get => criminalName; set => criminalName = value; }
        public string CriminalNickName { get => criminalNickName; set => criminalNickName = value; }
        public int Age { get => age; set => age = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public string CrimeType { get => crimeType; set => crimeType = value; }
        public string Address { get => address; set => address = value; }
        public string MostWanted { get => mostWanted; set => mostWanted = value; }

        public DataSet getAllCriminalRecords()
        {
            DataSet ds = new DataSet();
            DataConnection con = new DataConnection();
           
            return ds;
        }

    }
}