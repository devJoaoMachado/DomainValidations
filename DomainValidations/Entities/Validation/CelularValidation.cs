using DomainValidations.Entities.Base;
using System.Collections.Generic;
using System.Linq;

namespace DomainValidations.ValueObjects
{
    public partial class Celular : ValidatableEntity
    {
        public override List<DomainNotification> Validate()
        {
            var domainValidation = new FluentDomainValidation<Celular>();

            return domainValidation
                      .AddValidation(!DDDIsValid(), NotificationLevel.DomainError, this, "DDD inválido")
                      .GetMessages();
        }

        public bool DDDIsValid()
        {
            List<int> dddsValidos = new List<int>()
            {
                11,12,13,14,15,16,17,18,19,21,22,24,27,28,31,
                32,33,34,35,37,38,41,42,43,44,45,46,47,48,49,
                51,53,54,55,61,62,63,64,65,66,67,68,69,71,73,
                74,75,77,79,81,82,83,84,85,86,87,88,89,91,92,
                93,94,95,96,97,98,99
            };

            int.TryParse(DDD, out var ddd);

            return dddsValidos.Any(x => x == ddd);
        }
    }
}
