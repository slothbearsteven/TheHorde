namespace TheHorde.Models
{
  public abstract class Card
  {
    public string Name { get; set; }
    public int ManaCost { get; set; }

    public string Description { get; set; }
    public string Color { get; set; }

    public string Type { get; set; }



    public Card(string name, int cost, string desc, string color, string type)
    {
      Name = name;
      ManaCost = cost;
      Description = desc;
      Color = color;
      Type = type;
    }
  }


}