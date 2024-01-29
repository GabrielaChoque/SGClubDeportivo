using SGClubDeportivo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClubDeportivo.Controlador
{
   
    public class EntrenamientoController
    {
        public string id { get; set; }
        public int idcategoria{ get; set; }
        public string ci { get; set; }
        public string primerdia { get; set; }
        public string segundodia { get; set; }
        public string primerhorario { get; set; }
        public string segundohorario { get; set; }
        BdClubDeportivoEntities db = new BdClubDeportivoEntities();

        
 
 
        //public bool InsertarEntrenamiento(Data.Entrenamiento reg)
        //{
        //    db.Entrenamiento.Add(reg);
        //    db.SaveChanges();
        //    return true;
        //}
        //public bool ModificarEntrenamiento(Data.Entrenamiento reg)
        //{
        //    db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
        //    return  db.SaveChanges() > 0;
        //}
        //public bool EliminarEntrenamiento(string pParametro)
        //{
        //    var reg = db.Entrenamiento.Where(x => x.ci_jugador == pParametro).FirstOrDefault();
        //    db.Entrenamiento.Remove(reg);
        //    return db.SaveChanges() > 0;
        //}

    }
}
