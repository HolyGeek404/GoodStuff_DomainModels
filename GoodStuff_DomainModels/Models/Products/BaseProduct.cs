namespace GoodStuff_DomainModels.Models.Products;

public abstract class BaseProductModel
{
    public string Name { get; set; }
    public string Team { get; set; }
    public string Price { get; set; }
    public string ProductImg { get; set; }
    public string Category { get; set; }
    public string ProductId { get; set; }
    public string Id { get; set; }
    public string Warranty { get; set; }
    public string ProducerCode { get; set; }
}