using elsuper.Modelos;

namespace elsuper.DAI
{
    public interface ISupermercado
    {
        static abstract Supermercado getSupermercado(string nombre);
        static abstract List<Supermercado> getSupermercados();
        static abstract void agregarSupermercado();
        static abstract void actualizarSupermercado();
        static abstract void eliminarSupermercado();
    }
}
