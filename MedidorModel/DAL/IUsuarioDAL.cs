using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public interface IUsuarioDAL
    {
        //c
        void AddUsuario(Usuario usuario);
        //r
        List<Usuario> GetUsuarios();
        Usuario GetUsuario(string rut);
        //u
        void UpdateUsuario(Usuario usuario);
        //d
        void DeleteUsuario(string rut);
    }
}
