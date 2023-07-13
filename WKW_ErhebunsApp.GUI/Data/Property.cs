using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WKW_ErhebunsApp.GUI.Data
{
    public class Property
    {
        int _id;
        string _postalCode;
        string _streetName;
        string _houseNumber;
        string _vl;
        string _info;
        string _comment;
        string _status;

        #region Properties
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }

        public string PostalCode
        {
            set { _postalCode = value; }
            get { return _postalCode; }
        }

        public string StreetName
        {
            set { _streetName = value; }
            get { return _streetName; }
        }

        public string HouseNumber
        {
            set { _houseNumber = value; }
            get { return _houseNumber; }
        }

        public string Vl
        {
            set { _vl = value; }
            get { return _vl; }
        }

        public string Info
        {
            set { _info = value; }
            get { return _info; }
        }
        public string Comment
        {
            set { _comment = value; }
            get { return _comment; }
        }
        public string Status
        {
            set { _status = value; }
            get { return _status; }
        }
        #endregion

        public Property(int id, string postalCode, string streetName, string houseNumber,
            string vl, string info, string comment,
			string status)
        {
            _id = id;
            _postalCode = postalCode;
            _streetName = streetName;
            _houseNumber = houseNumber;
            _vl = vl;
            _info = info;
            _comment = comment;
            _status = status;
        }
    }
}
