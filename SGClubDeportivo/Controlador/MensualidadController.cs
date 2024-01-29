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
            return _db.Mensualidades.Where(x => x.Concepto.Contains(pBuscar)).ToList();
            //return _db.Mensualidades.ToList();
        }

        public bool Insertar(Mensualidades reg)
        {
            _db.Mensualidades.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public Mensualidades Seleccionar(int id)
        {
            return _db.Mensualidades.Find(id);
        }
        public bool Modificar(Mensualidades reg)
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
        //---//
        public List<Mensualidades> CargarJugadoresConMensualidades(string Ci_jug)
        {
            var result = _db.Mensualidades
                .Join(_db.Inscripciones, mensualidad => mensualidad.Inscripcion_id, inscripcion => inscripcion.id, (mensualidad, inscripcion) => new { mensualidad, inscripcion })
                .Join(_db.Jugadores, r => r.inscripcion.Jugador_id, jugador => jugador.id, (r, jugador) => new { r.mensualidad, r.inscripcion, jugador })
                .Where(r => r.jugador.Ci_jugador.Contains(Ci_jug))
                .Select(r => r.mensualidad)  // Seleccionar solo las mensualidades
                .ToList();

            return result;
        }

    }
}
