namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dato;
            Console.WriteLine("Indtast dagens dato (19/12/2023): ");
            dato = Console.ReadLine();
            Console.WriteLine(CheckDato(dato));
        }
        static string CheckDato(string dato) 
        {
            DateTime dagensDato;
            string msg = string.Empty;
            try
            {
                dagensDato = DateTime.Parse(dato);
                msg = $"Dato konverteret korrekt\nDagens dato: {dagensDato}";
            }
            catch (Exception e)
            {
                msg = $"Ukorrekt dato indtastet. Venligst prøv igen\n{e.Message}";
                throw;
            }
            return msg;
        }
    }
}
