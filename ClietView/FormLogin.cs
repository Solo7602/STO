using BuisnessLogic.BindingModels;
using BuisnessLogic.BuisnessLogicInterfaces;
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

namespace ClietView
{
    public partial class FormLogin : Form
    {
        private readonly IClientLogic _logic;
        public FormLogin(IClientLogic clientLogic)
        {
            _logic = clientLogic;
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("Введите корректный пароль", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBoxPhoneNumber.Text == String.Empty)
            {
                MessageBox.Show("Телефон не может быть пустым", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            ClientViewModel viewModel =
            _logic.GetClient(new ClientBindingModel()
            {
                Password = textBoxPassword.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
            });
            if(viewModel == null)
            {
                MessageBox.Show("Такого клиента не существует, проверьте данные.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.client = viewModel;
            var form = Program.Container.Resolve<FormMain>();
            form.ShowDialog();

        }

        private void labelEnter_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormRegistration>();
            form.ShowDialog();
        }
    }
}
