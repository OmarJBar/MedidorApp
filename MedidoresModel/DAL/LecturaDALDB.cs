using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class LecturaDALDB : ILecturaDAL
    {
        private MedidoresDBEntities1 lecturaDB = new MedidoresDBEntities1();
        public void AddLectura(Lectura lectura)
        {
            this.lecturaDB.Lecturas.Add(lectura);
            this.lecturaDB.SaveChanges();
        }

        public void DeleteLectura(int id)
        {
            this.lecturaDB.Lecturas.Remove(GetLectura(id));
            this.lecturaDB.SaveChanges();
        }
        public List<Lectura> GetLecturas()
        {
            return this.lecturaDB.Lecturas.ToList();
        }

        public Lectura GetLectura(int id)
        {
            return lecturaDB.Lecturas.Find(id);
        }


        public void UpdateLectura(Lectura lectura)
        {
            Lectura lectura1 = GetLectura(lectura.idLecturas);
            lectura1.date = lectura.date;
            lectura1.consumo = lectura.consumo;
            this.lecturaDB.SaveChanges();
        }
    }
}
