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
    
    public partial class vwcp_conciliacion_Caja_det_x_ValeCaja
    {
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public int Secuencia { get; set; }
        public int IdEmpresa_movcaja { get; set; }
        public decimal IdCbteCble_movcaja { get; set; }
        public int IdTipocbte_movcaja { get; set; }
        public string IdCtaCble { get; set; }
        public double cm_valor { get; set; }
        public int IdTipoMovi { get; set; }
        public decimal IdPersona { get; set; }
        public string pe_nombreCompleto { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string cm_observacion { get; set; }
    }
}