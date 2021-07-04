using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        //ExamineQueue();
                        break;
                    case '3':
                        //ExamineStack();
                        break;
                    case '4':
                        //CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
             
             * ---My Answers:---
             * 2. The List increases everytime with the Add-method, one element at a time or more depending if you use a loop to add elements. 
             * 3. The capacity increases depending on the datatypes.
             * 4. I guess the answer has to do with actual elements added and the datatypes. Each datatype (int, string, double etc) needs different
             * storage space. So if you have a List with lots doubles, floats etc, it will take up more space even though the actual elements are less
             * than a List that only has int:s. 
             * 5. Not necessarily. See answer 4.
             * 6. Use Arrays when you know how many elements - with one datatype (note, you can only use one datatype),that you are going to use/create.             *  Whereas in a List, you can add as many elements you want without getting and "IndexOutOfRange"-exception.
             * Arrays has fixed size i.e. in general, you can not expand the Array (though I think you can actually do this using dynamic arrays). 
             * If i am not mistaken you dim the array and then at runtime - redimension it. Anyways, use an Array when you know how many elements and
             * with a single datatype.
             * 
             * More answers but in Swedish.
             * 
             * 1. Stacken funkar som lådor. För att komma åt lådan i mitten/längst ner så måste du ta bort lådorna som är ovanför. Heapen är mer att som att du dumpar alla kläder på golvet o sen söker du efter det du önskar.

               2. Value types är mer en kopia av ett värde. Medans en reference type är när du pekar på en variabels minnesplats i minnet s.k. pointers. I tex C++ kan man användas sig av pointers.

               3. Skillnaden är att den första inte skapar ett nytt objekt och därför behålls värdet 3. MyInt y=new MyInt()<---skapar ett nytt objekt.
             *
             *Som tillägg till 1 och 2, så kan man analysera stacken ända ner till method/function-nivå med hjälp av WinDbg (Windows Debugger). 
             *Eventuellt att man kan nå så långt i Visual Studio också. I båda fallen måste man dock använda sig av symbols .pdb:s(symbolfiler). 
             *Allt detta kan åstadkommas om/när man laddar ner ett Windows SDK (för lämplig Windows version).
            */

            //Do 
            //    {
            //    

            //    } while (true) ;

            //string c;
           List<string>names= new List<string>();
           int iCounter= 0;
            Console.WriteLine("Please input 5 names preceeded by either a +(plus)-sign or a -(minus)-sign.");
            while (iCounter < 5)
            {

                
            Console.WriteLine("Input a name:");
            string input = Console.ReadLine();
            char[] c = input.ToCharArray();
            char cc = c[0];
            switch (cc.ToString())
            {
                case "+":
                        if (!cc.ToString().Equals("+") && !cc.ToString().Equals("-")) 
                        {
                            Console.WriteLine("incorrect format");
                        }//throw new ArgumentException(cc.ToString());
                        
                        names.Add(input);
                    break;
                case "-":
                    names.Remove(input);
                    Console.WriteLine($"{input} was not added to the list.");
                    break;
                
                default:
                    //Console.WriteLine("Wrong Input");
                    Console.WriteLine("Wrong input");
                    break;
            
            }
                
                iCounter++;
            }
            Console.WriteLine("\nThese were added to the list.");
            Console.WriteLine("-----------------------------");
            for(int i = 0; i < names.Count; i++)
                {
                    Console.WriteLine(names[i]);
                }
            //foreach(string s in names)
            //{
            //    Console.WriteLine(s);
            //}


            /*En Reverse-text method. */

            Console.WriteLine("Please input a string and I will reverse it.");
            string mystring = Console.ReadLine();
            char[] cReverse = mystring.ToCharArray();
            Console.WriteLine(cReverse);
            for (int i = cReverse.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(cReverse[i]);
            }

            //Console.WriteLine(cc);
            //foreach(char cc in c)
            //{
            //    Console.WriteLine(cc.ToString());
            //}
            //List<string> theList = new List<string>();
            //char nav = input[0];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Add name preceeded either by +plus(sign) or -(minus)-sign. Ex: +myname or -myname");
            //    string input = Console.ReadLine();
            //    switch (input)
            //    {
            //        case ("+"):
            //            char nav = input[0];
            //            Console.WriteLine(nav);
            //            theList.Add(input);
            //            break;
            //            //case default:
            //            //    break;
            //            //    Console.WriteLine("Wrong input");

            //    }







            //    //foreach (string str in theList)
            //    //    {
            //    //        Console.WriteLine(str);
            //    //    }


            //    //string value = input.substring()   

            //    //;

            //    //switch(nav){...}
            //}

            /// <summary>
            /// Examines the datastructure Queue
            /// </summary>
            static void ExamineQueue()
            {
                /*
                 * Loop this method untill the user inputs something to exit to main menue.
                 * Create a switch with cases to enqueue items or dequeue items
                 * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
                */
            }

            /// <summary>
            /// Examines the datastructure Stack
            /// </summary>
            static void ExamineStack()
            {
                /*
                 * Loop this method until the user inputs something to exit to main menue.
                 * Create a switch with cases to push or pop items
                 * Make sure to look at the stack after pushing and and poping to see how it behaves
                */
            }

            static void CheckParanthesis()
            {
                /*
                 * Use this method to check if the paranthesis in a string is Correct or incorrect.
                 * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
                 * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
                 */

            }

        }
    }
}

