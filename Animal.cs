using System;

    public class Animal
    {
        private string name;
        
        private string breed;
        private int age;
        //constactor
        public Animal (string name,string breed, int age)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
        }
        //Setters
        public void Setname(string name)
        {
            this.name = name;
        }
        public void Setage(int age)
        {
            this.age = age;
        }
        public void Setbreed(string breed)
        {
            this.breed = breed;
        }
        //Getters
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public string Getbreed()
        {
            return breed;
        }

        public virtual void Bark()
        {
            Console.WriteLine("Animal Sound ! ");
        }

    }

