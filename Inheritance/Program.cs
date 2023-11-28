using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           var Hawk = new Bird();

            Hawk.legs = 2;
            Hawk.claws = true;
            Hawk.color = "Brown black and white";
            Hawk.sound = "keeeaaar";
            Hawk.canFly = true;
            Hawk.migrates = true;
            Hawk.height = "2ft";
            Hawk.wingSpan = "between 3ft 7in and 4ft 7in";

            Console.WriteLine($"A hawk has {Hawk.legs} legs, it is {Hawk.claws} they have claws.");
            Console.WriteLine($"They are {Hawk.color} in color, {Hawk.sound} is the sound they make.");
            Console.WriteLine($"It is {Hawk.canFly} they fly and also {Hawk.migrates} they migrate.");
            Console.WriteLine($" They are a little over {Hawk.height} tall, and their wingspan is {Hawk.wingSpan}.");


            var Crocodile = new Reptile();

            Crocodile.legs = 4;
            Crocodile.claws = true;
            Crocodile.color = "dark green or gray";
            Crocodile.sound = "grunt growl or hiss";
            Crocodile.weight = "440lb to 2400lb";
            Crocodile.venom = false;
            Crocodile.speed = 20;
            Crocodile.length = "11ft to 20ft";

            Console.WriteLine($"Crocodiles have {Crocodile.legs} legs, and it is {Crocodile.claws} they have claws.");
            Console.WriteLine($"They are {Crocodile.color} in color. They {Crocodile.sound}. It is {Crocodile.venom} they do not have venom.");
            Console.WriteLine($"They weigh {Crocodile.weight} and grow to lenghts of {Crocodile.length} long.");
            Console.WriteLine($"They can run up to {Crocodile.speed}mph.");

            
        }
    }
}
