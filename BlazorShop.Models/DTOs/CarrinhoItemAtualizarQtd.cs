using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.Models.DTOs
{
    public class CarrinhoItemAtualizarQtd
    {
        public int CarrinhoItemId { get; set; }
        public int Qtd { get; set; }
    }
}
