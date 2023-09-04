using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Library
{
    public class DoctorInfo 
    {
        public string NombreDoctor {get; set;}

        public string Consultorio {get; set;}


        public DoctorInfo(string NombreDoctor, string Consultorio)
        {
           this.NombreDoctor=NombreDoctor;
           this.Consultorio= Consultorio;

        }

    }
}
