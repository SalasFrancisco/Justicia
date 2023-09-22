using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;

namespace Profugos
{
    class Profugos
    {
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;

        public Profugos()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=C:\\Users\\Alumno\\source\\repos\\Profugos\\bin\\Debug\\JUSTICIA.mdb");
            comando = new OleDbCommand();
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Profugos";

            adaptador.Fill(tabla);
        }

        public DataTable getData()
        {
            return tabla;
        }
    }
}
