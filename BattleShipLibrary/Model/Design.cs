namespace BattleShipLibrary.Design
{
   public  class design
    {
        public static string CenterText(string text)
        {
           int spaces=(Console.WindowWidth-text.Length)/2;
           if(spaces<0)
           spaces=0;
           return new string(' ',spaces)+text; 
        }
    }
}
