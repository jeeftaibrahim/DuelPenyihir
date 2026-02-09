Wizard wizardA = new Wizard("Juye Horis", 20);
Wizard wizardB = new Wizard("Hegoes MgOes", 30);

Console.WriteLine("Permainan dimulai......\n");
wizardA.ShowStats();
wizardB.ShowStats();

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);
//wizardA.Heal();
//wizardA.Attack(wizardB);
string pilihan;
while (wizardA.Energy > 0 && wizardB.Energy > 0)
{
    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} melakukan heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan heal");

    Console.Write("\nmasukan pilihanmu (1/2/3/4): ");
    pilihan = Console.ReadLine();

    if ( pilihan == "1")
    {
        wizardA.Attack(wizardB);
    }
    else if (pilihan == "2")
    {
        wizardB.Attack(wizardA);
    }
    else if ( pilihan == "3")
    {
        wizardA.Heal();
    }
    else if ( pilihan == "4")

    {
        wizardB.Heal();
    }
    else
    {
        Console.WriteLine("pilihan tidak valid");
    }
}

Console.WriteLine("Permainan berakhir....\n");
Console.WriteLine("statistik akhir");
wizardA.ShowStats();
wizardB.ShowStats();

if (wizardA.Energy < wizardB.Energy)
{
    Console.WriteLine($"{wizardB.Name} memenangkan duel");
}
else 
{
    Console.WriteLine($"{wizardB.Name} memenangkan duel");
}

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
        Energy = 50;
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
        if (Energy <= 50)
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
