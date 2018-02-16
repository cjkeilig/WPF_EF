using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WpfBrowserApplication1.ViewModel
{
    [Table("Person")]
    public class Person
    {
        [Key]
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName; }
            set
            {
                _firstName = value;
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        private DateTime _dob;
        public DateTime Dob
        {
            get
            {
                if (_dob == null)
                {
                    return DateTime.Today;
                }
                return _dob;
            }
            set
            {
                _dob = value;
            }
        }

        private DateTime? _dod;
        public DateTime? Dod
        {
            get
            {
                if (_dod == null)
                {
                    return DateTime.Today;
                }
                return _dod;
            }
            set
            {
                _dod = value;
            }
        }

        private string _birthCity;
        public string BirthCity
        {
            get
            {
                return _birthCity;
            }
            set
            {
                _birthCity = value;
            }
        }

        private string _birthCountry;
        public string BirthCountry
        {
            get
            {
                return _birthCountry;
            }
            set
            {
                _birthCountry = value;
            }
        }
    }
}
