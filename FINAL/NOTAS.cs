//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class NOTAS
    {
        public int ID { get; set; }
        public Nullable<int> NOTA { get; set; }
        public Nullable<int> IDCURSO { get; set; }
        public string ESTADO { get; set; }
    
        public virtual CURSO CURSO { get; set; }
    }
}
