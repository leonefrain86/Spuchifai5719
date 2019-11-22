using System.Collections.Generic;

namespace Spuchifai5719.ADO
{
    public interface IADO
    {
        void altaBanda(Banda banda);
        Banda bandaPorNameYPass(string nameBanda, string pass);

        void altaAlbum(Album album);   

        void altaCancion(Cancion cancion);

        void altaCliente(Cliente cliente);

        void altaReproduccion(Reproduccion reproduccion);

        Cliente clientePorUserYPass(string mailUser, string pass);

        List<Cancion> traerCanciones();

        void actualizarCliente(Cliente cliente);
        List<Cancion> obtenerCanciones();
        List<Cancion> obtenerCancionesParaBanda(Banda banda);
        List<Reproduccion> obtenerReproducciones();
        List<Cliente> obtenerClientes();
        List<Album> obtenerAlbumes();
        List<Album> obtenerAlbumesParaBanda(Banda banda);
        List<Banda> obtenerBandas();
        void actualizarAlbum(Album album);
        void actualizarBanda(Banda banda);
        void actualizarCancion(Cancion cancion);
    }
}
