using Dennis.Steven.HelloWorld.Data.Interfaces;
using Dennis.Steven.HelloWorld.Data.Models;
using Dennis.Steven.HelloWorld.Service.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dennis.Steven.HelloWorld.Service.Tests
{
    [TestClass]
    public class MessageServiceTests
    {
        public MessageServiceTests()
        {
            Messages = new List<Message>();
            DataContextMock = new Mock<IDataContext>();
            MessageService = new MessageService(DataContextMock.Object);

            DataContextMock
                .Setup(dc => dc.Messages)
                .Returns(Messages);
        }

        private Mock<IDataContext> DataContextMock { get; }

        private IMessageService MessageService { get; }

        private List<Message> Messages { get; }

        [TestCleanup]
        private void TestCleanup()
        {
            Messages.Clear();
        }

        [TestMethod]
        public void TestMessages_GetMessages()
        {
            Messages.Add(new Message
            {
                MessageDate = DateTime.Now,
                MessageText = "Unit Test 1 - Text"
            });

            Assert.AreEqual(1, MessageService.Messages.Count());
            Assert.IsTrue(MessageService.Messages.Any(m => m.MessageText == "Unit Test 1 - Text"));
        }

        [TestMethod]
        public void TestMessages_AddMessages_String()
        {
            MessageService.AddMessage("Unit Test 2 - Text");

            Assert.AreEqual(1, MessageService.Messages.Count());
            Assert.IsTrue(MessageService.Messages.Any(m => m.MessageText == "Unit Test 2 - Text"));
        }
    }
}
