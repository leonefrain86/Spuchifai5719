using System;
using System.Collections.Generic;
using System.Text;

namespace Spuchifai5719.ADO
{
    public interface IADO
    {
        void altaBanda(Banda banda);

        void altaAlbum(Album album);   

        void altaCancion(Cancion cancion);

        void altaCliente(Cliente cliente);

        Cliente clientePorUserYPass(string mailUser, string pass);
    }
}
