//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FerrazIrrigacoes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItensVenda
    {
        public int Id { get; set; }
        public Nullable<decimal> ValorProduto { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<int> Produto { get; set; }
        public Nullable<int> Venda { get; set; }
        public Nullable<decimal> ValorTotalProdutos { get; set; }
    
        public virtual Produto Produto1 { get; set; }
        public virtual Venda Venda1 { get; set; }
    }
}