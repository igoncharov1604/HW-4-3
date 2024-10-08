using System;

public partial class Kafedra
{
    private string nazvaKafedry;
    private int kilkistVikladachiv;

    // Метод для встановлення назви кафедри
    public void VstanovytyNazvuKafedry(string nazva)
    {
        nazvaKafedry = nazva;
    }

    // Метод для встановлення кількості викладачів кафедри
    public void VstanovytyKilkistVikladachiv(int kilkist)
    {
        kilkistVikladachiv = kilkist;
    }

    // Метод для виведення інформації про кафедру
    public void InformaciaProKafedru()
    {
        Console.WriteLine($"Кафедра: {nazvaKafedry}, {kilkistVikladachiv} викладачів");
    }
}

public partial class Kafedra
{
    private string[] disciplines;

    // Індексатор для дисциплін кафедри
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < disciplines.Length)
            {
                return disciplines[index];
            }
            else
            {
                return "Невірний індекс";
            }
        }
        set
        {
            if (index >= 0 && index < disciplines.Length)
            {
                disciplines[index] = value;
            }
        }
    }

    // Конструктор для ініціалізації кафедри з кількістю дисциплін
    public Kafedra(int kilkistDiscyplin)
    {
        disciplines = new string[kilkistDiscyplin];
    }

    // Метод для виведення дисциплін кафедри
    public void VyvestyDiscipliny()
    {
        Console.WriteLine("Дисципліни кафедри:");
        for (int i = 0; i < disciplines.Length; i++)
        {
            Console.WriteLine($" - {disciplines[i]}");
        }
    }
}

class Fakultet
{
    private Kafedra kafedra1;
    private Kafedra kafedra2;

    // Конструктор для створення 2 кафедр
    public Fakultet()
    {
        kafedra1 = new Kafedra(3); // 3 дисципліни для кафедри 1
        kafedra2 = new Kafedra(2); // 2 дисципліни для кафедри 2
    }

    // Метод для виклику методів класу Кафедра
    public void VstanovytyDani()
    {
        // Встановлення даних для кафедри 1
        kafedra1.VstanovytyNazvuKafedry("Комп'ютерних наук та ІПЗ");
        kafedra1.VstanovytyKilkistVikladachiv(10);
        kafedra1[0] = "Програмування";
        kafedra1[1] = "Алгоритми та структури даних";
        kafedra1[2] = "Бази даних";

        // Встановлення даних для кафедри 2
        kafedra2.VstanovytyNazvuKafedry("Вищої математики");
        kafedra2.VstanovytyKilkistVikladachiv(5);
        kafedra2[0] = "Лінійна алгебра";
        kafedra2[1] = "Математичний аналіз";
    }

    // Метод для виведення інформації про факультет та кафедри
    public void InformaciaProFakultet()
    {
        Console.WriteLine("Факультет: Комп'ютерних наук");
        kafedra1.InformaciaProKafedru();
        kafedra1.VyvestyDiscipliny();
        kafedra2.InformaciaProKafedru();
        kafedra2.VyvestyDiscipliny();
    }
}

class Program
{
    static void Main()
    {
        // Створення факультету та виклик методів
        Fakultet fakultet = new Fakultet();
        fakultet.VstanovytyDani();
        fakultet.InformaciaProFakultet();
    }
}
