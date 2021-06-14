using DomainValidations.Entities;
using DomainValidations.Entities.Base;
using DomainValidations.ValueObjects;
using System.Linq;
using Xunit;

namespace DomainValidations.Tests.Entities
{
    public class ConvidadoTests
    {
        [Fact]
        public void Given_Convidado_When_ConvidadoIsInvalid_Then_SetInvalidPropertyOnBaseObjectAndContainsMessages()
        {
            //Arrange
            var convidado = new Convidado("", "Machado", new Celular("21", "972004178"), "");
            //Assert
            Assert.False(convidado.IsValid());
            Assert.True(convidado.Messages.Any());
        }

        [Fact]
        public void Given_Convidado_When_CelularIsInvalid_Then_SetInvalidPropertyOnBaseObjectAndContainsCelularMessages()
        {
            //Arrange
            var convidado = new Convidado("João", "Machado", new Celular("00", "972004178"), "");
            //Assert
            Assert.False(convidado.IsValid());
            Assert.NotNull(convidado.Messages.FirstOrDefault(x => x.Message == "DDD inválido"));
        }

        [Fact]
        public void Given_Convidado_When_ConvidadoIsValid_Then_NotContainsErrorNotification()
        {
            //Arrange
            var convidado = new Convidado("João", "Machado", new Celular("21", "972004178"), "");
            //Assert
            Assert.True(convidado.IsValid());
            Assert.Null(convidado.Messages.FirstOrDefault(x => x.Level == NotificationLevel.DomainError));
        }
    }
}
