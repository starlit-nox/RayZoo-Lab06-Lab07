Lab 06. Lab 07: Zoo
Author: Kaydee Kelly

Introduction
This is a progrma that allows a user to view an animal in a digital zoo. By running the program, the animal will make a certain noise or action specialized to its spot in the animal kingdom. For example a dog will say "bark" and when a shark moves it'll swim. 

Getting Started
To run the Digital Zoo, follow these steps:

Clone the repository or download the source code files.
Open the project in an IDE or editor that supports C#.
Build the solution to ensure all dependencies are resolved.
Run the program.
View what each animal does / says. 

Additional Information Lab 06

Digital ULM

(Animal)
(Mammal) (Reptile) (Bird)
(Dog) (Tiger) (Godzilla) (Gekco) (Ostirch)

The 3rd row of classes inherits from the second row. 
The 2nd row of classes inherits from the first row. 

Technical Docummentation

1. Encapsulation: It hides the internal details from external entties (by keeping things private)
2. Inheritance: It allows a lass to inherit properties and methods from another class.
3. Polymorphism: It allows objs of different classes to be treated as objs of a base class. It let's us reuse stuff.

Additional Information Lab 07

Interface: In C# an interface is a construct that defines a contract for the over all program. It sets up all the declarations for the classes details without adding said details. It basically lays everything out for the classes props and methods.


Location: My interfaces are IWalks and IWalk. They are are imlpemented in this own .cs file and they're called to classes which have Legs in them. The reason for this is the prop inside of the interface is Legs, thus IWalk or IWalks can only be used for animals that ahve Legs. 

Example:
using Lab6Zoo;

namespace Lab6
{
    class Ostrich : Bird, IWalks
    {
        public int Legs { get; set; }
        public void Walk()
        {
            Console.WriteLine("Meep meep");
        }
    }
}


Updated diagram with your interfaces mapped out.

IWalk
|
v
class Tiger : Mammal, IWalk


IWalk is called down to the Tiger Class.

