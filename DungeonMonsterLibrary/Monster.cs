namespace DungeonMonsterLibrary
{
    public class Monster : Character//Monster Class
    {

        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage 
        {
        
         get { return _minDamage; }
            set
            {
                if (value > 0 && value < MaxDamage)
                {
                    _minDamage = value;
                    
                }
                else
                {
                    _minDamage = 1;
                }
            }
        
        }     
        
        public Monster(string name, int life, int maxLife, int hitChance, int block, int maxDamage,
            int minDamage, string descrpition) : base(name, hitChance, block, maxLife, life)
        {

            MaxDamage= maxDamage;
            MinDamage= minDamage;
            Description = descrpition;
        }

        

        public override string ToString()
        {
            return String.Format("\n******** MONSTER *********\n" +
                "{0}\nLIfe: {1} of {2}\nDamage: {3} to {4}\n" +
                "Block: {5}\nDescription:\n{6}\n",
                Name, Life, MaxLife, MinDamage, MaxDamage, Block, Description);
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }




    }// end class
}//end Namespace