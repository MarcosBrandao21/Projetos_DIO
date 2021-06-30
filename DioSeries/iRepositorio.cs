using System;
using System.Collections.Generic;
using System.Text;

namespace DioSeries
{
    interface iRepositorio<T>
    {
        List<T> Lista();

        T retornaPorId(int id);

        void Insere(T entidade);

        void Excluir(int id);

        void Atualizar(int id, T entidade);

        int ProximoId();
    }
}
