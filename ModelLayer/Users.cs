using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Users : Person
    {
        private City cityCode;
        private string userName;
        private string userPassword;
        private string email;
        private string phoneNumber;

        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public City CityCode { get => cityCode; set => cityCode = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }


    }
}
