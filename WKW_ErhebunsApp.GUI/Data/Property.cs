using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WKW_ErhebunsApp.GUI.Data
{
    public class Property
    {
        string _postalCode;
        string _streetName;
        string _houseNumber;
        string _vl;
        string _info;
        string _comment;
        CurrentStatus _status;

        public Property(string postalCode, string streetName, string houseNumber,
            string vl, string info, string comment,
            CurrentStatus status = CurrentStatus.keine_Info)
        {
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
