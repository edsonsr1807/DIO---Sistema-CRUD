// Interface criada pra criar uma regra de classe os seja ao ser herdado a interface é obrigadorio ter
// os metodos ultilizados
using System.Collections.Generic;
namespace SI_Cadastro{

  public interface IRepositorio<T>
  {
    List<T> List();

    T RetornaPorId(int id);

    void insere(T entidade);

    void exclui(int id);

    void atualiza(int id, T entidade);

    int Proximoid();
  }

}