using System;

namespace poly
{
    class Hcl
    {
        static void Main()
        {
            Hcl obj = new Hcl();
            obj.walk(101);
            obj.walk("101");
        }

        public void walk(int a){
            System.Console.WriteLine("Working");
        }
        
        public void walk(string a){
            System.Console.WriteLine("Working");
        }

    }
}
