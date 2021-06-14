using System.Collections.Generic;
using System.Linq;

namespace DomainValidations.Entities.Base
{
    public abstract class ValidatableEntity
    {
        private bool hasValidated = false;
        private bool isValid = false;

        public bool IsValid()
        {
            var resultValidation = hasValidated ? isValid : (isValid = !(Messages = Validate()).Any(x => x.Level == NotificationLevel.DomainError));

            hasValidated = true;

            return resultValidation;
        }

        public List<DomainNotification> Messages { get; protected set; }

        public abstract List<DomainNotification> Validate();
    }
}
