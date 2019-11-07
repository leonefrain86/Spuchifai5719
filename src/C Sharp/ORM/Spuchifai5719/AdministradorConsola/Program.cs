﻿using System;
using AdministradorConsola.Menu;
using MenuesConsola;

namespace AdministradorConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuAltaCategoria = new MenuAltaCategoria() { Nombre = "Alta Categoria" };
            var menuListaCategoria = new MenuListaCategorias() { Nombre = "Listado Categorias" };

            var menuCategoria = new MenuCompuesto() { Nombre = "Categorias" };
            menuCategoria.agregarMenu(menuAltaCategoria);
            menuCategoria.agregarMenu(menuListaCategoria);

            var menuPrincipal = new MenuCompuesto() { Nombre = "Menu Gerente" };
            menuPrincipal.agregarMenu(menuCategoria);

            menuPrincipal.mostrar();

        }
    }
}
