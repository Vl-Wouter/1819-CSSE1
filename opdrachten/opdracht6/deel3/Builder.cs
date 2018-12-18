using System;

namespace deel3
{
  public interface IKoffie
  {
    void stap1();
    void stap2();
    void stap3();
    void stap4();

    Koffie GetKoffie();
  }

  public class EspressoBrewer : IKoffie
  {
    private Koffie _koffie = new Koffie();

    public void stap1() {
      _koffie.stap1 = "Neem ongeveer 7 gram koffie";
    }

    public void stap2() {
      _koffie.stap2 = "Zet een lege kop onder de koffie";
    }

    public void stap3() {
      _koffie.stap3 = "Stuw water van 95 graden door de koffie en in de kop"
    }

    public void stap4() {
      _koffie.stap4 = "Geniet van je koffie";
    }

    public Koffie GetKoffie() {
      return _koffie;
    }
  }

  public class Koffie
  {
    public string stap1 {get; set;}
    public string stap2 {get; set;}
    public string stap3 {get; set;}
    public string stap4 {get; set;}

    public void ShowSteps()
    {
      Console.WriteLine("Stap 1: {0}", stap1);
      Console.WriteLine("Stap 2: {0}", stap2);
      Console.WriteLine("Stap 3: {0}", stap3);
      Console.WriteLine("Stap 4: {0}", stap4);
    }
  }
}