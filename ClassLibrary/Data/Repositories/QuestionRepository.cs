using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private Context _context = null;
        public QuestionRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Question> GetQuestions(int id)
        {
            return _context.Questions
                .Where(question => question.Creator.Id == id)
                .Include(question => question.Surveys)
                .Include(question => question.Creator)
                .ToList();
        }

        public Question GetQuestionById(int id)
        {
            var query = from c in _context.Questions where c.Id == id select c;
            return query.Single();
        }

        public void InsertQuestion(Question question, int UserId)
        {
            _context.Users.Find(UserId).Questions.Add(question);
        }

        public void UpdateQuestion(Question question) { }

        public void DeleteQuestion(int QuestionId)
        {
            Question question = _context.Questions.Where(c => c.Id == QuestionId).SingleOrDefault();
            _context.Questions.Remove(question);

        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
