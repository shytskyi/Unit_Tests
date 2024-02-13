using BL.MOQ;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
namespace UnitTestProject
{
    public class MOQContactServiceTest
    {
        [Fact]
        public void GetContact_ById_ReturnContect()
        {
            //Arrange
            var contactRepositoryMock = new Mock<IContactRepository>();
            contactRepositoryMock.Setup(x => x.GetContact(It.IsAny<int>()))
                                              .Returns(new Contact(1, "TestName"));

            //Act
            var contatService = new ContactService(contactRepositoryMock.Object);
            var actual = contatService.GetContact(1);

            //Assert
            contactRepositoryMock.Verify(x => x.GetContact(It.IsAny<int>()), Times.Once);
            Assert.Equal(1, actual.Id);
            
        }
        [Fact]
        public async Task GetContactAsync_ById_ReturnContect()
        {
            //Arrange
            var contact = new Contact(2, "Name");
            var contactRepositoryMock = new Mock<IContactRepository>();
            contactRepositoryMock.Setup(x => x.GetContactAsync(It.IsAny<int>()))
                                              .ReturnsAsync(contact);

            //Act
            var contatService = new ContactService(contactRepositoryMock.Object);
            var actual = contatService.GetContactAsync(2);

            //Assert
            contactRepositoryMock.Verify(x => x.GetContactAsync(It.IsAny<int>()), Times.Once);
            Assert.Equal(2, actual.Result.Id);
        }

        [Fact]
        public void GetContact_ByName_ReturnContect()
        {
            //Arrange
            var contactRepositoryMock = new Mock<IContactRepository>();
            contactRepositoryMock.Setup(x => x.GetContact(It.IsAny<string>()))
                                              .Returns(new Contact(1, "TestName"));

            //Act
            var contatService = new ContactService(contactRepositoryMock.Object);
            var actual = contatService.GetContact("TestName");

            //Assert
            contactRepositoryMock.Verify(x => x.GetContact(It.IsAny<string>()), Times.Once);
            Assert.Equal("TestName", actual.Name);

        }

        [Fact]
        public void GetContacts_ReturnContects()
        {
            //Arrange
            var list = new List<Contact>
            {
                new Contact (1,"Yuliia"),
                new Contact (2, "Ira" )
            };
            var contactRepositoryMock = new Mock<IContactRepository>();
            contactRepositoryMock.Setup(x => x.GetContacts()).Returns(list);

            //Act
            var contatService = new ContactService(contactRepositoryMock.Object);
            var actual = contatService.GetContacts();

            //Assert
            contactRepositoryMock.Verify(x => x.GetContacts(), Times.Once);
            Assert.Equal(list, actual);
        }

        [Fact]
        public void DeleteContact_ReturnContects()
        {
            //Arrange
            Contact contact = new Contact(3, "Ivan");
            var contactRepositoryMock = new Mock<IContactRepository>();
            contactRepositoryMock.SetupSequence(x => x.DeleteContact(contact))
                                                                .Returns(true)
                                                                .Returns(false);

            //Act
            var contatService = new ContactService(contactRepositoryMock.Object);
            var actual1 = contatService.DeleteContact(contact);
            var actual2 = contatService.DeleteContact(contact);

            //Assert
            Assert.True(actual1);
            Assert.False(actual2);
        }
    }
}
