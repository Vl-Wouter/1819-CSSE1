public class Author 
{
  // Fields
  private string name;
  private string email;
  private char gender;

  // Properties
  public string Name 
  {
    get
    {
      return this.name;
    } 
    set {
      name = value;
    }
  }

  public string Email
  {
    get
    {
      return this.email;
    } 
    set {
      email = value;
    }
  }

  public char Gender
  {
    get
    {
      return this.gender;
    } 
    set {
      gender = value;
    }
  }
}