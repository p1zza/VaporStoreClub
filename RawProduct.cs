using System;
using System.Collections.Generic;
using WooCommerceNET.WooCommerce.v3;

class RawProduct
{
    public static Dictionary<int, string> ProductNames { get; set; }
    public static Dictionary<int, int?> ProductPrices { get; set; }
    public static Dictionary<int, int?> ProductStockQuantity { get; set; }
    public static Dictionary<int, ProductCategoryLine> ProductCategory { get; set; }
    public RawProduct()
    {
        ProductNames = new Dictionary<int, string>();
        ProductPrices = new Dictionary<int, int?>();
        ProductStockQuantity = new Dictionary<int, int?>();
        ProductCategory = new Dictionary<int, ProductCategoryLine>();
    }

    public void AddName(int id, string name)
    {
        ProductNames.Add(id, name);
    }

    public void AddPrice(int id, int? price)
    {
        ProductPrices.Add(id, price);
    }

    public void AddStockQuantity(int id, int? value)
    {
        ProductStockQuantity.Add(id, value);
    }

    public void AddCategory(int id, ProductCategoryLine categoryLine)
    {
        throw new Exception("Не обработано");
    }

    public Dictionary<int, string> GetProductNames()
    {
        return ProductNames;
    }

    public Dictionary<int, int?> GetProductPrice()
    {
        return ProductPrices;
    }

    public Dictionary<int, int?> GetStickQuantity()
    {
        return ProductStockQuantity;
    }

    public Dictionary<int, ProductCategoryLine> GetCategory()
    {
        return ProductCategory;
    }

}