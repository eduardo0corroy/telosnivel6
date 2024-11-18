public class JumpingEnemy : Enemy
{
    private int jumpHeight;

    public JumpingEnemy(int health, int velocity, int jumpHeight) : base(health, velocity)
    {
        this.jumpHeight = jumpHeight;
    }

    public void Jump()
    {
        Console.WriteLine($"JumpingEnemy jumps {jumpHeight} meters high.");
    }

    public override void Move()
    {
        Console.WriteLine("JumpingEnemy moves by jumping.");
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Jump Height: {jumpHeight}");
    }
}
