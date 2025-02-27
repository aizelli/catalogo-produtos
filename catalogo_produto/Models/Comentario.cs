namespace catalogo_produto.Models
{
    public class Comentario
    {
        public int Id_comentario {  get; set; }
        public string Texto_comentario { get; set; }
        public DateTime Data_comentario { get; set; }
        public int Id_usuario { get; set; }
        public int Id_produto { get; set; }
    }
}
