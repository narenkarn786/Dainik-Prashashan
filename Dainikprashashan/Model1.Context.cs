﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dainikprashashan
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Antarik_Basai_Sarai> Antarik_Basai_Sarai { get; set; }
        public virtual DbSet<Asthayi_Basobas> Asthayi_Basobas { get; set; }
        public virtual DbSet<Barsik_Pramanikaran> Barsik_Pramanikaran { get; set; }
        public virtual DbSet<Bato_Kayam> Bato_Kayam { get; set; }
        public virtual DbSet<Charkilla_Sambandhama> Charkilla_Sambandhama { get; set; }
        public virtual DbSet<Ghar_Bato_Pramanit> Ghar_Bato_Pramanit { get; set; }
        public virtual DbSet<Ghar_Jagga_Naamsari> Ghar_Jagga_Naamsari { get; set; }
        public virtual DbSet<Ghar_kayamko_sifaris> Ghar_kayamko_sifaris { get; set; }
        public virtual DbSet<Jagga_Ghar_Kayam> Jagga_Ghar_Kayam { get; set; }
        public virtual DbSet<Jaggadhani_Pratilipi> Jaggadhani_Pratilipi { get; set; }
        public virtual DbSet<Kar_Sambandhi> Kar_Sambandhi { get; set; }
        public virtual DbSet<Kittakat_Sifaris> Kittakat_Sifaris { get; set; }
        public virtual DbSet<Mohi_Lagat_Katta> Mohi_Lagat_Katta { get; set; }
        public virtual DbSet<Sampati_Muluyankan> Sampati_Muluyankan { get; set; }
        public virtual DbSet<Sthayi_Basobas> Sthayi_Basobas { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Nagarikta_Pramanpatra> Nagarikta_Pramanpatra { get; set; }
        public virtual DbSet<Nagarikta_Pramanpatra_Pratilipi> Nagarikta_Pramanpatra_Pratilipi { get; set; }
    }
}
