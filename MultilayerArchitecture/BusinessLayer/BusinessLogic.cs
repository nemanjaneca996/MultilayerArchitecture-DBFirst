using MultilayerArchitecture.BusinessLayer.DTO;
using MultilayerArchitecture.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayerArchitecture.BusinessLayer
{
    public class BusinessLogic
    {
        private StudijeEntities _entities = new StudijeEntities();
        public PredmetDto[] GetPredmets()
        {
            return this._entities.Predmet.Select(obj => new PredmetDto
            {
                idPredmet = obj.idPredmet,
                predmetNaziv = obj.predmetNaziv
            }).ToArray();
        }

        public StudentIspitDto[] GetStudentIspits(int idPredmet = 0, int idStudent = 0)
        {
            var query = this._entities.StudentIspit.AsQueryable();

            if (idPredmet != 0)
                query = query.Where(x => x.Ispit.Predmet.idPredmet == idPredmet);

            if (idStudent != 0)
                query = query.Where(x => x.Student.idStudent == idStudent);

            return query.Select(obj => new StudentIspitDto
            {
                idPredmet = obj.Ispit.Predmet.idPredmet,
                idStudent = obj.Student.idStudent,
                imePrezime = obj.Student.imePrezime,
                indeksCalc = obj.Student.indeksCalc,
                ocena = obj.ocena,
                predmetNaziv = obj.Ispit.Predmet.predmetNaziv,
                ispitDatum = obj.Ispit.ispitDatum
            }).ToArray();
        }

        public StudentDto[] GetStudents()
        {
            return this._entities.Student.Select(obj => new StudentDto
            {
                ime = obj.ime,
                prezime = obj.prezime,
                imePrezime = obj.imePrezime,
                idStudent = obj.idStudent,
                indeksBroj = obj.indeksBroj,
                indeksGodina = obj.indeksGodina,
                indeksCalc = obj.indeksCalc
            }).ToArray();
        }

        public void InsertStudent(StudentDto dtoStudent)
        {
            Student student = new Student
            {
                ime = dtoStudent.ime,
                prezime = dtoStudent.prezime,
                indeksBroj = dtoStudent.indeksBroj,
                indeksGodina = dtoStudent.indeksGodina
            };
            this._entities.Student.Add(student);
            this._entities.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var student = this._entities.Student.Find(id);
            this._entities.Student.Remove(student);
            this._entities.SaveChanges();
        }

        public void UpdateStudent(StudentDto dtoStudent)
        {
            Student student = this._entities.Student.Find(dtoStudent.idStudent);
            student.ime = dtoStudent.ime;
            student.prezime = dtoStudent.prezime;
            student.indeksBroj = dtoStudent.indeksBroj;
            student.indeksGodina = dtoStudent.indeksGodina;
            this._entities.SaveChanges();
        }

    }
}
