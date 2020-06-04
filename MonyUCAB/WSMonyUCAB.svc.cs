using MonyUCAB.DAO;
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
        public string GetData(int value)
        {
            IUsuarioDAO usuario = new UsuarioDAOPsql();
            return usuario.buscar()[0].Usuario;
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
    }
}
