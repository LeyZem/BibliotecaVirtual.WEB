﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BibliotecaVirtualWeb
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BibliotecaVirtualEntities : DbContext
    {
        public BibliotecaVirtualEntities()
            : base("name=BibliotecaVirtualEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ALUNO> ALUNO { get; set; }
        public virtual DbSet<AUTOR> AUTOR { get; set; }
        public virtual DbSet<EDITORA> EDITORA { get; set; }
        public virtual DbSet<EMPRESTIMO> EMPRESTIMO { get; set; }
        public virtual DbSet<GENERO> GENERO { get; set; }
        public virtual DbSet<LIVRO> LIVRO { get; set; }
        public virtual DbSet<RESERVA> RESERVA { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}