namespace Corman.Models;


public class Neighborhood: BaseModel
{
  public string Name { get; set;}
  public string City { get; set;}
  public string State { get; set;}

  public virtual ICollection<Location> Locations { get; set;}

  public Neighborhood()
  {
    Locations = new HashSet<Location>();
  }
}