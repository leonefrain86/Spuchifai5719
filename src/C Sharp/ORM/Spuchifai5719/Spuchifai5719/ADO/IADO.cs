using System.Collections.Generic;

namespace Spuchifai5719.ADO
{
    public interface IADO
    {
        void altaBanda(Banda banda);
        Banda bandaPorNameYPass(string nameBanda, string pass);
        List<Banda> obtenerBandas();
        void actualizarBanda(Banda banda);


        void altaAlbum(Album album);
        List<Album> obtenerAlbumes();
        List<Album> obtenerAlbumesParaBanda(Banda banda);
        void actualizarAlbum(Album album);


        void altaCancion(Cancion cancion);
        void actualizarCancion(Cancion cancion);
        List<Cancion> obtenerCanciones();
        List<Cancion> traerCanciones();
        List<Cancion> obtenerCancionesParaBanda(Banda banda);


        void altaCliente(Cliente cliente);
        void altaReproduccion(Reproduccion reproduccion);
        Cliente clientePorUserYPass(string mailUser, string pass);

        

        void actualizarCliente(Cliente cliente);
        List<Cliente> obtenerClientes();


        List<Reproduccion> obtenerReproducciones();
        List<Reproduccion> obtenerReproduccionesParaCliente(Cliente cliente);






    }
}
