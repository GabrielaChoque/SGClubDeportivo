using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGClubDeportivo.Data;

namespace SGClubDeportivo.Controlador
{
    class AdministradorController
    {
        BdClubDeportivoEntities _db = new BdClubDeportivoEntities();

        public List<Administrador> Listar(string pBuscar)
        {
            return _db.Administrador.Where(x => x.nom_admin.Contains(pBuscar)).ToList();
        }
       
        public bool Insertar(Data.Administrador reg)
        {
            _db.Administrador.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public bool Modificar(Data.Administrador reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Eliminar(string pParametro)
        {
            var reg = _db.Administrador.Where(x => x.ci_admin == pParametro).FirstOrDefault();
            _db.Administrador.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        internal List<Administrador> BuscarPorPK(string pCuenta)
        {
            return _db.Administrador.Where(x => x.ci_admin == pCuenta).ToList();
        }
        
        public string Autenticar(string pUser, string pPass) //metodo autenticar con parametro Administrativo y contraseña respectivamente
        {
            try
            {
                //en una var "res" donde usamos de la base de datos usando la tabla PLantel Educativo donde x sea usado para uso de datos en tabla BD
                var res = _db.Administrador.Where(x => x.ci_admin == pUser && x.contrasenia == pPass).SingleOrDefault(); //singleOrdefault mandará excepcion si existe mas de un Administrativo con lo mismos datos
                if (res != null) //si res es diferente de vacio
                {
                    return "ADMINISTRATIVO";
                }
                else
                    return "";
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        
        public string nombreAdmin(string pCarnet)
        {
            string nom;

            using (var context = new BdClubDeportivoEntities())
            {
                var lista = context.Administrador.Where(x => x.ci_admin == pCarnet).FirstOrDefault();
                nom = Convert.ToString(lista.nom_admin);
                
                return "Admin."+nom ;
            }
        }
        /*
        public int CiPlantel(string pUser, string pPass)
        {
            using (var context = new BdClubDeportivoEntities())
            {
                var lista = context.Administrador.Where(x => x.ci_admin == pUser && x.contrasenia == pPass).FirstOrDefault();
                return lista.ci_admin;
            }
        }*/
    }
}
