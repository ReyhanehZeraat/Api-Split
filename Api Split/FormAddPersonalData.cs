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
    public partial class FormAddPersonalData : Form
    {
        public FormAddPersonalData()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person= new Person();
            person.Name=txtName.Text;
            person.Family=txtFamily.Text;
            person.NationalCode=txtNationalCode.Text;
            person.Gender=txtGender.Text;

            var FormProperties = Application.OpenForms["FormProperties"] as FormProperties;
            FormProperties.people.Add(person);
            MessageBox.Show("اطلاعات با موفقیت ثبت شد");
            txtName.Text = null;
            txtFamily.Text = null;
            txtNationalCode.Text = null;
            txtGender.Text = null;
        }
    }
}
