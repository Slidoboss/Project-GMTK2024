using System;

public class HealthSystem
{
    private int _health;
    private int _maxHealth;
    private bool _isAlive = true;

    public bool IsAlive
    {
        get { return _isAlive; }
    }
    public int GetHealth
    {
        get { return _health;}
    }
    public HealthSystem(int maxHealth)
    {
        this._maxHealth = maxHealth;
        _health = maxHealth;
    }

    public void Damage(int damageAmount)
    {
        _health -= damageAmount;
        if (_health <= 0)
        {
            _health = 0;
            _isAlive = false;
        }
    }
    public void Heal(int healAmount)
    {
        _health += healAmount;
        if (_health > _maxHealth) _health = _maxHealth;
    }
}