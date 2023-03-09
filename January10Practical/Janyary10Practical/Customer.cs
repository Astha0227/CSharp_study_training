using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace January10Practical
{
    internal class Customer
    {
        int _CustId;
        bool _Status;
        string _CName, _State;
        double _Balance;
        Cities _City;
        

        public Customer(int CustId, bool Status, string CName, double Balance, Cities City, string State)
        {
            _CustId = CustId;
            _Status = Status;
            _CName = CName;
            _Balance = Balance;
            _City = City;
            _State = State;
            
        }
        public int CustId
        {
            get { return _CustId; }  // set {_CustId = value}
        }

        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public string CName
        {
            get { return _CName; }
            set
            {
                if (_Status == true)
                    _CName = value;
            }
        }

        public double Balance
        {
            get { return _Balance; }
            set
            {
                if (_Status == true)
                {
                    if (value >= 500)
                        _Balance = value;

                }
            }

        }

        public Cities City
        {
            get { return _City; }
            set 
            { 
                if(_Status == true)
                    _City = value; 
            }
        }

        public string State
        {
            get { return _State; }
            protected set 
            {
                if (_Status == true)
                    _State = value;
            }
        }

        public string Country // Auto implimented or automatic property
        {
            get;

        } = "India"; //auto property initilizer

    }
}
