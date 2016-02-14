using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;
using Core.Interfaces;
using Core.Model;
using Core.Services;

namespace Core.Tests
{
    /// <summary>
    /// Summary description for NotificationService_sendNotificationForUser
    /// </summary>
    [TestClass]
    public class NotificationService_sendNotificationForUser
    {
        public NotificationService_sendNotificationForUser() {  }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void isNonPremiumUserMailSentAndValid()
        {
            var user            = new User("A", "A@B.com", false);
            var expectedSubject = "Notification";
            var expectedMessage = "Dear A this is a Notification!";

            var sendMail = Mock.Create<SendMail>();

            new NotificationService(sendMail).sendNotificationForUser(user);

            Mock.Assert(
                    () => sendMail.sendMail(user.EMailAddress, expectedSubject, expectedMessage),
                    Occurs.Once(),
                    "sendMail() wasn't called as expected!"
                );
        }

        [TestMethod]
        public void isPremiumUserMailSendAndValid()
        {
            var user = new User("Premium", "Premium@User.com", true);
            var expectedSubject = "Notification";
            var expectedMessage = "Dear Premium this is a Notification! -> Additional Information for Premium Users!";

            var sendMail = Mock.Create<SendMail>();

            new NotificationService(sendMail).sendNotificationForUser(user);

            Mock.Assert(
                    () => sendMail.sendMail(user.EMailAddress, expectedSubject, expectedMessage),
                    Occurs.Once(),
                    "sendMail() wasn't called as expected!"
                );
        }
    }
}
