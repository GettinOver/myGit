using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    class Program {
        static void Main(string[] args) {
            //COMBINING STRINGS            
            /*//define variables
            string firstName = "John";
            string lastName = "Doe";

            //for first name
            Console.WriteLine("Default name: " + firstName + " " + lastName); //outputs default values
            Console.WriteLine("Please enter a new first name:"); //urges to enter new first name
            firstName = Console.ReadLine(); //changes the value of firstName

            //for last name
            Console.WriteLine("Please enter a new last name:"); //urges to enter new last name
            lastName = Console.ReadLine(); // changes the value of lastName
            Console.WriteLine("New name: " + firstName + " " + lastName); //outputs new first and last name
            Console.ReadLine(); //waits for an user input to exit*/


            //DO MATHS
            /*float num1, num2; //define variables
            
            Console.WriteLine("Please enter a number (Decimals with ',')"); //urge to enter an integer
            num1 = float.Parse(Console.ReadLine()); //sets value of num1
            
            Console.WriteLine("Please enter another number (Decimals with ',')"); //urge to enter another integer
            num2 = float.Parse(Console.ReadLine()); //sets value of num2

            Console.WriteLine("Adding the two: " + (num1 + num2)); //does the math
            Console.WriteLine("Subtracting the two: " + (num1 - num2)); //does the math
            Console.WriteLine("Multiplies the two: " + (num1 * num2)); //does the math
            Console.WriteLine("Divines the two: " + (num1 / num2)); //does the math
            Console.WriteLine("Rest of the two: " + (num1 % num2)); //does the math
            Console.ReadLine(); //waits for an user input to exit*/


            //IF STATEMENT
            /*float num; //define variables

            Console.WriteLine("Please enter a number between 0 and 10"); //urge to enter a number
            num = float.Parse(Console.ReadLine()); //defines num

            if (num > 10) { //checks if num is greater than 10
                Console.WriteLine("Hey! The number should be 10 or less");
            } else if (num < 0) { //checks if num is less than 0
                Console.WriteLine("Hey! The number should be 0 or more");
            } else {
                Console.WriteLine("You entered" + " " + num + ". " + "That's between 0 and 10. Good Job!");
            }

            Console.ReadLine();*/


            //SWITCH STATEMENT 1
            /*int num;

            Console.WriteLine("Enter a number between 0 and 1");
            num = int.Parse(Console.ReadLine());

            switch (num) {
                case 0:
                    Console.WriteLine("The number is zero!");
                    break;
                case 1:
                    Console.WriteLine("The number is one!");
                    break;
                default:
                    Console.WriteLine("The number is either too big or too small");
                    break;
            }

            Console.ReadLine();*/


            //SWITCH STATEMENT 2
            /*Console.WriteLine("Do you enjoy C#? (yes/no/maybe)");//asking the user
            string input = Console.ReadLine(); //define variable input

            switch (input.ToLower()) { //check the user answer
                case "yes":
                case "maybe":
                    Console.WriteLine("Great");
                    break;
                case "no":
                    Console.WriteLine("Too bad");
                    break;
                default:
                    Console.WriteLine("Something went wrong");
                    break;
            }

            Console.ReadLine();*/


            //WHILE LOOP
            /*int num = 0; //define num

            while (num <= 5) {
                Console.WriteLine(num); //print num until num is less or equal to 5
                num = num + 1; //increase num by one after each print
            }

            Console.ReadLine();*/


            //DO LOOP
            /*int num = 0;
            do {
                Console.WriteLine(num);
                num = num + 1;
            } while (num <= 5);

            Console.ReadLine();*/


            //FOR LOOP
            /*int num = 5;

            for (int i = 0; i <= num; i++) { //set variable 'i'; set condition; increase i
                Console.WriteLine(i);
            }

            Console.ReadLine();*/


            //FOREACH LOOP
            /*ArrayList list = new ArrayList();
            list.Add("John Doe");
            list.Add("Jane Doe");
            list.Add("Someone Else");

            foreach (string name in list) {
                Console.WriteLine(name);
            }

            Console.ReadLine();*/


            //FUNCTION
            /*void doStuff() {
                Console.WriteLine("I'm doin' something");
                Console.ReadLine();
            }


            int AddNumbers(int num1, int num2) {
                return num1 + num2;
            }

            int result = AddNumbers(10, 5);
            Console.WriteLine(result);
            Console.ReadLine();*/


            //ARRAYS
            /*string[] names = new string[2];
            names[0] = "John Doe";
            names[1] = "Jane Doe";

            int[] numbers = { 4, 3, 8, 0, 5 };

            foreach (string s in names) {
                Console.WriteLine(s);
            }

            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine("Item number " + i + ": " + names[i]);
            }

            Array.Sort(numbers);

            foreach (int i in numbers) {
                Console.WriteLine(i); 
            }

            Console.ReadLine();*/


            //CLASSES
            /*Car car;

            car = new Car("Red");
            Console.WriteLine(car.Describe());

            car = new Car("Green");
            Console.WriteLine(car.Describe());

            Console.ReadLine();

            //**************Diesen Teil in namespace verschieben****************
            class Car {
            private string color;

            public Car(string color) {
                this.color = color;
            }

            public string Describe() {
                return "This car is " + Color;
            }

            public string Color {
                get { return color; }
                set { color = value; }
            }

            }*/


            //ERROR HANDLERS
            /*int[] numbers = new int[2];
            try {
                numbers[0] = 23;
                numbers[1] = 32;
                numbers[2] = 42;

                foreach (int i in numbers)
                    Console.WriteLine(i);
            } catch (IndexOutOfRangeException ex) {
                Console.WriteLine("An index was out of range!");
            } catch (Exception ex) {
                Console.WriteLine("Some sort of error occured: " + ex.Message);
            } finally {
                Console.WriteLine("It's the end of our try block. Time to clean up!");
            }
            Console.ReadLine();*/

        }

    }
}
