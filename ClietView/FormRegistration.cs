using BuisnessLogic.BindingModels;
using BuisnessLogic.BuisnessLogicInterfaces;
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
    public partial class FormRegistration : Form
    {
        private readonly IClientLogic _logic;
        public FormRegistration(IClientLogic clientLogic)
        {
            _logic = clientLogic;
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("Введите корректный пароль", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if(textBoxName.Text == String.Empty)
            {
                MessageBox.Show("Имя не может быть пустым", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBoxSurname.Text == String.Empty)
            {
                MessageBox.Show("Фамилия не может быть пустой", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBoxMiddlename.Text == String.Empty)
            {
                MessageBox.Show("Отчество не может быть пустым", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBoxPhoneNumber.Text == String.Empty)
            {
                MessageBox.Show("Введите корректный пароль", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBoxEmail.Text == String.Empty)
            {
                MessageBox.Show("Введите корректную почту", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            try
            {
                ClientBindingModel bindingModel = new ClientBindingModel() 
                {
                    Name = textBoxName.Text,
                    Password = textBoxPassword.Text,
                    Surname = textBoxSurname.Text,
                    Middlename = textBoxMiddlename.Text,
                    PhoneNumber = textBoxPhoneNumber.Text,
                    Email = textBoxEmail.Text
                };
                _logic.CreateOrUpdate(bindingModel);
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                var form = Program.Container.Resolve<FormLogin>();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void labelEnter_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormLogin>();
            form.ShowDialog();
        }
    }
}
