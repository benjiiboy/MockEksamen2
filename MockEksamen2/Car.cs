using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen2
{        public enum Color { Balck, White, Gray, Red, Green, Blue }
    public class Car
    {
        /// <summary>
        /// Dette er en bil klasse, som indeholder properties og instancser. Det kastets exceptions hvis man ikke opretter et objekt ordentligt.
        /// </summary>
        public Owner Owner { get; set; }

        private string registrationno;
        private int doors;
        private string model;

        private Color color;



        /// <summary>
        /// Givende antal døre i en bil, hvis værdien er under 2 eller over 5 kastets en exception
        /// </summary>
        public int Doors
        {
            get { return doors; }
            set
            {
                doors = value;
                if (doors < 2 || doors >5)
                {
                    throw new ArgumentOutOfRangeException("Doors must be between 2 and 5");
                }

            }
        }

        /// <summary>
        /// Bilens model, hvis værdien er null eller mellemrum, vill der blive kastet en exception
        /// </summary>
        public string Model
        {
            get { return model; }
            set
            {
                model = value;
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException("Car must have a model");

            }
        }

        /// <summary>
        /// Bilens registraerings nummer, hvis længden ikke er 7 vil der blive kastet en exception 
        /// </summary>
        public string RegistrationNo
        {
            get { return registrationno; }
            set
            {
                registrationno = value;
                if (registrationno.Length != 7)
                    throw new ArgumentOutOfRangeException("Registration must be 7 characters ");

            }
        }



        public Car(Color color, int door, string model, string regno)
        {
            this.color = color;
            this.Doors = door;
            this.Model = model;
            this.RegistrationNo = regno;
        }

    }
}

