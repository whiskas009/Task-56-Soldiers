using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_56_Soldiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>(){
            new Soldier("Антон", "АК-47", "Рядовой", 1),
            new Soldier("Денис", "СКС", "Сержант", 24),
            new Soldier("Макс", "ПМ", "Ефрейтор", 6),
            new Soldier("Артём", "ТТ", "Лейтенант", 120),
            new Soldier("Лиза", "Мосина", "Прапорщик", 72)};

            var titles = soldiers.Select(soldier => new {Name = soldier.Name, Titles = soldier.Title});

            foreach (var title in titles)
            {
                Console.WriteLine($"{title.Name} - {title.Titles}");
            }
        }
    }

    class Soldier
    {
        public string Name { get; private set; }
        public string Weapon { get; private set; }
        public string Title { get; private set; }
        public int ServiceLife { get; private set; }

        public Soldier(string name, string weapon, string title, int serviceLife)
        {
            Name = name;
            Weapon = weapon;
            Title = title;
            ServiceLife = serviceLife;
        }
    }
}
