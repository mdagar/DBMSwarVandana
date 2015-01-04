using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Repositories;
namespace Code
{
    public class ListBound
    {
        public SelectList States;
        public SelectList Centres;
        public SelectList Sources;
        public SelectList Disciplines;
        public SelectList Users;
        public SelectList Faculties;
        public SelectList Students;
        public SelectList ExpenseFor;
        public SelectList EnquiriesByUser;
        public ListBound(object SLvalue, string type)
        {
            switch (type)
            {
                case "States":
                    States = new SelectList((new CentreRepository().GetStates()), "StateId", "StateName");
                    break;
                case "Centres":
                    Centres = new SelectList((new UsersRepository().GetAllCentres()), "CentreId", "CentreName",SLvalue);
                    break;
                case "Sources":
                    Sources = new SelectList((new SourceRepository().GetAllSources()), "SourceId", "Source");
                    break;
                case "Disciplines":
                    Disciplines = new SelectList((new DisciplineRepository().GetAllDisciplines(SessionWrapper.User.CentreId)), "DisciplineId", "Discipline");
                    break;
                case "Users":
                    Users = new SelectList((new UsersRepository().AllUsers(SessionWrapper.User.CentreId)), "UserId", "UserName");
                    break;
                case "Faculties":
                    Faculties = new SelectList((new FacultyRepository().GetAllFacultyByCentreId(SessionWrapper.User.CentreId)), "FacultyId", "NameOfFaculty");
                    break;
                case "Students":
                    Students = new SelectList((new StudentsRepository().GetStudentsByCentreId(0)), "StudentId", "Name");
                    break;
                case "ExpenseFor":
                    ExpenseFor = new SelectList((new BudgetRepository().GetExpenseForAll()), "ExpenseForId", "ExpenseFor");
                    break;
                case "EnquiriesByUser":
                    EnquiriesByUser = new SelectList((new EnquiryRepository().GetUsersForEnquiryBy(SessionWrapper.User.CentreId)), "UserId", "UserName");
                    break;
                default:
                    // commisionTypeSL = new SelectList(commisionType);
                    break;
            }
        }
    }

}
