using TheHorde.Interfaces;

namespace TheHorde.Models
{
  public class Enchantment : Card, IPermanent
  {
    public bool OnField { get; set; }

    public Enchantment(string name, int cost, string desc, string color, string type) : base(name, cost, desc, color, type)
    {
      OnField = true;
    }

  }
}