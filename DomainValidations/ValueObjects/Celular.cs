using DomainValidations.Entities.Base;

namespace DomainValidations.ValueObjects
{
    public partial class Celular : ValidatableEntity
    {
        public Celular(string ddd, string numero)
        {
            DDD = ddd;
            Numero = numero;
        }

        public string DDD { get; private set; }

        public string Numero { get; private set; }

        public string NumeroCompleto => IsValid() ? $"{DDD}{Numero}" : string.Empty;
    }
}
