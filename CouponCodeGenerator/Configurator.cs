using System.Configuration;

public static class Configurator
{
    public static string CharacterSet { get { return ConfigurationManager.AppSettings["CharacterSet"] ?? "ABCDEFG12345"; } }
    public static int Generations { get { return Int32.Parse(ConfigurationManager.AppSettings["Generations"] ?? "10"); } }
}
