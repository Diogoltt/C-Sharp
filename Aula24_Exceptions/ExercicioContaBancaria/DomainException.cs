namespace Aula24_Exceptions.ExercicioContaBancaria
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
            
        }
    }
}