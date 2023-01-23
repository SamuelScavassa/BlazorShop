using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorShop.API.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty;
        public string IconCss  { get; set;} = string.Empty;
        public ICollection<Produto> Produtos { get; set; } = new Collection<Produto>(); // Relacionamentos 1 para N
    }
}
