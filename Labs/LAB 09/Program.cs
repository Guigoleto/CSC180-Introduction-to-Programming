using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor mezei = new Instructor();
            mezei.SetName("Dr.Mezei");
            mezei.SetOffice("Panowicz 111");
            mezei.SetSpecialty("Computer Science");
            mezei.DisplayInstructor();

            Instructor walton= new Instructor();
            walton.SetName("Dr.Walton");
            walton.SetOffice("Cebula Hall 203E");
            walton.SetSpecialty("Civil Engineering");
            walton.DisplayInstructor();

            Instructor amende = new Instructor();
            amende.SetName("Dr.Amende");
            amende.SetOffice("Old Main 413");
            amende.SetSpecialty("Mathematics");
            amende.DisplayInstructor();
        }
    }

    class Instructor
    {
        // Data - Fields
        private string name;
        private string office;
        private string specialty;

        // Methods 
        public void SetName(string nome)
        {
            name = nome;
        }

        public string GetName ()
        {
            return name;
        }

        public void SetSpecialty(string especialidade)
        {
            specialty = especialidade;
        }

        public string GetSpecialty()
        {
            return specialty;
        }

        public void SetOffice(string escritorio)
        {
            office = escritorio;
        }

        public string GetOffice()
        {
            return office;
        }

        public void DisplayInstructor()
        {
            Console.Write("{0}, ",GetName());
            Console.Write("{0}, ",GetOffice());
            Console.WriteLine("{0} ",GetSpecialty());
        }

    }
}
