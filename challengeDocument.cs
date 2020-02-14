using System;
using System.IO;

namespace DocumentCreator{
    class Document{
        static void Main(string[] args){
            try{ //using a "try" here in order to check for exceptions later
                Console.WriteLine("Document\n");
                Console.WriteLine("Enter Document Title: ");
                string title = Console.ReadLine();
                //prompts the user to enter a title name for a file
                
                Console.WriteLine("Enter Document Content: ");
                string content = Console.ReadLine();
                string filename = title+".txt";
                //prompts the user to enter what they want into a file, then makes it a text file
                
                string adjust = Environment.CurrentDirectory+"/"+filename;
                if(!File.Exists(adjust)){
                    File.WriteAllText(adjust, content);
                }
                //if the filename already exists, a "/" prefix is added to the filename in the current directory

            }
            catch(Exception exc){
                Console.WriteLine(exc);
            }
            //error check in case and exceptions come about

        }
    }
}