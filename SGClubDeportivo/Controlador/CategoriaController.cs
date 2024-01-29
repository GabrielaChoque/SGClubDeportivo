using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGClubDeportivo.Data;
using System.Windows.Forms;

namespace SGClubDeportivo.Controlador
{
    class CategoriaController
    {
        BdClubDeportivoEntities _db = new BdClubDeportivoEntities();
        //public void CargarCategoria(ComboBox cmb)
        //{
        //    var r = from Categoria in _db.Categorias
        //            select new
        //            {
        //                Categoria.id,
        //                Categoria.Nombre,
        //            };

        //    cmb.ValueMember = "id";
        //    cmb.DisplayMember = "Nombre";
        //    cmb.DataSource = r.ToList();
        //}
        public List<Categorias> Listar(string pBuscar)
        {
            return _db.Categorias.Where(x => x.Nombre.Contains(pBuscar)).ToList();
            //return _db.Usuarios.ToList();
        }
        public int ObtenerIdCategoria(string pNomCategoria)
        {
            using (var context = new BdClubDeportivoEntities())
            {

                var lista = context.Categorias.Where(x => x.Nombre == pNomCategoria).FirstOrDefault();
                return lista.id;

                //   MessageBox.Show("Error de Acceso de Datos","Error", MessageBoxButtons.OK,MessageBoxIcon.Warning)

            }        
        }

        public List<Categorias> ObtenerTodasCategorias()
        {
            return _db.Categorias.ToList();
        }

        public Categorias ObtenerCategoriaPorId(int id)
        {
            return _db.Categorias.Find(id);
        }
        public Categorias Seleccionar(int id)
        {
            return _db.Categorias.Find(id);
        }

        public bool AgregarCategoria(Categorias categoria)
        {
            _db.Categorias.Add(categoria);
            _db.SaveChanges();
            return true;
        }

        public bool ActualizarCategoria(Categorias categoria)
        {
            _db.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }

        public bool EliminarCategoria(int id)
        {
            var reg = _db.Categorias.Where(x => x.id == id).FirstOrDefault();
            _db.Categorias.Remove(reg);
            return _db.SaveChanges() > 0;
        }
    }
}
