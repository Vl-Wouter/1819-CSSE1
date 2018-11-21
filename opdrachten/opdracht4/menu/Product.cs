class Product {
    // Fields
    private string naam;
    private string type;
    private string[] ingredienten;

    // Properties
    public string Naam {get; set;}
    public string Type {get; set;}
    public string[] Ingredienten {get; set;}

    // Methods

    // Constructors
    public Product() {}

    public Product(string naam, string type)
    {
        this.naam = naam;
        this.type = type;
    }

    public Product(string naam, string type, string[] ingredienten)
    {
        this.naam = naam;
        this.type = type;
        this.ingredienten = ingredienten;
    }

}