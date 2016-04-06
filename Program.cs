using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboardstoplog
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyboardType; //type and model of keyboard
            string songName; //name of song stops will be listed with
            string stopOneName; //instrament name of stop one
            string stopTwoName; //instrament name of stop two
            string stopThreeName; //instrament name of stop three
            int stopOneNum; //stop one's number
            int stopTwoNum; //stop two's number
            int stopThreeNum; //stop three's number
            string styleName; //style name
            int styleNum; //style number
            string ans;
            Console.WriteLine("              Hello and welcome to the Keyboard Stop Log"); //14 spaces
            Console.WriteLine("              ------------------------------------------\n"); //14 spaces and escape sequence
            Console.Write("What type/model of keyboard do you use?:");
            keyboardType = Console.ReadLine();
            Console.WriteLine("Thank you for that information it helps to make your log more logical and\npretty.");
            
            top:
            
            Console.Write("What is the name of the song you use this set of stops with?:"); //write
            songName = Console.ReadLine();
            Console.Write("what is the name of the stop you use with " + songName + "? eg. grand piano:");
            stopOneName = Console.ReadLine();
            Console.Write("What is the number of the stop you use with " + songName + "?:");
            stopOneNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do you use a second stop?: (Y/N)");
            ans = Console.ReadLine();
            if (ans == "y" || ans == "Y")
            {
                Console.Write("What is the name of the second stop you use with " + songName + "?:");
                stopTwoName = Console.ReadLine();
                Console.Write("What is the number of the second stop?:");
                stopTwoNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Do you use a third stop?: (Y/N)");
                ans = Console.ReadLine();
                if (ans == "y" || ans == "Y")
                {
                    Console.Write("What is the name of the third stop you use with " + songName + "?:");
                    stopThreeName = Console.ReadLine();
                    Console.Write("What is the number of the third stop?:");
                    stopThreeNum = Convert.ToInt32(Console.ReadLine());
                }


            }
            Console.Write("What style do you use with " + songName + " if any?:");
            styleName = Console.ReadLine();
            if (styleName == "")
            {

                styleName = "NA";
            }
            else
            { 
                styleName = Console.ReadLine();
                Console.Write("What is the number of the style?:");
                styleNum = Convert.ToInt32(Console.ReadLine());
            }   
            string[] entry = {keyboardType,songName,stopOneName,stopOneNum,stopTwoName,stopTwoNum,stopThreeName,stopThreeNum,styleName,styleNum};//convert int to string
            Console.Write("Would you like to make another entry? (Y/N):");
            ans = Console.ReadLine();
            if (ans == "y" || ans == "Y")
            {
                goto top;
                //run code from line 30
            }
            Console.WriteLine("Thank you for using the Keyboard Stop Log. \nAt this moment you can exit the program by entering exit\nMake a new entry by entering new\nOr print your log to this console window for a quick review by entering read");
            ans = Console.ReadLine();
            if (ans == "exit")
            {
                //close console window
            }
            else if (ans == "new")
            {
                //run code form line 27
            }
            else if (ans == "read")
            {
                //use streamreader to output log file to console window 
            }
            //Console.ReadKey();
        }
    }
}
