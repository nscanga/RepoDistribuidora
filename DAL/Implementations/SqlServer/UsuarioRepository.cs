using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.SqlServer
{
    public class UsuarioRepository : IUsuarioRepository
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Usuario] (Nombre, FechaNac) VALUES (@Nombre, @FechaNac)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Cliente] SET (Nombre = @Nombre, FechaNac = @FechaNac) WHERE  IdUsuario = @IdUsuario";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Cliente] WHERE IdUsuario = @IdUsuario";
        }

        private string SelectOneStatement
        {
            get => "SELECT IdUsuario , Nombre, FechaNac FROM [dbo].[Cliente] WHERE IdUsuario = @IdUsuario";
        }

        private string SelectAllStatement
        {
            get => "SELECT IdUsuario , Nombre, FechaNac FROM [dbo].[Cliente]";
        }
        #endregion

        public void Add(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException(); //ver baja logica 
        }

        public Usuario FindByEmail(string email)
        {
            // Implementar la lógica para buscar un usuario por correo electrónico
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }
        // Implementar otros métodos de IGenericRepository
    }

}
