using CsBases.Fundamentals;

class Program
{
    static async Task Main()
    {
        //WriteLine("Hello, World!");

        var Laptop = new Product("Laptop", 1200);
        //WriteLine(Laptop.GetDescription());

        var Soporte = new ServiceProduct("Soporte técnico", 300, 30);
        //WriteLine(Soporte.GetDescription());

        var product = new Product("Mouse gamer", 300);
        var productDto = ProductAdapter.ToDto(product);
        //WriteLine($"{productDto.Name} - {productDto.Price:c} - Código: {productDto.Code}");

        // Inyección de dependencias
        ILabelService labelService = new LabelService();
        var manager = new ProductManager(labelService); 
        var monitor = new Product("Monitor", 100);
        var installation = new ServiceProduct("Instalación de monitor", 20, 30);
        //manager.PrintLabel(monitor);
        //manager.PrintLabel(installation);

        var firstProduct = await new ProductRepository().GetProduct(1);
        firstProduct.Description = "Esta es la descripción";
        AttributeProcessor.ApplyUpperCase(firstProduct);
        WriteLine($"{firstProduct.Name} - {firstProduct.Price} - {firstProduct.Description}");
    }
}