using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile
{
    public abstract class animal
    {
        public abstract string species();
        public abstract int legs();
        public abstract string food();
        public abstract string gender();
        public virtual string tail()
        {
            return "yes";
        }
        public virtual string wildanddomestic()
        {
            return "wild";
        }
    }

    public class Dog : animal
    {
        public override string species()
        {
            return "bulldog";
        }
        public override int legs()
        {
            return 4;
        }
        public override string food()
        {
            return "fish";
        }
        public override string gender()
        {
            return "male";
        }
        public override string tail()
        {
            return "no";
        }
        public override string wildanddomestic()
        {
            return "domestic";
        }

    }

    public class executeanimal
    {
        static void Main(string[] args)
        {
            Dog animals = new Dog();
            string output = animals.gender();
            
            if (output == "male")
            {
                Console.WriteLine("getout");
            }
            else if(output == "female")
            {
                Console.WriteLine( "welcome");
            }
            Console.WriteLine(animals.tail());
            Console.WriteLine(animals.wildanddomestic());
            Console.WriteLine(animals.food());
            Console.WriteLine(animals.species());
            int op = animals.legs();
            if (op < 4)
            {
                Console.WriteLine("not a dog");
            }
            cat cats = new cat();
            Console.WriteLine(cats.colour());
            Console.WriteLine(cats.OwnerName());
            Console.WriteLine(cats.PetName());
            Console.WriteLine(cats.age());
        }
    }
    public interface Ianimals
    {
        string colour(); //by default abstract keyword
        
        string OwnerName();
        int age();


    }
    public interface Ipname
    {
        string PetName();
    }
    public class cat : Ianimals,Ipname
    {
        public string colour()
        {
            return "red";
        }

        public int age()
        {
            return 12;
        }

        public string OwnerName()
        {
            return "roky";
        }

        public string PetName()
        {
            return "ramukaka";
        }
    }
}
