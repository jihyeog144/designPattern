
namespace designPattern
    {
    internal class Program
    {

        public class WeaponFactory
        {
            


            public Weapon Create(string name)
            {
                Weapon weapon;
                switch (name)
                {
                    case "철검": weapon = new Weapon("철검", 7, 6); break;
                    case "나무창": weapon = new Weapon("나무창", 3, 10); break;
                    case "쇠도끼": weapon = new Weapon("쇠도끼", 8, 5); break;
                    default: return null;
                }
                return weapon;
            }
        }
        public class GradeFactory
        {
                public float grade;


                public Grade Rare(float up)
                {
                Grade grade;
                    switch (up)
                    {
                        case 1: grade = new Grade("일반"); break;
                        case 2: grade = new Grade("희귀"); break;
                        case 3: grade = new Grade("전설"); break;
                        default: return null;
                    }
                return grade;


            }


            }
        
    

        

        public class Weapon
            {
                public string name;
                public int attack;
                public int range;

                public Weapon(string name, int attack, int range)
                {
                    this.name = name;
                    this.attack = attack;
                    this.range = range;
                }
            }



        public class Grade
        {
            string up;

            public Grade(string up)
            {
                this.up = up;
            }
        }


            static void Main(string[] args)
            {
                WeaponFactory weaponCase = new WeaponFactory();
                GradeFactory gradecase = new GradeFactory();
                gradecase.grade = 1;




            Weapon weapon1 = weaponCase.Create("철검");
                Weapon weapon2 = weaponCase.Create("나무창");
                Weapon weapon3 = weaponCase.Create("쇠도끼");
            Grade grade1 = gradecase.Rare(1);




            Console.Write($" {weapon1.name} ");
                Console.Write($" {weapon1.attack} ");
                Console.WriteLine($" {weapon1.range} ");


            }
        }
    }

