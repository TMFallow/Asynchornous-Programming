using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Web_Reporsitory.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDBContext _dbContext;
        public StudentRepository()
        {
            _dbContext = new StudentDBContext();
        }

        public StudentRepository(StudentDBContext studentDBContext)
        {
            _dbContext = studentDBContext;
        }

        public IEnumerable<STUDENT> GetAll()
        {
            return _dbContext.STUDENTs.ToList();
        }

        public STUDENT GetByID(int ID)
        {
            return _dbContext.STUDENTs.Find(ID);
        }

        public void save()
        {
            _dbContext.SaveChanges();
        }

        public void insert(STUDENT student)
        {
            _dbContext.STUDENTs.Add(student);
            throw new NotImplementedException();
        }

        public void update(STUDENT student)
        {
            _dbContext.Entry(student).State = System.Data.Entity.EntityState.Modified;
            throw new NotImplementedException();
        }

        public void delete(int studentId)
        {
            STUDENT student = _dbContext.STUDENTs.Find(studentId);
            _dbContext.STUDENTs.Remove(student);
            throw new NotImplementedException();
        }
    }
}