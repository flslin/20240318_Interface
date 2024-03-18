interface IItem // 추상 클래스. new Item 못만듦
{
    public abstract void Use();
}

class Player
{
    public Player() 
    {
        
    }

    ~Player()
    {

    }

    public void Pickup(IItem pickedUpitem)
    {
        inventory.Add(pickedUpitem);
    }

    public void Use(int slot)
    {
        inventory[slot].Use();
    }

    List<IItem> inventory = new List<IItem> ();
}

class Sword : IItem
{
    public Sword()
    {

    }

    ~Sword()
    {

    }

    public void Use()
    {
        Console.WriteLine("칼을 휘두른다.");
    }
}

class Axe : IItem
{
    public Axe()
    {

    }

    ~Axe()
    {

    }

    public void Use()
    {
        Console.WriteLine("도끼를 던진다.");
    }
}

class Gem : IItem
{
    public Gem()
    {

    }

    ~Gem()
    {

    }

    public void Use()
    {
        Console.WriteLine("보석을 착용한다.");
    }
}

class Gun : IItem
{
    public Gun()
    {

    }

    ~Gun()
    {

    }

    public void Use()
    {
        Console.WriteLine("총을 쏜다.");
    }
}

class Potion : IItem//, Eatable, Use
{
    public Potion()
    {

    }

    ~Potion()
    {

    }

    public void Use()
    {
        Console.WriteLine("포션을 마신다.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Sword, Axe, Gem, Gun, Potion
        Player player = new Player ();

        player.Pickup(new Sword());
        player.Pickup(new Axe());
        player.Pickup(new Gem());
        player.Pickup(new Gun());
        player.Pickup(new Potion());

        player.Use(0);
        player.Use(1);
        player.Use(2);
        player.Use(3);
        player.Use(4);
    }
}

