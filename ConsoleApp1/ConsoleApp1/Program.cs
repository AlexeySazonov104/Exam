using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

/* 
 * ООП - принцип программироваания при котором программа представленна в виде объектов, взаимодействующих друг с другом.
 * Инкапсуляция - размещение методов и данных в одном компоненте (например в классе).
 * Наследование - это когда класс создаётся на основе другого класса и наследует его методы и свойства.
 * Полиморфизм - способность функций обрабатывать данные разного типа.
*/

/* 
* This - это ключевое слово используемое как модификатор параметра, оно указывает на текущий экземпляр.
* Constructor - это 
* New - это оператор, который создает экземпляр указанного типа.
* Super - это ключевое слово необходимое для доступа к данным базового класса из класса наследника
*/



namespace ConsoleApp1
{
    class Tools
    {
        public double health;
        public double speed;
        public double damage;
        public string material;

        public Tools(double health, double speed, double damage, string material)
        {
            this.health = health;
            this.speed = speed;
            this.damage = damage;
            this.material = material;
        }

        public virtual string info()
        {
            return "Health=" + this.health + " Speed=" + this.speed + " Damage=" + this.health + " Material=" + this.material;
        }

    }

    class Topor : Tools
    {
        public Topor(double health, double speed, double damage, string material) : base (health, speed, damage, material)
        {
            this.health = health;
            this.speed = speed;
            this.damage = damage;
            this.material = material;
        }
        public void Rubit() 
        {
            Console.WriteLine("Этот топор состоит из {0} имеет прочность {1}, скорость {2} и может нанести {3} единицы урона", this.material, this.health, this.speed, this.damage);
        }
    }

    class Kirka : Tools
    {
        public Kirka(double health, double speed, double damage, string material) : base(health, speed, damage, material)
        {
            this.health = health;
            this.speed = speed;
            this.damage = damage;
            this.material = material;
        }
        public void Lomat() 
        {
            Console.WriteLine("Эта кирка состоит из {0} имеет прочность {1}, скорость {2} и может нанести {3} единицы урона", this.material, this.health, this.speed, this.damage);
        }
    }

    class Lopata : Tools
    {
        public Lopata(double health, double speed, double damage, string material) : base(health, speed, damage, material)
        {
            this.health = health;
            this.speed = speed;
            this.damage = damage;
            this.material = material;
        }
        public void Kopat() 
        {
            Console.WriteLine("Эта лопата состоит из {0} имеет прочность {1}, скорость {2} и может нанести {3} единицы урона", this.material, this.health, this.speed, this.damage);
        }
    }

    class Motiga : Tools
    {
        public Motiga(double health, double speed, double damage, string material) : base(health, speed, damage, material)
        {
            this.health = health;
            this.speed = speed;
            this.damage = damage;
            this.material = material;
        }
        public void Rihlit() 
        {
            Console.WriteLine("Эта мотыга состоит из {0} имеет прочность {1}, скорость {2} и может нанести {3} единицы урона", this.material, this.health, this.speed, this.damage);
        }
    }

    //--------------------------------------Задача_2-----------------------------------------------------------------

    class Program
    {
        static void Main(string[] args)
        {
            Topor goldT = new Topor(30,30,1,"Золото");
            Topor woodT = new Topor(10,10,0.8,"Дерево" );
            Topor steelT = new Topor (60,20,1.2,"Сталь" );

            goldT.Rubit();
            woodT.Rubit();
            steelT.Rubit();

            Kirka goldK = new Kirka(30,40,0.8,"Золото");
            Kirka woodK = new Kirka(10,8,0.5,"Дерево");
            Kirka steelK = new Kirka(60,20,1,"Сталь");

            goldK.Lomat();
            woodK.Lomat();
            steelK.Lomat();

            Lopata goldL = new Lopata(30,10,1,"Золото");
            Lopata woodL = new Lopata(10,5,0.5,"Дерево");
            Lopata steelL = new Lopata(60,15,1.5,"Сталь");

            goldL.Kopat();
            woodL.Kopat();
            steelL.Kopat();

            Motiga goldM = new Motiga(30,5,0.7,"Золото");
            Motiga woodM = new Motiga(10,3,0.3,"Дерево");
            Motiga steelM = new Motiga(60,8,0.8,"Сталь");

            goldM.Rihlit();
            woodM.Rihlit();
            steelM.Rihlit();


            //--------------------------------------Задача_2-----------------------------------------------------------------

            /*string[] pokupki;
            double cost;
            using (var sr = new StreamReader(@"C:\Users\alexe\Desktop\text.txt"))
            while (!sr.EndOfStream)
            {
                    pokupki = sr.ReadLine().ToLower().Split("Id = 1:".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            }
            */
        }
    }
}
