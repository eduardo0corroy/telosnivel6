public class BossEnemy : Enemy
{
    private int rageLevel;

    public BossEnemy(int health, int velocity) : base(health, velocity)
    {
        rageLevel = 0;
    }

    public void Infuriate()
    {
        rageLevel++;
        Console.WriteLine($"BossEnemy enters rage mode! Rage Level: {rageLevel}");
    }

    public override void Move()
    {
        Console.WriteLine("BossEnemy moves powerfully across the battlefield.");
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Rage Level: {rageLevel}");
    }
}
