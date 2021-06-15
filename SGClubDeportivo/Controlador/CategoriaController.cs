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
        public void CargarCategoria(ComboBox cmb)
        {
            var r = from Categoria in _db.Categoria
                    select new
                    {
                        id_categoria = Categoria.id_categoria,
                        nom_categoria = Categoria.nom_categoria
                    };

            cmb.ValueMember = "id_categoria";
            cmb.DisplayMember = "nom_categoria";
            cmb.DataSource = r.ToList();
        }

        public int ObtenerIdCategoria(string pNomCategoria)
        {
            using (var context = new BdClubDeportivoEntities())
            {
                var lista = context.Categoria.Where(x => x.nom_categoria == pNomCategoria).FirstOrDefault();
                return lista.id_categoria;
            }
        }
    }
}
