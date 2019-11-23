using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave_v1._0
{
    /* NOTE:
      Librarian class includes all the information about Admins.
    */

    class Librarian
    {
        //Variables

        private int ID;
        private string name;
        private string surname;
        private string email;
        private string password;

        // Getters and Setters

        public int ID1 { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        //Constructor
        Librarian(int ID, string name, string surname, string email, string password)
        {
            this.ID = ID;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
        }

    }
}