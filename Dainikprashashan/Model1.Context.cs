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
        public virtual DbSet<Arthik_Barsa> Arthik_Barsa { get; set; }
        public virtual DbSet<Asthayi_Basobas> Asthayi_Basobas { get; set; }
        public virtual DbSet<Barsik_Pramanikaran> Barsik_Pramanikaran { get; set; }
        public virtual DbSet<Bato_Kayam> Bato_Kayam { get; set; }
        public virtual DbSet<Byawasaya_Banda_Barey> Byawasaya_Banda_Barey { get; set; }
        public virtual DbSet<Byawasaya_Darta> Byawasaya_Darta { get; set; }
        public virtual DbSet<Charkilla_Sambandhama> Charkilla_Sambandhama { get; set; }
        public virtual DbSet<Faat> Faats { get; set; }
        public virtual DbSet<Faat_Karmachari> Faat_Karmachari { get; set; }
        public virtual DbSet<Gabisa> Gabisas { get; set; }
        public virtual DbSet<Ghar_Bato_Pramanit> Ghar_Bato_Pramanit { get; set; }
        public virtual DbSet<Ghar_Jagga_Naamsari> Ghar_Jagga_Naamsari { get; set; }
        public virtual DbSet<Ghar_kayamko_sifaris> Ghar_kayamko_sifaris { get; set; }
        public virtual DbSet<Jagga_Ghar_Kayam> Jagga_Ghar_Kayam { get; set; }
        public virtual DbSet<Jaggadhani_Pratilipi> Jaggadhani_Pratilipi { get; set; }
        public virtual DbSet<Jilla> Jillas { get; set; }
        public virtual DbSet<Kaam> Kaams { get; set; }
        public virtual DbSet<Kagajaat> Kagajaats { get; set; }
        public virtual DbSet<Kar_Sambandhi> Kar_Sambandhi { get; set; }
        public virtual DbSet<Karyalaya> Karyalayas { get; set; }
        public virtual DbSet<Kittakat_Sifaris> Kittakat_Sifaris { get; set; }
        public virtual DbSet<Mohi_Lagat_Katta> Mohi_Lagat_Katta { get; set; }
        public virtual DbSet<Padd> Padds { get; set; }
        public virtual DbSet<Pradesh> Pradeshes { get; set; }
        public virtual DbSet<Sabik_Thegana> Sabik_Thegana { get; set; }
        public virtual DbSet<Sampati_Muluyankan> Sampati_Muluyankan { get; set; }
        public virtual DbSet<Sanstha_Darta_Pramanpatra> Sanstha_Darta_Pramanpatra { get; set; }
        public virtual DbSet<Sanstha_Darta_Sifaris> Sanstha_Darta_Sifaris { get; set; }
        public virtual DbSet<Sanstha_Nawikaran> Sanstha_Nawikaran { get; set; }
        public virtual DbSet<Sewa> Sewas { get; set; }
        public virtual DbSet<Sthayi_Basobas> Sthayi_Basobas { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
        public virtual DbSet<Anya_Sifaris> Anya_Sifaris { get; set; }
        public virtual DbSet<Apangako_Kisim> Apangako_Kisim { get; set; }
        public virtual DbSet<Batoko_Prakaar> Batoko_Prakaar { get; set; }
        public virtual DbSet<Biwahko_Prakaar> Biwahko_Prakaar { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Nagarikta_Pramanpatra> Nagarikta_Pramanpatra { get; set; }
        public virtual DbSet<Nagarikta_Pramanpatra_Pratilipi> Nagarikta_Pramanpatra_Pratilipi { get; set; }
        public virtual DbSet<Nata> Natas { get; set; }
    }
}
