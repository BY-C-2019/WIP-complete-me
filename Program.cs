using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complete_me
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slumpat = new Random(); 
            //Skrev in 1,21 så det slumpas mella 1-20
            int speltal = slumpat.Next(1,21); 
            
            bool spela = true; 
            //Tog bort ! för att få loopen att funka
            while (spela)
            {
                Console.Write("\n\tGissa på ett tal mellan 1 och 20 (Eller avsluta med Q): ");
                //Skrev in ToLower så att oavsett sparas det som litet q
                string talInString = Console.ReadLine().ToLower();
                
                //Det enda stället jag kunde få med en switch är här, hoppas det var så du menade
                switch(talInString){
                    case "q":
                    Console.WriteLine("Du valde att avlsuta spelet. Tack o hej");
                    return;
                }
                //En try här för att skicka felmeddelande om man matar in siffran med bokstäver
                try{
                    int number=Convert.ToInt32(talInString);

                //En if-sats om användaren matara in en siffra högre än 20
                if(number>20){
                    Console.WriteLine("Nu angav du för högt nummer!\nVälj mellan 1-20");
                }
                else if (number < speltal){
                    Console.WriteLine("\tDet inmatade talet " + number + " är för litet, försök igen.");
                }else if (number > speltal){                      //Saknade ett + efter tal
                    Console.WriteLine("\tDet inmatade talet " + number  +" är för stort, försök igen.");
                }else if (number == speltal){ //Saknade att = brevid tal 
                    Console.WriteLine("\tGrattis, du gissade rätt!Woooho");
                    //Flyttade in spela=false hit för att avsluta efter vinst
                    spela=false;
                }
                // En catch som skickar ett felmeddelande vid felinmatning istället för att krasha
                }catch{
                    Console.WriteLine("Felinmatning! Försök igen");
                }


            }

        }
    }
}
