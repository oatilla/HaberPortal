﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaberPortal.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB090928093827Entities : DbContext
    {
        public DB090928093827Entities()
            : base("name=DB090928093827Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_PortalHaber_Banner> tbl_PortalHaber_Banner { get; set; }
        public virtual DbSet<tbl_PortalHaber_Banner_Site_Relation> tbl_PortalHaber_Banner_Site_Relation { get; set; }
        public virtual DbSet<tbl_PortalHaber_Banner_VeriGelmeTipi> tbl_PortalHaber_Banner_VeriGelmeTipi { get; set; }
        public virtual DbSet<tbl_PortalHaber_Icerik> tbl_PortalHaber_Icerik { get; set; }
        public virtual DbSet<tbl_PortalHaber_Icerik2> tbl_PortalHaber_Icerik2 { get; set; }
        public virtual DbSet<tbl_PortalHaber_IP> tbl_PortalHaber_IP { get; set; }
        public virtual DbSet<tbl_PortalHaber_kategori> tbl_PortalHaber_kategori { get; set; }
        public virtual DbSet<tbl_PortalHaber_Kaynak> tbl_PortalHaber_Kaynak { get; set; }
        public virtual DbSet<tbl_PortalHaber_Menu> tbl_PortalHaber_Menu { get; set; }
        public virtual DbSet<tbl_PortalHaber_Menu_Tip_Relation> tbl_PortalHaber_Menu_Tip_Relation { get; set; }
        public virtual DbSet<tbl_PortalHaber_OkunmaSayisi> tbl_PortalHaber_OkunmaSayisi { get; set; }
        public virtual DbSet<tbl_PortalHaber_PopulerHaberler_Zaman> tbl_PortalHaber_PopulerHaberler_Zaman { get; set; }
        public virtual DbSet<tbl_PortalHaber_Site> tbl_PortalHaber_Site { get; set; }
        public virtual DbSet<tbl_PortalHaber_SiteGrubu> tbl_PortalHaber_SiteGrubu { get; set; }
        public virtual DbSet<tbl_PortalHaber_Tip> tbl_PortalHaber_Tip { get; set; }
        public virtual DbSet<tbl_PortalHaber_Yazar> tbl_PortalHaber_Yazar { get; set; }
        public virtual DbSet<tbl_PortalHaber_YazarParaAyar> tbl_PortalHaber_YazarParaAyar { get; set; }
        public virtual DbSet<tbl_PortalHaber_YazarParaTalep> tbl_PortalHaber_YazarParaTalep { get; set; }
        public virtual DbSet<tbl_PortalHaber_YazarSiteRelation> tbl_PortalHaber_YazarSiteRelation { get; set; }
        public virtual DbSet<VWBANNER> VWBANNERs { get; set; }
        public virtual DbSet<VWYHABERLIST> VWYHABERLISTs { get; set; }
    }
}
