namespace PROJETO2.src.Entities
{
    public class Knight : Hero
    {
       public Knight(string Name, int Level, string HeroType)
        {
           this.Name = Name;
           this.Level = Level;
           this.HeroType = HeroType; 
        }
        public override string Attack()
        {
            return this.Name + " Contra-atacou";
        }  
    }
}