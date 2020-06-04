namespace Aula10PolimorfismoMario
{
    public class Luigi : Player
    {
        public override void Pular(){

            // Aproveitamos as ações da nossa superclasse
            base.Pular();

            //Adicionando novas ações para Luigi
            System.Console.WriteLine("O Luigi consegue pular 40% mais alto do que normalmente pularia!");
            
        }
    }
}