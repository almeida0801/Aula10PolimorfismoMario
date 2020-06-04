namespace Aula10PolimorfismoMario
{
    public class Player
    {
        public virtual void Pular(){
            System.Console.WriteLine("O personagem pula normalmente");
        }

        public virtual void Correr(){
            System.Console.WriteLine("O personagem corre normalmente");
        }


    }
}