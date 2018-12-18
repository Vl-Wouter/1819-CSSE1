using System;

namespace deel3 
{
  public interface IVorm
  {
    void Teken();
  }

  public class Cirkel : IVorm
  {
    public void Teken() 
    {
      Console.WriteLine("Teken een cirkel");
    }
  }

  public class Rechthoek : IVorm
  {
    public void Teken() 
    {
      Console.WriteLine("Teken een rechthoek");
    }
  }

  public class Parallellogram : IVorm
  {
    public void Teken() 
    {
      Console.WriteLine("Teken een parallellogram");
    }
  }

  public abstract class VormFactory
  {
    public abstract IVorm GetVorm(string vorm);
  }

  public class ConcreteVormFactory : VormFactory
  {
    public override IVorm GetVorm(string vorm)
    {
      switch (vorm)
      {
        case "Cirkel" : return new Cirkel();
        case "Rechthoek": return new Rechthoek();
        case "Parallellogram": return new Parallellogram();
        default: throw new ApplicationException(string.Format("Vorm '{0}' kan niet aangemaakt worden", vorm));
      }
    }
  }

}