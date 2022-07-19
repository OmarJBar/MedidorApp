using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public interface IMedidorDAL
    {
        //c
        void AddMedidor(Medidore medidor);
        //r
        List<Medidore> Getmedidores();// all
        Medidore GetMedidor(int id);//find 

        //u
        void UpdateMedidor(Medidore medidor);
        //d
        void DeleteMedidor(int id);

        List<Medidore> FilterMedidor(string tipo);
    }
}
