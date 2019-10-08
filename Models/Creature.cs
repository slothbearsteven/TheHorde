using TheHorde.Interfaces;

namespace TheHorde.Models
{
  public class Creature : Card, IPermanent, ICreature
  {

    public bool OnField { get; set; }
    public int Toughness { get; set; }
    public int Power { get; set; }
    public string Subtype { get; set; }


    public Creature(string name, int cost, string desc, string color, string type, int toughness, int power, string sub) : base(name, cost, desc, color, type)
    {
      Toughness = toughness;
      Power = power;
      Subtype = sub;
      OnField = true;
    }
  }
}