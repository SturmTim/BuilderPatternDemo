namespace BuilderPatternDemo;

public class Product
{
    private string? _requiredB = null;
    private string _optionalA;
    private string _optionalB;

    private string? RequiredA { get; set; }
    private string? RequiredB => _requiredB;
    private string OptionalA => _optionalA;
    private string OptionalB => _optionalB;

    public Product(Builder builder)
    {
        RequiredA = builder._requiredB;
        _requiredB = builder._requiredB;
        _optionalA = builder._optionalA;
        _optionalB = builder._optionalB;
    }
    
    public class Builder
    {
        internal string? _requiredA = null;
        internal string? _requiredB = null;
        internal string _optionalA;
        internal string _optionalB;
        
        public Builder(string requiredA, string requiredB)
        {
            _requiredA = requiredA;
            _requiredB = requiredB;
        }
        
        public Builder SetOptionalA(string optionalA)
        {
            _optionalA = optionalA;
            return this;
        }
        
        public Builder SetOptionalB(string optionalB)
        {
            _optionalB = optionalB;
            return this;
        }
        
        public Product Build()
        {
            var product = new Product(this);
            if(product.OptionalA == "irgendwos") throw new Exception("irgendwos is not allowed");
            return product;
        }
    }
}