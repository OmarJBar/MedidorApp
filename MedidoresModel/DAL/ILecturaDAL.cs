using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface ILecturaDAL
    {
        //c
        void AddLectura(Lectura lectura);
        //r
        List<Lectura> GetLecturas();//all
        Lectura GetLectura(int id);//find
        //u
        void UpdateLectura(Lectura lectura);
        //d
        void DeleteLectura(int id);


    }
}
