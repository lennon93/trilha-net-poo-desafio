namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public string Memoria { get; set; }

        public List<string> AppsInstalados { get; set; }

         public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            AppsInstalados = new List<string>();
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void MostrarApps()
        { 
            if (AppsInstalados.Count == 0)
            {
                Console.WriteLine("Nenhum aplicativo instalado.");
            }
            else
            {
                Console.WriteLine("Aplicativos instalados:");
                foreach (string app in AppsInstalados)
                    {
                        Console.WriteLine(app);
                    }
            }
        }
        

        public abstract void InstalarAplicativo(string nomeApp);

        public abstract void DesinstalarAplicativo(string nomeApp);
    }
}