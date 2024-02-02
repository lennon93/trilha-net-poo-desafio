namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, string memoria)
        : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} da Play Store...");
            AppsInstalados.Add(nomeApp);
        }

        // Sobrescrever o método "DesinstalarAplicativo"
        public override void DesinstalarAplicativo(string nomeApp)
        {
            if (AppsInstalados.Contains(nomeApp))
            {
                AppsInstalados.Remove(nomeApp);
                Console.WriteLine($"Desinstalando aplicativo {nomeApp}...");
            }
            else
            {
                Console.WriteLine($"O aplicativo {nomeApp} não está instalado no Nokia.");
            }
        }
    }
}