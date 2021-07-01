using System;
using System.Collections.Generic;
using System.Text;

namespace DioSeries
{
    interface IRepositorio<T>
    {
        List<T> Lista();

        T retornaPorId(int id);

        void Insere(T entidade);

        void Exclui(int id);

        void Atualizar(int id, T entidade);

        int ProximoId();
    }
}
