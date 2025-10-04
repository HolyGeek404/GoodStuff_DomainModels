namespace GoodStuff_DomainModels.Models.Products;

public sealed class ProductCategories
{
    public const string Gpu = "GPU";
    public const string Cpu = "CPU";
    public const string Cooler = "COOLER";
    
    public static IEnumerable<string> All => [Gpu, Cpu, Cooler];
}