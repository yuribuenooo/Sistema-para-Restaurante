//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjRestaurante.modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class mesa
    {
        public mesa()
        {
            this.consumo_comanda = new HashSet<consumo_comanda>();
        }
    
        public int idmesa { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<int> vagas { get; set; }
    
        public virtual ICollection<consumo_comanda> consumo_comanda { get; set; }
    }
}
