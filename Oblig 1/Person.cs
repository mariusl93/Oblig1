using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Oblig_1
{
    public class Person
    {
        public string FirstName; //{ get; set; }
        public string LastName; //{ get; set; }
        public int BirthYear; //{ get; set; }
        public int DeathYear; //{ get; set; }
        public int Id; //{ get; set; }
        public Person Father; //{ get; set; }
        public Person Mother; //{ get; set; }

        public string GetDescription()
        {
            //if (FirstName == null || LastName == null || BirthYear == 0 || DeathYear == 0 || Father == null || Mother == null)
            //return $"{FirstName} {LastName} (Id={Id}) Født: {BirthYear} Død: {DeathYear} Far: {Father.FirstName} (Id={Father.Id}) Mor: {Mother.FirstName} (Id={Mother.Id})";
            //return EmptyChoice();

            string str = "";
                str += FirstName != null ? FirstName + " " : "";
                str += LastName != null ? LastName + " " : "";
                str += Id != 0 ? $"(Id={Id}) " : "";
                str += BirthYear != 0 ? $"Født: {BirthYear} " : "";
                str += DeathYear != 0 ? $"Død: {DeathYear} " : "";
                str += Father != null ? $"Far: {Father.FirstName} (Id={Father.Id}) " : "";
                str += Mother != null ? $"Mor: {Mother.FirstName} (Id={Mother.Id}) " : "";
                return str.Trim();
            
        }   
        
    }
}




//Lag klassen Person.
//En person skal ha fornavn, etternavn, fødselsår og dødsår.
//Alle feltene er frivillige.
//For eksempel skal du kunne legge inn en person selv om du ikke vet fødselsår.