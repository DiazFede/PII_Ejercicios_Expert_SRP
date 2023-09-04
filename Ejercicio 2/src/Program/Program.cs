using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Federico","5572118-4","0942456804","Carlos","C2","10:00","Española");
            Console.WriteLine(appointmentResult);
           
        }
    }
}
