using System;

namespace ProtectedStaffAcessLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            AnotherStaff staff = new AnotherStaff();
            staff.GetStaffDetails();
            Console.WriteLine(" Welcome Ademodi!");
        }
    }


      public  class ProtectedStaff
    {
        protected string Name;
        protected string Location;
        protected int Age;
        
    }

    public  class AnotherStaff : ProtectedStaff
    {
        public void GetStaffDetails()
        {
            this.Name = "Ademodi ife";
            this.Location = "Lekki";
            this.Age = 45;
           Console.WriteLine("Name: {0}", Name);
           Console.WriteLine("Location: {0}", Location);
           Console.WriteLine("Age: {0}", Age);
        }
        

    }

}
