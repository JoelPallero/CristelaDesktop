using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class NegNotas
    {
        private readonly DataNotas _dataNotas;

        public NegNotas()
        {
            _dataNotas = new DataNotas();
        }

        public int SaveNota(Notas notas)
        {
            return _dataNotas.SaveNota(notas);
        }

        public DataSet GetNotas(string accion)
        {
            return _dataNotas.GetNotas(accion);
        }

    }
}
