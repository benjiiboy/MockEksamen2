using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen2
{
   public class Owner
    {
        /// <summary>
        /// Dette er en klasse som beskriver ejeren af en bil. Der kastes ligeledes også exceptions hvis de rigtige kritierer ikke er opfyldt
        /// </summary>
        private string address;
        private string phone;
        private string name;

        /// <summary>
        /// Adressen på ejer, hvis værdien er mindre end 6 vil der blive kastet en exception
        /// </summary>
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                if (value.Length < 6)

                    throw new ArgumentException("Address should be more than 6 characters");

            }
        }

        /// <summary>
        /// Navn på ejer, hvis værdien er mindre end 4 vil der blive kastet en exception
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                if (value.Length < 4)
                    throw new ArgumentException("Name should be more than 4 characters");

            }
        }

        /// <summary>
        /// Mobil nummer på ejer, hvis det instastede nummer ikke er ligmed 8, vil der blive kastet en exception
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                if (value.Length != 8)
                    throw new ArgumentException("Phone number should be 8 characters");

            }
        }

        public Owner(string addres, string name, string phone)
        {
            this.Address = addres;
            this.Name = name;
            this.Phone = phone;
        }

    }
}
