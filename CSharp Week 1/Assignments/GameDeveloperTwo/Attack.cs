class Attack
{
    private string Name;
    public string _Name
    {
        get { return Name; }
    }

    private int DamageDelt;
    public int _DamageDelt
    {
        get { return DamageDelt; }
        set { DamageDelt = value; }
    }
    public Attack(string name, int damagedelt)
    {
        Name = name;
        DamageDelt = damagedelt;
    }
}