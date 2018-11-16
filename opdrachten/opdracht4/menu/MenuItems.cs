class MenuItem : Product
{
    // Fields
    private double waarde;
    private string valuta;

    // Properties
    public double Waarde {get; set;}
    public string Valuta {get; set;}

    // Methods
    public string ToString()
    {
        string productString =  "Het item " + this.Naam + " (" + this.Type;
        string prijsString = ") kost " + this.Waarde + " " + this.Valuta + ".";
        return productString + prijsString;
    }

    // Constructors
    public MenuItem() {}
    
    public MenuItem(string naam, string type, double waarde, string valuta)
    {
        this.Naam = naam;
        this.Type = type;
        this.Waarde = waarde;
        this.Valuta = valuta;
    }

    public MenuItem(string naam, string type, string[] ingredienten, double waarde, string valuta) 
    {
        this.Naam = naam;
        this.Type = type;
        this.Ingredienten = ingredienten;
        this.Waarde = waarde;
        this.Valuta = valuta;
    }
}