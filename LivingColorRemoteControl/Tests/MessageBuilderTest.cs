using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LivingColorRemoteControl;

namespace Tests
{
    /// <summary>
    /// Just some (too big) testcases 
    /// </summary>

    [TestClass]
    public class MessageBuilderTest
    {
        [TestMethod]
        public void testCreation()
        {
            MessageBuilder builder = new MessageBuilder('#', '%');
            Assert.AreEqual('#', builder.MessageBeginMarker);
            Assert.AreEqual('%', builder.MessageEndMarker);
            Assert.AreEqual(0, builder.MessageCount);
        }

        [TestMethod]
        public void testAddingAndGettingACompleteMessageThatHasNoPayload()
        {
            MessageBuilder builder = new MessageBuilder('#', '%');
            builder.Add("#%");

            Assert.AreEqual(1, builder.MessageCount);
            Assert.AreEqual("", builder.GetNextMessage());

            Assert.AreEqual(0, builder.MessageCount);
            Assert.AreEqual(null, builder.GetNextMessage());
        }

        [TestMethod]
        public void testAddingAndGettingACompleteMessage()
        {
            MessageBuilder builder = new MessageBuilder('#', '%');
            builder.Add("#Hello%");

            Assert.AreEqual(1, builder.MessageCount);
            Assert.AreEqual("Hello", builder.GetNextMessage());

            Assert.AreEqual(0, builder.MessageCount);
            Assert.AreEqual(null, builder.GetNextMessage());
        }

        [TestMethod]
        public void testAddingAndGettingTwoCompleteMessages()
        {
            MessageBuilder builder = new MessageBuilder('#', '%');
            builder.Add("#Hello%#GoodBye%");
            Assert.AreEqual(2, builder.MessageCount);

            Assert.AreEqual("Hello", builder.GetNextMessage());
            Assert.AreEqual(1, builder.MessageCount);

            Assert.AreEqual("GoodBye", builder.GetNextMessage());
            Assert.AreEqual(0, builder.MessageCount);

            Assert.AreEqual(null, builder.GetNextMessage());
        }

        [TestMethod]
        public void testAddingAndGettingTwoCompleteMessagesWithGarbage()
        {
            MessageBuilder builder = new MessageBuilder('#', '%');
            builder.Add("g#Hello%g#GoodBye%g");
            Assert.AreEqual(2, builder.MessageCount);

            Assert.AreEqual("Hello", builder.GetNextMessage());
            Assert.AreEqual(1, builder.MessageCount);

            Assert.AreEqual("GoodBye", builder.GetNextMessage());
            Assert.AreEqual(0, builder.MessageCount);

            Assert.AreEqual(null, builder.GetNextMessage());
        }

        [TestMethod]
        public void testAddingAndGettingAnIncompleteMessage()
        {
            MessageBuilder builder = new MessageBuilder('#', '%');
            builder.Add("#");
            Assert.AreEqual(0, builder.MessageCount);
            Assert.AreEqual(null, builder.GetNextMessage());

            builder.Add("He");
            Assert.AreEqual(0, builder.MessageCount);
            Assert.AreEqual(null, builder.GetNextMessage());

            builder.Add("llo%");
            Assert.AreEqual(1, builder.MessageCount);
            Assert.AreEqual("Hello", builder.GetNextMessage());
            Assert.AreEqual(null, builder.GetNextMessage());
        }
    }
}
