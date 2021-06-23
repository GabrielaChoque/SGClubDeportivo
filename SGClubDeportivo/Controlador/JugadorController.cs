using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGClubDeportivo.Data;

namespace SGClubDeportivo.Controlador
{
    class JugadorController
    {
        BdClubDeportivoEntities _db = new BdClubDeportivoEntities();

        public List<Jugador> Listar(string pBuscar)
        {
            return _db.Jugador.Where(x => x.nom_jugador.Contains(pBuscar)).ToList();
        }
        public List<Jugador> ListarPorCategoria(string pBuscarNombre, int pIdCategoria)
        {
            string c = "SELECT * FROM Jugador WHERE nom_jugador LIKE '%"+pBuscarNombre+"%' AND id_categoria="+Convert.ToString(pIdCategoria);
            return _db.Jugador.SqlQuery(c).ToList();
        }
        public bool Insertar(Data.Jugador reg)
        {
            _db.Jugador.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Jugador reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(string pParametro)
        {
            var reg = _db.Jugador.Where(x => x.ci_jugador == pParametro).FirstOrDefault();
            _db.Jugador.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Jugador> BuscarPorPK(string pCuenta)
        {
            return _db.Jugador.Where(x => x.ci_jugador == pCuenta).ToList();
        }
    }
}
