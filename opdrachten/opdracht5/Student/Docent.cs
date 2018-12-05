using System;
using System.Collections;

namespace Student
{

  public class Docent : Persoon {
    public string Emailadres {get; set;}
    // Kan List niet vinden.
    public List<Opleiding> Opleidingen {get; set;}

    public override string GenereerWachtwoord() {
      return "Docent - Wachtwoord";
    }
  }
    
}