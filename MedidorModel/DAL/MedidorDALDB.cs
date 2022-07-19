using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public class MedidorDALDB : IMedidorDAL
    {
        private MedidoreDBEntities2 medidorDB = new MedidoreDBEntities2();

        public void AddMedidor(Medidore medidor)
        {
            this.medidorDB.Medidores.Add(medidor);
            this.medidorDB.SaveChanges();
        }


        public Medidore GetMedidor(int id)
        {
            return this.medidorDB.Medidores.Find(id);
        }

        public List<Medidore> Getmedidores()
        {
            return this.medidorDB.Medidores.ToList();
        }

        public void UpdateMedidor(Medidore medidor)
        {
            Medidore medidor1 = GetMedidor(medidor.idMedidores);
            medidor1.tipo = medidor.tipo;
            this.medidorDB.SaveChanges();
        }
        public void DeleteMedidor(int id)
        {
            this.medidorDB.Medidores.Remove(GetMedidor(id));
            this.medidorDB.SaveChanges();
        }
        public List<Medidore> FilterMedidor(string filter)
        {
            var query = from a in this.medidorDB.Medidores where a.tipo == filter select a;
            return query.ToList(); 
        }
    }
}
