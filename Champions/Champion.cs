namespace Champions;

public class Champion
{
    public string Name { get; }
    public int BaseHp { get; }
    public int BaseDefense { get; }
    public int BaseAttack { get; }
    public int BaseSpeed { get; }
    
    public int CurrentHp { get; private set; }

    public bool IsAlive => CurrentHp > 0;

    public Champion(string name, int baseHp, int baseDefense, int baseAttack, int baseSpeed) // TODO: Ajouter les validations des données pour terminer mon constructeur.
    {
        Name = name;
        BaseHp = baseHp;
        BaseDefense = baseDefense;
        BaseAttack = baseAttack
        BaseSpeed = baseSpeed;
        
        CurrentHp = BaseHp;
    }
}