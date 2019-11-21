using System.Collections.Generic;

namespace Spuchifai5719.ADO
{
    public interface IADO
    {
        void altaBanda(Banda banda);

        void altaAlbum(Album album);   

        void altaCancion(Cancion cancion);

        void altaCliente(Cliente cliente);

        void altaReproduccion(Reproduccion reproduccion);

        Cliente clientePorUserYPass(string mailUser, string pass);

        List<Cancion> traerCanciones();

        void actualizarCliente(Cliente cliente);
        List<Cancion> obtenerCanciones();
        List<Reproduccion> obtenerReproducciones();
        List<Cliente> obtenerClientes();
        List<Album> obtenerAlbumes();
        List<Banda> obtenerBandas();
    }
}
