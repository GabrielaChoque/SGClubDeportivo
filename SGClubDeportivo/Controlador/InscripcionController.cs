using SGClubDeportivo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClubDeportivo.Controlador
{
    internal class InscripcionController
    {
        BdClubDeportivoEntities _db = new BdClubDeportivoEntities();

        public List<Inscripciones> Listar(string pBuscar)
        {
            return _db.Inscripciones.Where(x => x.Correlativo.Contains(pBuscar)).ToList();
            //return _db.Inscripciones.ToList();
        }

        public bool Insertar(Inscripciones reg)
        {
            _db.Inscripciones.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public Inscripciones Seleccionar(int id)
        {
            return _db.Inscripciones.Find(id);
        }
        public bool Modificar(Inscripciones reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }

        public bool Eliminar(int pParametro)
        {
            var reg = _db.Inscripciones.Where(x => x.id == pParametro).FirstOrDefault();
            _db.Inscripciones.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        //public List<Inscripciones> BuscarPorIdJugador(int idJugador)
        //{
        //    return _db.Inscripciones.Where(x => x.Jugador_id == idJugador).ToList();
        //}
        public Inscripciones BuscarPorIdJugador(int idJugador)
        {
            return _db.Inscripciones.FirstOrDefault(x => x.Jugador_id == idJugador);
        }

    }
}
