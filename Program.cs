namespace files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("prodotti.csv"))
            {
                using (StreamReader sr = new StreamReader("prodotti.csv"))
                {
                    sr.ReadLine();
                    double somma = 0;
                    double  media = 0;
                    int conta = 0;
                    while (!sr.EndOfStream)
                    {                        
                        string record = sr.ReadLine();
                        string[] campi = record.Split(';');
                        somma = double.Parse(campi[1].Replace('.',',')) + somma ;
                        conta++;
                        
                        

                    }
                    media = somma / conta;
                    Console.WriteLine($"La media dei prezzi è " + media);

                }
            }
        }
    }
}
