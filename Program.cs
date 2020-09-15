using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Int32.Parse(Console.ReadLine());
            if (age <= 20)
            {
                Console.WriteLine("You are too young to use this calculator");
                
                

            }
            else if (age >= 60)
            {
                Console.WriteLine("You are too old to use this calculator");

            }
            else
            {
                Console.WriteLine("You are right age to use this calculator!");
            }
            
            
            

           
            
            { 
                
                double height;
                Console.WriteLine("Enter your height");
                height = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Your height is {height} meters.");

                double weight;
                Console.Write("Enter your weight");
                weight = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Your weight is {weight} kilograms.");

                double heightm2 = height + weight;
                
                double BMI = weight / heightm2;

                if (BMI <= 19)
                {

                    Console.WriteLine("You are under weight");

                }
                else if (BMI >= 19 && BMI >= 24.9)
                {
                    Console.WriteLine("You are at normal weight");
                }
                    
                else if (BMI >= 25 && BMI >= 29.9)
                {
                  Console.WriteLine("You are overweight");
                }
                   

                


                
                        
                    

                
                          
                    


                

                
                

                

                
                
                    

                

                

                    

                

















            }
            

            
            
            


            
        }

    }
}
