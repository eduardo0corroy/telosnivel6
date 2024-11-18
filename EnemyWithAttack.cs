public class EnemyWithAttack : Enemy
{
    private int attackPower;

    public EnemyWithAttack(int health, int velocity, int attackPower) : base(health, velocity)
    {
        this.attackPower = attackPower;
    }

    public void AttackPlayer()
    {
        Console.WriteLine($"Enemy attacks the player with {attackPower} power!");
    }

    public override void Move()
    {
        Console.WriteLine("EnemyWithAttack moves aggressively towards the player.");
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Attack Power: {attackPower}");
    }
}
