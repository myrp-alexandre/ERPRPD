//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class in_categorias
    {
        public in_categorias()
        {
            this.in_linea = new HashSet<in_linea>();
            this.in_Producto = new HashSet<in_Producto>();
        }
    
        public int IdEmpresa { get; set; }
        public string IdCategoria { get; set; }
        public string ca_Categoria { get; set; }
        public string Estado { get; set; }
        public string IdCtaCtble_Inve { get; set; }
        public string IdCtaCtble_Costo { get; set; }
        public string IdCtaCble_venta { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string cod_categoria { get; set; }
    
        public virtual ICollection<in_linea> in_linea { get; set; }
        public virtual ICollection<in_Producto> in_Producto { get; set; }
    }
}