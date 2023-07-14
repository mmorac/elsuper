using elsuper.DAI;
using elsuper.Modelos;

namespace elsuper.DAL
{
    public class SupermercadoDAL : ISupermercado
    {
        public static Supermercado getSupermercado(string nombre)
        {
            ElsuperContext contexto = new ElsuperContext();
            Supermercado supermercado = contexto.Supermercados.FirstOrDefault(s => s.Nombre.Equals(nombre));
            return supermercado;
        }

        public static List<Supermercado> getSupermercados()
        {
            ElsuperContext contexto = new ElsuperContext();
            return contexto.Supermercados.ToList();
        }

        public static void agregarSupermercado()
        {

        }

        public static void actualizarSupermercado()
        {

        }

        public static void eliminarSupermercado()
        {

        }
    }
}
