using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultilayerArchitecture.BusinessLayer;
using MultilayerArchitecture.BusinessLayer.DTO;

namespace MultilayerArchitecture
{
    public partial class Form1 : Form
    {
        private BusinessLogic business = new BusinessLogic();
        public Form1()
        {
            InitializeComponent();

            //comboBoxPredmet

            this.comboBoxPredmet.ValueMember = "idPredmet";
            this.comboBoxPredmet.DisplayMember = "predmetNaziv";
            this.comboBoxPredmet.DataSource = this.business.GetPredmets();
            this.comboBoxPredmet.SelectedIndex = -1;

            //listViewStudentIspit

            this.listViewStudentIspit.Columns.Add("columnRb", "RB");
            this.listViewStudentIspit.Columns.Add("columnImePrezime", "Ime Prezime");
            this.listViewStudentIspit.Columns.Add("columnIndeks", "Indeks");
            this.listViewStudentIspit.Columns.Add("columnPredmet", "Predmet");
            this.listViewStudentIspit.Columns.Add("columnOcena", "Ocena");
            this.listViewStudentIspit.Columns.Add("columnDatum", "Datum");
            this.listViewStudentIspit.View = View.Details;

            //dataGridViewStudent

            this.dataGridViewStudent.Columns.Add("columnRb", "RB");
            this.dataGridViewStudent.Columns.Add("columnIme", "Ime");
            this.dataGridViewStudent.Columns.Add("columnPrezime", "Prezime");
            this.dataGridViewStudent.Columns.Add("columnImePrezime", "Ime Prezime");
            this.dataGridViewStudent.Columns.Add("columnIndeksBr", "Indeks broj");
            this.dataGridViewStudent.Columns.Add("columnIndeksGod", "Indeks godina");
            this.dataGridViewStudent.Columns.Add("columnIndeks", "Indeks");
            this.dataGridViewStudent.Columns[0].ReadOnly = true;
            this.dataGridViewStudent.Columns[3].ReadOnly = true;
            this.dataGridViewStudent.Columns[6].ReadOnly = true;
            this.dataGridViewStudent.MultiSelect = false;

            //dataGridViewStudentIspit

            this.dataGridViewStudentIspit.Columns.Add("columnRb", "RB");
            this.dataGridViewStudentIspit.Columns.Add("columnImePrezime", "Ime Prezime");
            this.dataGridViewStudentIspit.Columns.Add("columnIndeks", "Indeks");
            this.dataGridViewStudentIspit.Columns.Add("columnPredmet", "Predmet");
            this.dataGridViewStudentIspit.Columns.Add("columnOcena", "Ocena");
            this.dataGridViewStudentIspit.Columns.Add("columnDatum", "Datum");



        }

        private void comboBoxPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            short id = 0;
            if (this.comboBoxPredmet.SelectedValue != null)
                id = (short)this.comboBoxPredmet.SelectedValue;

            var studentIspit = this.business.GetStudentIspits(id);

            fillListViewStudentIspit(studentIspit);
        }

        private void fillDataGridViewStudent()
        {
            int rb = 1;
            var studenti = this.business.GetStudents();
            this.dataGridViewStudent.Rows.Clear();
            foreach (var s in studenti)
            {
                int index = this.dataGridViewStudent.Rows.Add(rb.ToString(), s.ime, s.prezime, s.imePrezime,
                    s.indeksBroj.ToString(), s.indeksGodina.ToString(), s.indeksCalc);
                var row = this.dataGridViewStudent.Rows[index];
                row.Tag = s;
                rb++;
            }
        }

        private void fillDataGridViewStudentIspit(StudentIspitDto[] studentIspits)
        {
            int rb = 1;
            this.dataGridViewStudentIspit.Rows.Clear();
            foreach (var si in studentIspits)
            {
                int index = this.dataGridViewStudentIspit.Rows.Add(rb.ToString(), si.imePrezime, si.indeksCalc, si.predmetNaziv,
                    (si.ocena == null) ? "" : si.ocena.ToString(), si.ispitDatum.ToString());
                var row = this.dataGridViewStudentIspit.Rows[index];
                row.Tag = si;
                rb++;
            }
        }

        private void fillListViewStudentIspit(StudentIspitDto[] obj)
        {
            int rb = 1;
            this.listViewStudentIspit.Items.Clear();
            foreach (var si in obj)
            {
                ListViewItem item = new ListViewItem();
                item.Text = rb.ToString();
                item.SubItems.Add(si.imePrezime);
                item.SubItems.Add(si.indeksCalc);
                item.SubItems.Add(si.predmetNaziv);
                item.SubItems.Add((si.ocena == null) ? "" : si.ocena.ToString());
                item.SubItems.Add(si.ispitDatum.ToString());
                item.Tag = si;
                this.listViewStudentIspit.Items.Add(item);
                rb++;
            }
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            fillDataGridViewStudent();
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewStudent.CurrentRow == null)
                return;
            var row = this.dataGridViewStudent.CurrentRow;
            StudentDto student = row.Tag as StudentDto;

            StudentIspitDto[] studentIspit = this.business.GetStudentIspits(0, student.idStudent);

            fillDataGridViewStudentIspit(studentIspit);

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            StudentDto student = new StudentDto
            {
                ime = "Pera",
                prezime = "Peric",
                indeksBroj = 3,
                indeksGodina = 2015
            };
            try
            {
                this.business.InsertStudent(student);
                fillDataGridViewStudent();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewStudent.CurrentRow == null)
                return;
            var row = this.dataGridViewStudent.CurrentRow;
            StudentDto student = row.Tag as StudentDto;

            int id = student.idStudent;
            try
            {
                this.business.DeleteStudent(id);
                fillDataGridViewStudent();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewStudent.CurrentRow == null)
                return;
            var row = this.dataGridViewStudent.CurrentRow;
            StudentDto student = row.Tag as StudentDto;

            string ime = row.Cells[1].Value.ToString();
            string prezime = row.Cells[2].Value.ToString();
            int indeksBr = Convert.ToInt32(row.Cells[4].Value);
            int indeksGod = Convert.ToInt32(row.Cells[5].Value);
            try
            {
                if (ime == student.ime && prezime == student.prezime && indeksGod == student.indeksGodina && indeksBr == student.indeksBroj)
                    return;
                StudentDto newStudent = new StudentDto
                {
                    idStudent = student.idStudent,
                    ime = ime,
                    prezime = prezime,
                    indeksBroj = indeksBr,
                    indeksGodina = indeksGod
                };
                this.business.UpdateStudent(newStudent);
                fillDataGridViewStudent();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
