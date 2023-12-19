namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dato;
            Console.Write("Indtast dagens dato (19/12/2023): ");
            dato = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(CheckDato(dato));
        }
        static string CheckDato(string dato) 
        {
            DateTime dagensDato;
            string msg = string.Empty;
            try
            {
                dagensDato = DateTime.Parse(dato);
                Console.WriteLine($"Dato konverteret korrekt\nIndtastet dato: {dagensDato.ToShortDateString()}");
                if (dagensDato < DateTime.Now.Date)
                {
                    msg = $"\nDu har indtastet en dato før dagens dato";
                }
                else
                {
                    Exception ex = new Exception($"\n{dagensDato.ToShortDateString()} is !< {DateTime.Now.ToShortDateString()}");
                    msg = $"\nDu har ikke indtastet en dato som ligger før dagens dato\n{ex.Message};";
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ukorrekt dato indtastet. Venligst prøv igen\n{e.Message}");
                throw;
            }
            return msg;
        }
    }
}
