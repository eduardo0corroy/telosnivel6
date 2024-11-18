using System;

public abstract class Enemy
{
    private int health;
    private int velocity;

    public Enemy(int health, int velocity)
    {
        this.health = health;
        this.velocity = velocity;
    }

    public void ReceiveDamage(int damage)
    {
        health -= damage;
        Console.WriteLine($"Enemy took {damage} damage. Remaining health: {health}");
        if (health < 0) health = 0;
    }

    public bool IsDead()
    {
        return health <= 0;
    }

    public abstract void Move();

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Health: {health}, Velocity: {velocity}");
    }

    public int GetHealth() => health;

    public int GetVelocity() => velocity;
}
