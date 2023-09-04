using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
            public string Name {get; set;}

            public string Id {get; set;}

            public string PhoneNumber {get; set;}
            public  Paciente(string name, string id, string phoneNumber)            
        {
            this.Name= Name;
            this.Id= Id;
            this.PhoneNumber=PhoneNumber;
            
        }

       
    }
}
