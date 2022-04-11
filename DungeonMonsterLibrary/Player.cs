using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMonsterLibrary
{
    public class Player : Character
    {
        //Fields


        //Properties
        public string CharacterRace { get; set; }

        public Weapon EquippedWeapon { get; set; }

        //constructor
        public Player(string name, int hitCHance, int block, int Life, int maxLife, string characterRace,
            Weapon equippedWeapon) : base(name, hitCHance, block, maxLife, Life)
        {

            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;



        }
        //Methods
        public override string ToString()
        {
            string description = "";

            

            return string.Format("-=-= {0} =-=-\n" +
                "Life: {1} of {2}\nHit Chance: {3}%\n" +
                "Weapon:\n{4}\nBlock: {5}\nDescription: {6}",
                Name,
                Life,
                MaxLife,
                HitChance,
                CalcHitChance(),
                Block,
                description);

        }

        public override int CalcDamage()
        {

            Random rand = new Random();

            int damage = rand.Next(EquippedWeapon.MinDamage,
                EquippedWeapon.MaxDamage + 1);

            return damage;        
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }






    }
}
