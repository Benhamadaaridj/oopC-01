using System;

    public class Dog:Animal
    {
        private string favoriteToy;

        //constractor
        public Dog(string name,  string breed, int age, string favoriteToy) : base(name, breed, age)
        {
            this.favoriteToy = favoriteToy;
        }

        //Setters 
        public void SetfavoriteToy(string favoriteToy)
        {
            this.favoriteToy = favoriteToy;
        }
        //Getters 
        public string GetfavoriteToy()
        {
            return favoriteToy;
        }


        public override void Bark()
        {
            Console.WriteLine("dog sound ! ");
        }
    }

