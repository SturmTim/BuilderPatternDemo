// See https://aka.ms/new-console-template for more information

using BuilderPatternDemo;

var product1 = new Product.Builder("Product 1", "BB")
    .SetOptionalA("Seas")
    .SetOptionalB("nix")
    .Build();

Console.WriteLine(product1);

var product2 = new Product.Builder("Product 1", "BB")
    .SetOptionalA("irgendwos")
    .SetOptionalB("nix")
    .Build();