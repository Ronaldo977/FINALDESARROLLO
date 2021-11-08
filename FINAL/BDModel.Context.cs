﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FINAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EFEntities : DbContext
    {
        public EFEntities()
            : base("name=EFEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ALUMNOS> ALUMNOS { get; set; }
        public virtual DbSet<CURSO> CURSO { get; set; }
        public virtual DbSet<NOTAS> NOTAS { get; set; }
    
        public virtual ObjectResult<SP_ALUMNOS_Result> SP_ALUMNOS(Nullable<int> iD, string nOMBRE, string cARNET, Nullable<int> iDCURSO, string eSTADO, string oPTIONS)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var cARNETParameter = cARNET != null ?
                new ObjectParameter("CARNET", cARNET) :
                new ObjectParameter("CARNET", typeof(string));
    
            var iDCURSOParameter = iDCURSO.HasValue ?
                new ObjectParameter("IDCURSO", iDCURSO) :
                new ObjectParameter("IDCURSO", typeof(int));
    
            var eSTADOParameter = eSTADO != null ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(string));
    
            var oPTIONSParameter = oPTIONS != null ?
                new ObjectParameter("OPTIONS", oPTIONS) :
                new ObjectParameter("OPTIONS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ALUMNOS_Result>("SP_ALUMNOS", iDParameter, nOMBREParameter, cARNETParameter, iDCURSOParameter, eSTADOParameter, oPTIONSParameter);
        }
    
        public virtual ObjectResult<SP_CURSOS_Result> SP_CURSOS(Nullable<int> iD, string nOMBRE, string oPTIONS)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var oPTIONSParameter = oPTIONS != null ?
                new ObjectParameter("OPTIONS", oPTIONS) :
                new ObjectParameter("OPTIONS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CURSOS_Result>("SP_CURSOS", iDParameter, nOMBREParameter, oPTIONSParameter);
        }
    
        public virtual ObjectResult<SP_NOTA_Result> SP_NOTA(Nullable<int> iD, Nullable<int> nOTA, Nullable<int> iDCURSO, string oPTIONS)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nOTAParameter = nOTA.HasValue ?
                new ObjectParameter("NOTA", nOTA) :
                new ObjectParameter("NOTA", typeof(int));
    
            var iDCURSOParameter = iDCURSO.HasValue ?
                new ObjectParameter("IDCURSO", iDCURSO) :
                new ObjectParameter("IDCURSO", typeof(int));
    
            var oPTIONSParameter = oPTIONS != null ?
                new ObjectParameter("OPTIONS", oPTIONS) :
                new ObjectParameter("OPTIONS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_NOTA_Result>("SP_NOTA", iDParameter, nOTAParameter, iDCURSOParameter, oPTIONSParameter);
        }
    
        public virtual ObjectResult<SP_AL_ACTIVO_Result> SP_AL_ACTIVO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_AL_ACTIVO_Result>("SP_AL_ACTIVO");
        }
    }
}