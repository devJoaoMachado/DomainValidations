using System;

namespace DomainValidations.Entities.Base
{
    public class DomainNotification
    {
        private DomainNotification()
        {

        }

        public NotificationLevel Level { get; set; }
        public string EntityName { get; set; }
        public string Message { get; set; }


        public static DomainNotification Create(NotificationLevel level, string entityName, string message)
        {
            if (string.IsNullOrWhiteSpace(entityName) || string.IsNullOrWhiteSpace(message))
                throw new ArgumentException();

            return new DomainNotification { Level = level, EntityName = entityName, Message = message };
        }
    }
}
