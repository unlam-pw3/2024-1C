﻿using CRUD.Equipos.Entidades;
using System.Collections.Generic;

namespace CRUD.Equipos.Services
{
    public interface IEquipoServicio
    {
        void Agregar(Equipo equipo);
        void Eliminar(Equipo equipo);
        List<Equipo> ObtenerTodos();
    }

    public class EquipoServicio : IEquipoServicio
    {
        private static List<Equipo> Items { get; set; } = new List<Equipo>();

        public void Agregar(Equipo equipo)
        {
            Items.Add(equipo);
        }

        public List<Equipo> ObtenerTodos()
        {
            return Items;
        }

        public void Eliminar(Equipo equipo)
        {
            Items.Remove(equipo);
        }
    }
}
