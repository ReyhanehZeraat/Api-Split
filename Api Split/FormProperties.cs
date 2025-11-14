using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Api_Split
{
    public partial class FormProperties : Form
    {
       public List<Person> people = new List<Person>();
        public FormProperties()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddPersonalData FormAdd = new FormAddPersonalData();
            FormAdd.ShowDialog();
            FillData();
        }

        private void FormProperties_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            dataGridViewPerson.DataSource= people.ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int SelectedIndex = dataGridViewPerson.CurrentRow.Index;
            if (SelectedIndex >= 0 && SelectedIndex < people.Count ) 
            { 
                people.RemoveAt(SelectedIndex);
                dataGridViewPerson.DataSource = null;
                dataGridViewPerson.DataSource = people;
            }
            else
            {
                MessageBox.Show("لطفا یک ردیف انتخاب کنید");
            }
           

            

        }
    }
}
