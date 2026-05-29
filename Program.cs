using CsBases.Fundamentals;

class Program
{
    static void Main()
    {
        WriteLine("Hello, World!");


        var Laptop = new Product("Laptop", 1200);
        WriteLine(Laptop.GetDescription());

        var Soporte = new ServiceProduct("Soporte técnico", 300, 30);
        WriteLine(Soporte.GetDescription());

        var product = new Product("Mouse gamer", 300);
        var productDto = ProductAdapter.ToDto(product);
        WriteLine($"{productDto.Name} - {productDto.Price:c} - Código: {productDto.Code}");

    }
}