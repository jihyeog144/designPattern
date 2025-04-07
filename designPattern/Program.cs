namespace designPattern
{
    internal class Program
    {

        public class WeaponFactory
        {
            public float grade;
        }

        public Weapon Create(string name)
        {
            Weapon weapon;
            switch(name)
            {
                case "철검": weapon = new Weapon("철검", 7, 6) break;
                case "나무창": weapon = new Weapon("나무창", 3, 10) break;
                case "쇠도끼": weapon = new Weapon("쇠도끼", 8, 5) break;


            }

        weapon.attack = (int)(attack * grade);
            return; weapon


        }


        public class Weapon
        {
            string name;
            int attack;
            int range;

            public Weapon(string name, int attack, int range)
            {
                this.name = name;
                this.attack = attack;
                this.range = range;
            }
        }



        static void Main(string[] args)
        {
            WeaponFactory gradeweapon = new WeaponFactory();
            gradeweapon.grade = 1;

            Weapon weapon1 = gradeweapon.Create("철검");
            Weapon weapon1 = gradeweapon.Create("나무창");
            Weapon weapon1 = gradeweapon.Create("쇠도끼");



        }
    }
}
