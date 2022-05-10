using System; //riferimento alla libreria di base

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args) //entry point
        {
            //namespace, classe, metodo
            int num1;
            int num2;
            Console.WriteLine("Il programma chiede all utente due numeri e stampa il prodotto");
            Console.Write("Inserisci il primo numero");
            try
            {
               num1= int.Parse(Console.ReadLine());
               num2 = int.Parse(Console.ReadLine());
            
           /* if(!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Errore, puoi inserire solo un numero:");
                System.Environment.Exit(1);
            }
           */
            Console.Write("Inserisci il secondo numero");
            /*
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Errore, puoi inserire solo un numero:");
                System.Environment.Exit(1);
            }
            */
            System.Console.WriteLine("Il prodotto dei due numeri è: {0} ",
            Moltiplicazione(num1, num2));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Puoi inserire solo numeri");
            }
        }
        static int Moltiplicazione(int v1, int v2)
        {
            return v1 * v2;
        }
    }
}
