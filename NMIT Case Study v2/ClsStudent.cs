using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment_3
{
    public class ClsStudent
    {
        private string _ID;
        private string _Name;        
        private string _Surname;
        private DateTime _DOB = DateTime.Today;
        private decimal _Balance;

        public override string ToString()
        {
            return _ID + "\n" + Name;
                
        }

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Name { get => _Name; set => _Name = value; }
        public DateTime DOB { get => _DOB; set => _DOB = value; }
        public decimal Balance { get => _Balance; set => _Balance = value; }
        public string Surname { get => _Surname; set => _Surname = value; }
        
    }
}
