//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcStokProjem.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TBL_MUSTERI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_MUSTERI()
        {
            this.TBL_SATISLAR = new HashSet<TBL_SATISLAR>();
        }
    
        public int MUSTERIID { get; set; }

        [Required(ErrorMessage ="Bu alan� bo� b�rakamazs�n�z.")]
        [StringLength(50,ErrorMessage ="En fazla 50 karakter")]
        public string MUSTERIAD { get; set; }

        [Required(ErrorMessage = "Bu alan� bo� b�rakamazs�n�z.")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter")]
        public string MUSTERISOYAD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SATISLAR> TBL_SATISLAR { get; set; }
    }
}
