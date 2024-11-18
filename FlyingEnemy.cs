public class FlyingEnemy : Enemy
{
    private int altitude;

    public FlyingEnemy(int health, int velocity, int altitude) : base(health, velocity)
    {
        this.altitude = altitude;
    }

    public void Fly()
    {
        Console.WriteLine($"FlyingEnemy flies to an altitude of {altitude} meters.");
    }

    public override void Move()
    {
        Console.WriteLine("FlyingEnemy moves through the air.");
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Altitude: {altitude}");
    }
}
