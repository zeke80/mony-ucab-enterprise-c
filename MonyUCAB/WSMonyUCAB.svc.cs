using MonyUCAB.DAO;
using MonyUCAB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MonyUCAB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WSMonyUCAB" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WSMonyUCAB.svc or WSMonyUCAB.svc.cs at the Solution Explorer and start debugging.
    public class WSMonyUCAB : IWSMonyUCAB
    {
        public int GetData(int value)
        {
            return 0;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public UsuarioDTO login(string user, string contra)
        {
            IUsuarioDAO usuario = new UsuarioDAOPsql();
            return new UsuarioDTO();
        }
    }
}
