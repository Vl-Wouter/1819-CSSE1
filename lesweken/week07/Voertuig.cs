class Voertuig 
{
  // Fields
  private int laadvermogen;
  private bool motor;
  private string kleur;
  // Methods
  // ...  
  // Properties
  public int Laadvermogen 
  {
    get
    {
      return laadvermogen;
    }
    set
    {
      laadvermogen = value;
    }
  }

  public bool Motor {get; set;}

  public string Kleur {get; set;}

  public Voertuig(int laadvermogen, string kleur) {
    Laadvermogen = laadvermogen;
    Kleur = kleur;
    
  }

  // Constructors
  public Voertuig() 
  {    
  }

  public string ToString() 
  {
    return "Voertuig met laadvermogen " + this.laadvermogen + ", met kleur " + this.kleur;
  }
}