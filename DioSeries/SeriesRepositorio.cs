using System;
using System.Collections.Generic;
using System.Text;

namespace DioSeries
{
    class SeriesRepositorio : iRepositorio<Series>
    {
        private List<Series> listaSeries = new List<Series>();
        public void Atualizar(int id, Series entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Series entidade)
        {
            throw new NotImplementedException();
        }

        public List<Series> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Series retornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
