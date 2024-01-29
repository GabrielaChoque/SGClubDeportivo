using SGClubDeportivo.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGClubDeportivo.Controlador
{
    class JugadorController
    {

        BdClubDeportivoEntities _db = new BdClubDeportivoEntities();

        public List<Jugadores> Listar(string pBuscar)
        {
            return _db.Jugadores.Where(x => x.Nombres.Contains(pBuscar)).ToList();
        }

        public List<Jugadores> ListarJugadorci(string pBuscar)
        {
            return _db.Jugadores.Where(x => x.Ci_jugador.Contains(pBuscar)).ToList();
        }
        public Jugadores SeleccionarPorCI(string ci)
        {
            //return _db.Jugadores.Where(x => x.Ci_jugador==ci).FirstOrDefault();
            return _db.Jugadores.Where(x => x.Ci_jugador.Contains(ci)).FirstOrDefault();
        }
        public List<Jugadores> ListarPorCategoria(string pBuscarNombre, int pIdCategoria)
        {
            string c = "SELECT * FROM Jugadores WHERE Nombres LIKE '%" + pBuscarNombre + "%' AND id_categoria=" + Convert.ToString(pIdCategoria);
            return _db.Jugadores.SqlQuery(c).ToList();
        }
        public bool Insertar(Data.Jugadores reg)
        {
            _db.Jugadores.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Jugadores reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public Jugadores Seleccionar(int id)
        {
            return _db.Jugadores.Find(id);
        }
        public bool Eliminar(int pParametro)
        {
            var reg = _db.Jugadores.Where(x => x.id == pParametro).FirstOrDefault();
            _db.Jugadores.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Jugadores> BuscarPorPK(string pCuenta)
        {
            return _db.Jugadores.Where(x => x.Ci_jugador == pCuenta).ToList();
        }
    }
}
