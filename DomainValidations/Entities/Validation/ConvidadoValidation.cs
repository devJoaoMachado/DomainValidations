using DomainValidations.Entities.Base;
using System.Collections.Generic;
using System.Linq;

namespace DomainValidations.Entities
{
    public partial class Convidado : ValidatableEntity
    {
        public override List<DomainNotification> Validate()
        {
            var domainValidation = new FluentDomainValidation<Convidado>();

            return domainValidation
                    .AddValidation(string.IsNullOrWhiteSpace(Nome), NotificationLevel.DomainError, this, "Nome inválido")
                    .AddValidation(string.IsNullOrWhiteSpace(Sobrenome), NotificationLevel.DomainError, this, "Sobrenome inválido")
                    .AddValidation(Celular == null || !Celular.IsValid(), NotificationLevel.DomainError, this, Celular?.Messages.FirstOrDefault()?.Message)
                    .GetMessages();
        }
    }
}
