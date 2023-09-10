using DAL.Implementations.Memory;
using DAL.Implementations.SqlServer;
using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{
    public sealed class FactoryDAL
    {
        #region Singleton
        private readonly static FactoryDAL _instance = new FactoryDAL();
        public static FactoryDAL Current { get { return _instance; } }
        private FactoryDAL() { }
        #endregion

        private String backend = ConfigurationManager.AppSettings["Backend"];

        public IGenericRepository<Cliente> GetClientesRepository()
        {
            switch (backend)
            {
                case "Memory":
                    return new ClienteMemoryRepository();
                case "SqlServer":
                    return new ClienteSqlServerRepository();
                default:
                    return null;
            }
        }

        public IUsuarioRepository GetUsuarioRepository()
        {
            switch (backend)
            {
                //case "Memory":
                  //  return new UsuarioMemoryRepository();
                case "SqlServer":
                    return new UsuarioRepository();
                default:
                    return null;
            }
        }
    }


}
