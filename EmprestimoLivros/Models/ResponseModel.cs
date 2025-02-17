namespace EmprestimoLivros.Models
{
    public class ResponseModel<T>
    {
        // Modelo responsável por retornar os dados
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Status { get; set; } = true;
    }
}
