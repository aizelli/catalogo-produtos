namespace catalogo_produto.Models
{
    public class Produto
    {
        public int Id_produto { get; set; }
        public string Nome_produto { get; set; }
        public string Descricao_produto { get; set; }
        public DateTime Data_registro_produto { get; set; }
        public int Id_usuario { get; set; }
        public int Id_categoria { get; set; }
    }
}
