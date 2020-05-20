using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LV7_rppoon.Strategija;
using LV7_rppoon.Promatrac;
using LV7_rppoon.Posjetitelj;

namespace LV7_rppoon
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. zadatak testiranje
            double[] arrayToSort = new double[] { 2.3, 1.5, 6.7, 9.3, 5.4, 2, 5.6, 8.5, 9.1, 2.01 };
            NumberSequence numberSequence1 = new NumberSequence(arrayToSort);
            BubbleSort bubbleSort = new BubbleSort();
            SequentialSort sequentialSort = new SequentialSort();
            CombSort combSort = new CombSort();
            numberSequence1.SetSortStrategy(bubbleSort);
            numberSequence1.Sort();
            Console.WriteLine(numberSequence1.ToString());
            NumberSequence numberSequence2 = new NumberSequence(arrayToSort);
            numberSequence2.SetSortStrategy(sequentialSort);
            numberSequence2.Sort();
            Console.WriteLine(numberSequence2.ToString());
            NumberSequence numberSequence3 = new NumberSequence(arrayToSort);
            numberSequence3.SetSortStrategy(combSort);
            numberSequence3.Sort();
            Console.WriteLine(numberSequence3.ToString());
            //kreirala sam 3 objekta da bih dodatno provjerila svaki sort, jer prvi put kad pozovemo sort, sequence ostaje sortiran

            //2. zadatak testiranje
            double wantedElement = 9.3; //Broj se nalazi u polju.
            SequentialSearch sequentialSearch = new SequentialSearch(wantedElement);
            numberSequence1.SetSearchStrategy(sequentialSearch);
            if(numberSequence1.Search())
            {
                Console.WriteLine("Number " + wantedElement + " can be found in the array.");
            }
            else { Console.WriteLine("Number " + wantedElement + " can not be found in the array."); }

            //3. zadatak testiranje
            //SystemDataProvider systemDataProvider = new SystemDataProvider();
            //FileLogger fileLogger1 = new FileLogger("fileLogger1.txt");
            //systemDataProvider.Attach(fileLogger1);
            //ConsoleLogger consoleLogger = new ConsoleLogger();
            //systemDataProvider.Attach(consoleLogger);

            //for(int i = 0; i < 1; i=0)
            //{
            //    systemDataProvider.GetCPULoad();
            //    systemDataProvider.GetAvailableRAM();
            //    System.Threading.Thread.Sleep(1000);
            //}

            //4. zadatak testiranje
            //SystemDataProvider systemDataProvider = new SystemDataProvider();
            //FileLogger fileLogger1 = new FileLogger("fileLogger1.txt");
            //systemDataProvider.Attach(fileLogger1);
            //ConsoleLogger consoleLogger = new ConsoleLogger();
            //systemDataProvider.Attach(consoleLogger);
            //for (int i = 0; i < 1; i = 0)
            //{
            //    systemDataProvider.GetCPULoad();
            //    systemDataProvider.GetAvailableRAM();
            //    System.Threading.Thread.Sleep(1000);
            //}

            //5. zadatak testiranje
            DVD myDVD = new DVD("Little Mermaid", DVDType.MOVIE, 12.99);
            VHS myVHS = new VHS("Pocahontas", 11.49);
            Book myBook = new Book("Snow White", 7.20);
            BuyVisitor meAsBuyVisitor = new BuyVisitor();

            Console.WriteLine("{0:N2}", myDVD.Accept(meAsBuyVisitor) + " DVD");  //moramo zaokruziti na 2 decimale 
            Console.WriteLine("{0:N2}", myVHS.Accept(meAsBuyVisitor) + " VHS");
            Console.WriteLine("{0:N2}", myBook.Accept(meAsBuyVisitor) + " Book");

            //6. zadatak testiranje
            Console.WriteLine("Ispis cijena kod iznajmljivanja (vrijednosti bi trebale biti manje nego u primjeru iznad).");
            Visitor meAsVisitor = new Visitor();
            Console.WriteLine("{0:N2}", myDVD.Accept(meAsVisitor) + " DVD");  
            Console.WriteLine("{0:N2}", myVHS.Accept(meAsVisitor) + " VHS");
            Console.WriteLine("{0:N2}", myBook.Accept(meAsVisitor) + " Book");

            //7. zadatak testiranje
            List<IItem> myCollection = new List<IItem>();
            Book newBook = new Book("Cinderella", 12.01);
            myCollection.Add(newBook);
            Cart newCart = new Cart(myCollection);
            Console.WriteLine("{0:N2}", newCart.Accept(meAsBuyVisitor));
            
        }
    }
}
