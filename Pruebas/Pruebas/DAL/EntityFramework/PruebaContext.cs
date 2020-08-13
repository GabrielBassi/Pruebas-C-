﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Pruebas.Modelo;

namespace Pruebas.DAL.EntityFramework
{
    public class PruebaContext : DbContext
    {
        public PruebaContext() : base("Prueba")
        { 
        
        }
        public DbSet<Campaña> Campañas { get; set; }
        public DbSet<Imagen> Imagenes { get; set; }
    }
}