Wizard wizardA = new Wizard("Juye Horis", 20);
Wizard wizardB = new Wizard("Hegoes MgOes", 30);

Console.WriteLine("Permainan dimulai......\n");
wizardA.ShowStats();
wizardB.ShowStats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Heal();
wizardA.Attack(wizardB);

Console.WriteLine("Permainan berakhir....\n");
wizardA.ShowStats();
wizardB.ShowStats();

public class Wizard

{
    //deklarasi field
    public string Name;
    public int Energy;
    public int Damage;

    //deklarasi constructor
    public Wizard(string name,int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;

    }

    public void ShowStats()
    {
        Console.WriteLine("statistik wizard");
        Console.WriteLine($"Nama: {Name}, Energi: {Energy} \n");
    }
    public void Attack(Wizard wizardLawanObj)
    {
        //mengurangi energi wizardLawanObj sebesar damage
        wizardLawanObj.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang {wizardLawanObj.Name}");
        Console.WriteLine($"sisa energi {wizardLawanObj.Name} adalah {wizardLawanObj.Energy}");
    }
    public void Heal()
    {
        Energy += 5;
        if (Energy <= 100)
        {
           
            Console.WriteLine($"{Name} melakukan heal meningkatkan menjadi{Energy}" );
        }
        else
        {
            Energy = 100;
            Console.WriteLine("Energi sudah penuh");
        }
    }
   
}
