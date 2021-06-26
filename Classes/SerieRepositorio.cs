// Classe contendo os metodos obrigatorios da interface IRepositorio
// Metodos populados pela class serie
using System.Collections.Generic;


namespace SI_Cadastro
{
    // Herdado Inteface para armazenar dados de serie em uma list
    public class SerieRepositorio : IRepositorio<Serie>
    {

        // Criando um objeto aparti de um list
        private List<Serie> listarSerie = new List<Serie>();
        
        // Metodos ultilizando a list criada junto a um paramentro que será informado
        public void atualiza(int id, Serie entidade)
        {
            listarSerie[id] = entidade;
        }

        public void exclui(int id)
        {
            listarSerie[id].Excluir();
        }

        public void insere(Serie entidade)
        {
            listarSerie.Add(entidade);
        }

        public List<Serie> List()
        {
            return listarSerie;
        }

        public int Proximoid()
        {
            return listarSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listarSerie[id];
        }
    }

}