using System;
using System.IO;
using System.Text;
using System.Transactions;

namespace _9_4_Lab_Practice_Creating_Dynamic_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StringBuilder myHtmlPage = new StringBuilder();
            
            const string htmlPager = "<!DOCTYPE html>";
            string htmlDocOpen = "<html>";
            string htmlDocClose = "</html>";           
            string headOpen = "<head>";
            string headClose = "</head>";

            string bodyOpen = "<body>";
            string bodyClose = "</body>";
            string header1Open = "<h1>";
            string header1Close = "</h1>";
            string unorderedOpen = "<ul>";
            string unorderedClose = "</ul>";
            string listItemOpen = "<li>";
            string listItemClose = "</li>";
            string parOpen = "<p>";
            string parClose = "</p>";


            Console.WriteLine("Enter the text you want for your header.");
            string dHtmlHdr = Console.ReadLine();

            Console.WriteLine("Enter the text to describe your list."); //used w/ <p>
            string dHtmlListDescr = Console.ReadLine();

            Console.WriteLine("Enter the first item in your list.");
            string dHtmlListItem1 = Console.ReadLine();
            Console.WriteLine("Enter the second item in your list.");
            string dHtmlListItem2 = Console.ReadLine();
            Console.WriteLine("Enter the third item in your list.");
            string dHtmlListItem3 = Console.ReadLine();

            //creating our HTML file:
            myHtmlPage.Append(htmlPager);
            myHtmlPage.Append(htmlDocOpen);   //for html open/close
            myHtmlPage.Append(headOpen);      //for head open/close
            myHtmlPage.Append(headClose);      //for head open/close
            myHtmlPage.Append(bodyOpen);      //for body open/close  
                                              //////////////////////Body starts here

            myHtmlPage.Append(header1Open);    //headrer open/close
                myHtmlPage.Append(dHtmlHdr);
            myHtmlPage.Append(header1Close);    //headrer open/close

            myHtmlPage.Append(parOpen);    //list tile, via <p>, open/close
                myHtmlPage.Append(dHtmlListDescr);
            myHtmlPage.Append(parClose);    //list tile, via <p>, open/close
            
            myHtmlPage.Append(unorderedOpen);    //unordered list open/close
           
                myHtmlPage.Append(listItemOpen);    //list item1 open/close
                    myHtmlPage.Append(dHtmlListItem1);
                myHtmlPage.Append(listItemClose);    //list item1 open/closeo


                myHtmlPage.Append(listItemOpen);    //list item2 open/close
                    myHtmlPage.Append(dHtmlListItem2);
                myHtmlPage.Append(listItemClose);    //list item2 open/closeo


                myHtmlPage.Append(listItemOpen);    //list item3 open/close
                    myHtmlPage.Append(dHtmlListItem3);
                myHtmlPage.Append(listItemClose);    //list item3 open/closeo

                        
            myHtmlPage.Append(unorderedClose);    //unordered list open/close


            ////////////////////// body ends here
            myHtmlPage.Append(bodyClose);      //for body open/close  
            myHtmlPage.Append(htmlDocClose);    //for html open/close

            //// web page is done!!!!
            ///
            Console.WriteLine(myHtmlPage);
            FileWriter fileWriter = new FileWriter();
            File.AppendAllText(@"I:\APP Class\Course_4_C Sharp\Lesson 9\Programs\9_4_Lab Practice Creating Dynamic HTML\LabPractice.html", 
                myHtmlPage.ToString());


        }
    }
}
