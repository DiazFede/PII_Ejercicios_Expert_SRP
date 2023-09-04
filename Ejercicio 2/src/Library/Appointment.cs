using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Library
{
    public class Appointment
    {   
        public DoctorInfo Doctor {get;set;}
        public Paciente Paciente {get;set;}
        public string Hora {get;set;}
        public string Lugar {get;set;}

        public Appointment(DoctorInfo doctor, Paciente paciente, string Lugar,string Hora)
        {
           this.Doctor=doctor;
           this.Paciente= paciente;
           this.Lugar= Lugar;
           this.Hora= Hora;

        }
    }
}