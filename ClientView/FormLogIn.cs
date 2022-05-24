using BuisnessLogic.BindingModels;
using BuisnessLogic.BuisnessLogicInterfaces;
using BuisnessLogic.StorageInterfaces;
using BuisnessLogic.ViewModels;
using ClientView;
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

namespace EmployeeView
{
    public partial class FormLogIn : Form
    {
        private readonly IEmployeeLogic _logic;
        public FormLogIn(IEmployeeLogic logic, IEmployeeStorage storage)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormEmployee>();
            form.ShowDialog();
        }

        private void button_SingIn_Click(object sender, EventArgs e)
        {
            if (textBox_Password.Text == String.Empty)
            {
                MessageBox.Show("Введите корректный пароль", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBox_Phone.Text == String.Empty)
            {
                MessageBox.Show("Телефон не может быть пустым", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            EmployeeViewModel viewModel =
            _logic.Check(new EmployeeBindingModel()
            {
                EmployeePassword = textBox_Password.Text,
                EmployeePhoneNumber = textBox_Phone.Text,
            });
            if (viewModel == null)
            {
                MessageBox.Show("Такого клиента не существует, проверьте данные.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = Program.Container.Resolve<FormMain>();
            form.ShowDialog();
        }
    }
}
