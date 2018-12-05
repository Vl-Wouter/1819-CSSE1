namespace Student
{
  public class Opleiding : IInformatie
  {

    private string afkortingCampus;
    protected int campusNummer;
    public string Campus {get; set;}
    public string Opleidingsnaam {get; set;}

    public Opleiding() 
    {
      this.afkortingCampus = this.Campus.Substring(0,3).ToUpper();
    }

    string GetWifiCode() 
    {
      return "code";
    }

    public string ToString()
    {
      return string.Format("Campus {0} - campusNummer {1}", this.Campus, this.campusNummer);
    }
  } 
}