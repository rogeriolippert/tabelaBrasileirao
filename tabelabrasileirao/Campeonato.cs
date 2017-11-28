using System.Collections.Generic;

namespace tabelabrasileirao
{
    public class Campeonato
    {
        public List<Equipe> equipe;
        const int quantidadeRebaixados = 2;

        public Campeonato(){
            this.equipe = new List<Equipe>();
        }

        public void resultado() {
            string detalhe = "";
            for(int i = 0; i < this.equipe.Count; i++) {
                detalhe = "";
                if (i == 0)
                    detalhe = " - Campeão";
                if (i >= this.equipe.Count - quantidadeRebaixados)
                    detalhe = " - Rebaixado";
                System.Console.WriteLine($"Equipe: {this.equipe[i].nome} - Pontuação: {this.equipe[i].pontuacao} {detalhe}");
            };        
        }

            public void ordenaPontuacao() {
            this.equipe.Sort((x, y) => y.pontuacao.CompareTo(x.pontuacao));
        }

    }
}