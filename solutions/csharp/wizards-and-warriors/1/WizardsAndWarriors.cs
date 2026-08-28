abstract class Character
{
    protected string characterType = "";
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }


    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
            return 10;
        else
            return 6;
    }
}

class Wizard : Character
{
    bool spellPrepared = false;
    public Wizard() : base("Wizard")
    {
    }


    public void PrepareSpell()
    {
        spellPrepared = true;
    }

    public override bool Vulnerable ()
    {
        if (spellPrepared)
            return false;
        else
            return true;
    }

    public override int DamagePoints(Character target)
    {
        if (spellPrepared)
            return 12;
        else
            return 3;
    }
}
