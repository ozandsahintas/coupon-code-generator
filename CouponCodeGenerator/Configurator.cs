using System.Configuration;

public static class Configurator
{
    public static string? CharacterSet { get { return ConfigurationManager.AppSettings["CharacterSet"] ?? null; } }
    public static int? Generations { get { return Int32.Parse(ConfigurationManager.AppSettings["Generations"] ?? ""); } }
}
