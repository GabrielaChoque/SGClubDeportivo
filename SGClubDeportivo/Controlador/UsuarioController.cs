using Microsoft.VisualBasic.ApplicationServices;
using SGClubDeportivo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClubDeportivo.Controlador
{
    public class UsuarioController
    {
        //CONTROLLER VIRGEN PARA CRUDS
        BdClubDeportivoEntities _db = new BdClubDeportivoEntities();

        public List<Usuarios> Listar(string pBuscar)
        {
            return _db.Usuarios.Where(x => x.Nombres.Contains(pBuscar)).ToList();
            //return _db.Usuarios.ToList();
        }

        public bool Insertar(Usuarios reg)
        {
            _db.Usuarios.Add(reg);
            _db.SaveChanges();
            return true;
        }
        public Usuarios Seleccionar(int id)
        {
            return _db.Usuarios.Find(id);
        }
        public bool Modificar(Usuarios reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }

        public bool Eliminar(int pParametro)
        {
            var reg = _db.Usuarios.Where(x => x.id == pParametro).FirstOrDefault();
            _db.Usuarios.Remove(reg);
            return _db.SaveChanges() > 0;
        }
        //HASTA ACA CONTROLLER VIRGEN
        public List<Usuarios> BuscarPorCI(string pCI)
        {
            return _db.Usuarios.Where(x => x.Username == pCI).ToList();
        }

        public string Autenticar(string pUser, string pPass)
        {
            try
            {
                var res = _db.Usuarios.Where(x => x.Username == pUser && x.Password == pPass).SingleOrDefault();
                if (res != null)
                {
                    if (res.Rol=="ADMINISTRATIVO")
                    {
                        return "ADMINISTRATIVO";
                    }
                    else
                    {
                        return "SECRETARIO";
                    }
                }
                else
                {
                    return "NO LOG";
                }
            }
            catch (Exception ex)
            {
                return "NO LOG";
            }
        }

        //public string NombreUsuario(string pCI)
        //{
        //    string nom;

        //    using (var context = new BDDeportivoEntities())
        //    {
        //        var usuario = context.Usuarios.Where(x => x.CIUsuario == pCI).FirstOrDefault();
        //        nom = Convert.ToString(usuario.Nombres);
        //        return "Usuario." + nom;
        //    }
        //}
        public Usuarios SeleccionarPorCI(string username, string password)
        {
            //return _db.Jugadores.Where(x => x.Ci_jugador==ci).FirstOrDefault();
            return _db.Usuarios.Where(x => x.Username == username && x.Password == password).SingleOrDefault();
        }
    }

}
public static class GlobalVariables
{
    public static string UsuarioActual { get; set; }
    public static string NomC { get; set; }
    public static string Rol { get; set; }
    public static int idUsuario { get; set; }
}

