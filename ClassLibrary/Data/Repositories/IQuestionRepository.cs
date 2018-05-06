using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data.Repositories
{
    interface IQuestionRepository
    {
        IEnumerable<Question> GetQuestions(int UserId);
        Question GetQuestionById(int QuestionId);
        void InsertQuestion(Question Question, int UserId);
        void UpdateQuestion(Question Question);
        void DeleteQuestion(int QuestionId);
        void Save();
    }
}
