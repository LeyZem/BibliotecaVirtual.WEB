//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class GENERO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GENERO()
        {
            this.LIVRO = new HashSet<LIVRO>();
        }
    
        public int ID_GENERO { get; set; }
        public string DESCRICAO { get; set; }
        public string ANDAR { get; set; }
        public string CORREDOR { get; set; }
        public string PRETELEIRA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIVRO> LIVRO { get; set; }
    }
}
