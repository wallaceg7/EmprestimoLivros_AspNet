namespace EmprestimoLivros.Services.SenhaService
{
    public interface ISenhaInterface
    {
        // parametro vai vazio e o parametro out retorna o proprio parametro preenchido
        void CriarSenhaHash(string senha, out byte[] senhaHash, out byte[] senhaSalt);
    }
}
