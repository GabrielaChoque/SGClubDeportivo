using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGClubDeportivo.Data;

namespace SGClubDeportivo.Controlador
{
    class SecretariaController
    {
        BdClubDeportivoEntities _db = new BdClubDeportivoEntities();

        //public List<Secretaria> Listar(string pBuscar)
        //{
        //    return _db.Secretaria.Where(x => x.nom_secretaria.Contains(pBuscar)).ToList();
        //}

        //public bool Insertar(Data.Secretaria reg)
        //{
        //    _db.Secretaria.Add(reg);
        //    _db.SaveChanges();
        //    return true;
        //}
        //public bool Modificar(Data.Secretaria reg)
        //{
        //    _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
        //    return _db.SaveChanges() > 0;
        //}
        //public bool Eliminar(string pParametro)
        //{
        //    var reg = _db.Secretaria.Where(x => x.ci_secretaria == pParametro).FirstOrDefault();
        //    _db.Secretaria.Remove(reg);
        //    return _db.SaveChanges() > 0;
        //}
        //internal List<Secretaria> BuscarPorPK(string pCuenta)
        //{
        //    return _db.Secretaria.Where(x => x.ci_secretaria == pCuenta).ToList();
        //}
        
        //public string Autenticar(string pUser, string pPass) //metodo autenticar con parametro Administrativo y contraseña respectivamente
        //{
        //    try
        //    {
        //        //en una var "res" donde usamos de la base de datos usando la tabla PLantel Educativo donde x sea usado para uso de datos en tabla BD
        //        var res = _db.Secretaria.Where(x => x.ci_secretaria == pUser && x.contrasenia == pPass).SingleOrDefault(); //singleOrdefault mandará excepcion si existe mas de un Administrativo con lo mismos datos
        //        if (res != null) //si res es diferente de vacio
        //        {
        //            return "SECRETARIA";
        //        }
        //        else
        //            return "";
        //    }
        //    catch (Exception ex)
        //    {
        //        return "";
        //    }
        //}
        
        //public string nombreSecretaria(string pCarnet)
        //{
        //    string nom;

        //    using (var context = new BdClubDeportivoEntities())
        //    {
        //        var lista = context.Secretaria.Where(x => x.ci_secretaria == pCarnet).FirstOrDefault();
        //        nom = Convert.ToString(lista.nom_secretaria);

        //        return "Secretaria " + nom;
        //    }
        //}
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
