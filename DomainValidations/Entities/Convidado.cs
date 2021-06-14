using DomainValidations.Entities.Base;
using DomainValidations.ValueObjects;

namespace DomainValidations.Entities
{
    public partial class Convidado : ValidatableEntity
    {
        public Convidado(string nome, string sobrenome, Celular celular, string tag)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Celular = celular;
            Tag = tag;
        }

        public long Id { get; }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Celular Celular { get; private set; }
        public string Tag { get; private set; }

    }
}
