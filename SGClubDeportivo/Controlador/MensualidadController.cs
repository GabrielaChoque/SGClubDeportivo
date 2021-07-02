using SGClubDeportivo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClubDeportivo.Controlador
{
    class MensualidadController
    {

        BdClubDeportivoEntities _db = new BdClubDeportivoEntities();

        public List<Mensualidades> Listar(string pBuscar)
        {
            return _db.Mensualidades.Where(x => x.ciJugador.Contains(pBuscar)).ToList();
        }
        public bool Insertar(Data.Mensualidades reg)
        {
            _db.Mensualidades.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Mensualidades reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(int pParametro)
        {
            var reg = _db.Mensualidades.Where(x => x.id == pParametro).FirstOrDefault();
            _db.Mensualidades.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        //internal List<Mensualidades> BuscarPorCI(string pCi)
        //{
        //    return _db.Mensualidades.Where(x => x.Ci == pCi).ToList();
        //}
    }
}
