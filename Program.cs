using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Criando inimigos
        EnemyWithAttack enemy1 = new EnemyWithAttack(100, 10, 15);
        FlyingEnemy enemy2 = new FlyingEnemy(80, 12, 5);
        JumpingEnemy enemy3 = new JumpingEnemy(90, 8, 3);
        BossEnemy boss = new BossEnemy(200, 5);

        // Exibindo status
        Console.WriteLine("=== Enemy 1 (With Attack) ===");
        enemy1.DisplayStatus();
        enemy1.Move();
        enemy1.AttackPlayer();
        enemy1.ReceiveDamage(20);

        Console.WriteLine("\n=== Enemy 2 (Flying) ===");
        enemy2.DisplayStatus();
        enemy2.Move();
        enemy2.Fly();
        enemy2.ReceiveDamage(30);

        Console.WriteLine("\n=== Enemy 3 (Jumping) ===");
        enemy3.DisplayStatus();
        enemy3.Move();
        enemy3.Jump();
        enemy3.ReceiveDamage(10);

        Console.WriteLine("\n=== Boss Enemy ===");
        boss.DisplayStatus();
        boss.Move();
        boss.Infuriate();
        boss.ReceiveDamage(50);

        Console.WriteLine("\n=== Verificando se os inimigos estão mortos ===");
        Console.WriteLine($"Enemy 1 is dead: {enemy1.IsDead()}");
        Console.WriteLine($"Enemy 2 is dead: {enemy2.IsDead()}");
        Console.WriteLine($"Enemy 3 is dead: {enemy3.IsDead()}");
        Console.WriteLine($"Boss is dead: {boss.IsDead()}");
    }
}
