using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Models;
namespace ClassLibrary.Data
{
    class SeedData
    {
        public static void Seed1(Context _context)
        {
            User TestUser1 = new User()
            {
                Username = "testuser1",
                Email = "test@test.com",
                CreationDate = DateTime.Today
            };

            User TestUser2 = new User()
            {
                Username = "testuser2",
                Email = "test2@test.com",
                CreationDate = DateTime.Today
            };

            Question Q1 = new Question()
            {
                Creator = TestUser1,
                CreationDate = DateTime.Today,
                QuestionText = "How are you feeling today?"
            };
            Question Q2 = new Question()
            {
                Creator = TestUser1,
                CreationDate = DateTime.Today,
                QuestionText = "How would you rate our product?"
            };

            Question Q3 = new Question()
            {
                Creator = TestUser2,
                CreationDate = DateTime.Today,
                QuestionText = "How did you hear about us?"
            };
            Question Q4 = new Question()
            {
                Creator = TestUser2,
                CreationDate = DateTime.Today,
                QuestionText = "How would you rate your customer service experience?"
            };
            Question Q5 = new Question()
            {
                Creator = TestUser2,
                CreationDate = DateTime.Today,
                QuestionText = "Would you recommend our product to friend?"
            };
            Question Q6 = new Question()
            {
                Creator = TestUser2,
                CreationDate = DateTime.Today,
                QuestionText = "How likely are you to use our product again?"
            };

            Survey Survey1 = new Survey()
            {
                Creator = TestUser1,
                CreationDate = DateTime.Today,
                Questions = new List<Question>() { Q1, Q2}
            };
            Survey Survey2 = new Survey()
            {
                Creator = TestUser2,
                CreationDate = DateTime.Today,
                Questions = new List<Question>() { Q3, Q4, Q5, Q6 }
            };
            Survey Survey3 = new Survey()
            {
                Creator = TestUser2,
                CreationDate = DateTime.Today,
                Questions = new List<Question>() { Q3, Q6 }
            };

            Client Client1 = new Client()
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "client1@test.com",
                ZipCode = "84101",
                Surveys = new List<Survey>() {},
                Owner = TestUser2
            };
            Client Client2 = new Client()
            {
                FirstName = "Jane",
                LastName = "Smith",
                Email = "client2@test.com",
                ZipCode = "84101",
                Surveys = new List<Survey>() { },
                Owner = TestUser2
            };
            Client Client3 = new Client()
            {
                FirstName = "Adam",
                LastName = "Smith",
                Email = "client3@test.com",
                ZipCode = "84101",
                Surveys = new List<Survey>() { },
                Owner = TestUser2
            };
            Client Client4 = new Client()
            {
                FirstName = "John",
                LastName = "Keynes",
                Email = "client4@test.com",
                ZipCode = "84101",
                Surveys = new List<Survey>() { },
                Owner = TestUser1
            };
            Survey1.Clients = new List<Client>() { Client4 };
            Survey2.Clients = new List<Client>() { Client1, Client2, Client3 };
            Survey3.Clients = new List<Client>() { Client2, Client1 };

            _context.Users.Add(TestUser1);
            _context.Users.Add(TestUser2);
            _context.Questions.AddRange(new List<Question>() { Q1, Q2, Q3, Q4, Q5, Q6 });
            _context.Surveys.AddRange(new List<Survey>() { Survey1, Survey2, Survey3 });
            _context.Clients.AddRange(new List<Client>() { Client1, Client2, Client3, Client4 });

            _context.SaveChanges();
        }

        
    }
}
