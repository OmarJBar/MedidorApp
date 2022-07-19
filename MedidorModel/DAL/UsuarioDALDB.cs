using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public class UsuarioDALDB : IUsuarioDAL
    {
        private MedidoreDBEntities2 usuarioDB = new MedidoreDBEntities2();
        public void AddUsuario(Usuario usuario)
        {
            this.usuarioDB.Usuarios.Add(usuario);
            this.usuarioDB.SaveChanges();
        }

        public void DeleteUsuario(string rut)
        {            
            this.usuarioDB.Usuarios.Remove(GetUsuario(rut));
            this.usuarioDB.SaveChanges();
        }
        
        public Usuario GetUsuario(string rut) //Find user
        {
            return this.usuarioDB.Usuarios.Find(rut);
        }

        public List<Usuario> GetUsuarios() //All user
        {
            return this.usuarioDB.Usuarios.ToList();
        }

        public void UpdateUsuario(Usuario usuario)
        {
            Usuario usuario1 = GetUsuario(usuario.rut);
            usuario1.username=usuario.username;
            usuario1.passwd=usuario.passwd;
            this.usuarioDB.SaveChanges(); 
        }
    }
}
