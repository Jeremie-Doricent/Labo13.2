using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Tests
{
    [TestClass()]
    public class ChatTests
    {
        [TestMethod()]
        public void ChatTestMatriculeage()
        {


            Assert.ThrowsException<ArgumentException>(() =>
            {
                Chat chat = new Chat("A123", "miokm", -23);


            }

            );
        }
        [TestMethod()]
        public void ChatTest()
        {
            Chat chat = new Chat("A123", "minou" ,23);
            Assert.AreEqual("A123", chat.Matricule);
            Assert.AreEqual("minou", chat.Nom);
            Assert.AreEqual(23, chat.Age);






        }
        [TestMethod()]
        public void ChatTestMatricule()
        {
           

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                Chat chat = new Chat(null, "minou", 23);
                Chat chats = new Chat("", "minou", 23);
            }
            
            );
        }
        [TestMethod()]
        public void ChatTestMatriculeNB()
        {


            Assert.ThrowsException<ArgumentException>(() =>
            {
                Chat chat = new Chat("A12332", "minou", 23);
                Chat chats = new Chat("A12", "minou", 23);

            }

            );
        }
        [TestMethod()]
        public void ChatTestMatriculeNom()
        {


            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                Chat chats = new Chat("A121", null, 23);
                Chat chat = new Chat("A121", "", 23);
                
            }

            );
        }
        [TestMethod()]
        public void ChatTestMatriculeNom1()
        {


            Assert.ThrowsException<ArgumentException>(() =>
            {
                Chat chat = new Chat("A123", "mi", 23);
           

            }

            );
        }
       
    }
}