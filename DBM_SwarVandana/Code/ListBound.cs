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
        public ListBound(object SLvalue, string type)
        {
            switch (type)
            {
                case "States":
                    States = new SelectList((new CentreRepository().GetStates()), "StateId", "StateName");
                    break;
                case "Centres":
                    Centres = new SelectList((new UsersRepository().GetAllCentres()), "CentreId", "CentreName");
                    break;
                case "Sources":
                    Sources = new SelectList((new SourceRepository().GetAllSources()), "SourceId", "Source");
                    break;
                case "Disciplines":
                    Disciplines = new SelectList((new DisciplineRepository().GetAllDisciplines()), "DisciplineId", "Discipline");
                    break;
                case "Users":
                    Users = new SelectList((new UsersRepository().GetAllUsers()), "UserId", "UserName");
                    break;
                case "Faculties":
                    Faculties = new SelectList((new FacultyRepository().GetFacultyByCentreId(0)), "FacultyId", "NameOfFaculty");
                    break;
                default:
                    // commisionTypeSL = new SelectList(commisionType);
                    break;
            }
        }
    }

}
