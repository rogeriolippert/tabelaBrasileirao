namespace tabelabrasileirao
{
    public class Campeonato
    {
        public List<Equipe> = equipe;

        public campeonato(){
            this.equipe = new List <Equipe>();

        }
        public void resultado(){
             this.equipe.foreach (delegate(Equipe e)){
             System.Console.WriteLine($"Equipe: {e.nome} - Pontuação: {e.pontuacao}");    
            }   
        }

        public void classificados(){
            switch (Equipe > 10)
            {
                case valor1:
                    // código 1
                break;
                case valor2:
                    // código 2
                break;
                default:
                    // código 3
                break;
            }
              
        }
    }
}