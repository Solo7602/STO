using BuisnessLogic.BindingModels;
using BuisnessLogic.BuisnessLogicInterfaces;
using EmployeeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ClientView
{
    public partial class FormEmployee : Form
        
    {
        private readonly IEmployeeLogic _logic;
        public FormEmployee(IEmployeeLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                _logic.CreateOrUpdate(new EmployeeBindingModel
                {
                    EmployeeName = textBox_Name.Text,
                    EmployeeSurname = textBox_Surname.Text,
                    EmployeeMiddlename = textBox_Middlename.Text,
                    EmployeePhoneNumber = textBox_PhoneNumber.Text,
                    EmployeePassword = textBox_Password.Text,
                    EmployeePrize = 0
                }) ;
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
