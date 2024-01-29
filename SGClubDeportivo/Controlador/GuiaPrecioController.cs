using SGClubDeportivo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClubDeportivo.Controlador
{
    internal class GuiaPrecioController
    {
        BdClubDeportivoEntities _db = new BdClubDeportivoEntities();

        public List<GuiaPrecios> Listar(string pBuscar)
        {
            return _db.GuiaPrecios.Where(x => x.Concepto.Contains(pBuscar)).ToList();
            //return _db.GuiaPrecios.ToList();
        }

        public bool Insertar(GuiaPrecios reg)
        {
            _db.GuiaPrecios.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public GuiaPrecios Seleccionar(int id)
        {
            return _db.GuiaPrecios.Find(id);
        }
        public bool Modificar(GuiaPrecios reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }

        public bool Eliminar(int pParametro)
        {
            var reg = _db.GuiaPrecios.Where(x => x.id == pParametro).FirstOrDefault();
            _db.GuiaPrecios.Remove(reg);
            return _db.SaveChanges() > 0;
        }
    }
}
