using System.Collections.Generic;

namespace DomainValidations.Entities.Base
{
    public class FluentDomainValidation<T> where T : ValidatableEntity
    {
        public FluentDomainValidation()
        {
            Messages = new List<DomainNotification>();
        }

        private List<DomainNotification> Messages { get; set; }

        public FluentDomainValidation<T> AddValidation(bool assert, NotificationLevel level, T entity, string message)
        {
            if (assert)
                Messages.Add(DomainNotification.Create(level, entity.GetType().Name, message));

            return this;
        }

        public List<DomainNotification> GetMessages()
        {
            return Messages;
        }
    }
}
