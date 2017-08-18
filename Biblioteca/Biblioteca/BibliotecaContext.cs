﻿using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext() : base("Biblioteca") { }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Editora> Editoras { get; set; }

        
    }
}
