using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Web_Reporsitory.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<STUDENT> GetAll();
        STUDENT GetByID(int id);
        void insert(STUDENT student);
        void update(STUDENT student);
        void delete(int studentId);
        void save();
    }
}