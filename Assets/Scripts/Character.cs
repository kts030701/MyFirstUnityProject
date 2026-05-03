using UnityEngine;

public class Character
{
    string name;
    int hp;

    public Character(string characterName, int initialHP)
    {
        name = characterName;
        hp = initialHP;
    }

    public void Hit(int damage)
    {
        hp -= damage;
    }

    public void Heal(int heal)
    {
        hp += heal;
    }

    public bool IsAlive()
    {
        return hp > 0;
    }
}

