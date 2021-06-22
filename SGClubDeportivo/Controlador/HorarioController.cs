using SGClubDeportivo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGClubDeportivo.Controlador
{
    /*Controlador del Horario
     *-------------- de 9 a 11 am.--------------
    [1,1]=[Lunes,9-11]
    [1,2]=[Martes,9-11]
    [1,3]=[Miercoles,9-11]
    [1,4]=[Jueves,9-11]
    [1,5]=[Viernes,9-11]
    --------------- de 11 a 13 hrs.---------------
    [2,1]=[Lunes,11-13]
    [2,2]=[Martes,11-13]
    [2,3]=[Miercoles,11-13]
    [2,4]=[Jueves,11-13]
    [2,5]=[Viernes,11-13]
     --------------- de 14 a 16 hrs.---------------
    [3,1]=[Lunes,14-16]
    [3,2]=[Martes,14-16]
    [3,3]=[Miercoles,14-16]
    [3,4]=[Jueves,14-16]
    [3,5]=[Viernes,14-16]
      --------------- de 16 a 18 hrs.---------------
    [4,1]=[Lunes,16-18]
    [4,2]=[Martes,16-18]
    [4,3]=[Miercoles,16-18]
    [4,4]=[Jueves,16-18]
    [4,5]=[Viernes,16-18]
    */
    class HorarioController

    {
        public int id { get; set; }
        public int idcategoria { get; set; }
        public string hora { get; set; }
        public string dia { get; set; }
        BdClubDeportivoEntities db = new BdClubDeportivoEntities();
      public  List<int> dias= new List<int> ();
      public   List<int> horas= new List<int>();

        public string Listardias(int idCategoria)
        {
            string result=""; int i = 0;
            string[] diasEntrenamiento = new string[4];
            var lsHorario = db.Horario.ToList();
            foreach (var dh in lsHorario)
            {
                if (dh.id_categoria == idCategoria) { 
                    diasEntrenamiento[i] = dh.dia;
                    switch(diasEntrenamiento[i])
                    {
                        case "Lunes": 
                            dias.Add(1);
                            break;
                        case "Martes":
                            dias.Add(2);
                            break;
                        case "Miercoles":
                            dias.Add(3);
                            break;
                        case "Jueves":
                            dias.Add(4);
                            break;
                        case "Viernes":
                            dias.Add(5);
                            break;
                    }
                    result = result + diasEntrenamiento[i]; 
                    i++;
                }
                else
                    i=i;
            }
            return result;
        }
        public string ListarHoras(int idCategoria)
        {
            string result = ""; int i = 0;
            string[] horasEntrenamiento = new string[4];
            var lsHorario = db.Horario.ToList();
            foreach (var dh in lsHorario)
            {
                if (dh.id_categoria == idCategoria)
                {
                    horasEntrenamiento[i] = dh.hora;
                    switch (horasEntrenamiento[i])
                    {
                        case "9":
                            horas.Add(1);
                            break;
                        case "11":
                            horas.Add(2);
                            break;
                        case "14":
                            horas.Add(3);
                            break;
                        case "16":
                            horas.Add(4);
                            break;
                    }
                    result = result+horasEntrenamiento[i];
                    i++;
                }
                else
                    i = i;
            }
            return result;
        }

    }
}
