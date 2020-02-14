using System;
using System.IO;

namespace Dog{
    public enum Gender{ //structure of dog genders
        Male, Female
    };

    public class Dog{ //defines public variables
        public string name, owner;
        public int age;
        public Gender gender;

        public Dog(string name, string owner, int age, Gender gender){
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }
        public void Bark(int count){ //function counts number taken in and prints according woofs
            for(int i=0; i<count; i++){
                Console.Write("Woof!");
            }
        }

        public string GetTag(){ //function takes in names and numbers and prints sentence
            string tag ="\nIf lost, call "+owner+". ";
            if(gender==0){
                tag += "His name is "+name+" he is "+age.ToString();
            }
            else{
                tag += "Her name is " +name+ " she is "+age.ToString();
            }

            if (age > 1){
                tag += " years old. \n";
            }
            else{
                tag += " year old. \n";
            }
            return tag; //returns sentence containing correct name and age
        }

        class Program{ //main program that sends names and numbers to functions
            static void Main(string[] args){
                Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
                puppy.Bark(3);
                Console.WriteLine(puppy.GetTag());

                Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
                myDog.Bark(1);
                Console.WriteLine(myDog.GetTag());
            }
        }
    }




}