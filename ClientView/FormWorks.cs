using BuisnessLogic.BindingModels;
using BuisnessLogic.BuisnessLogicInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeView
{
    public partial class FormWorks : Form
    {
        public int Id { set { id = value; } }
        private readonly IWorkLogic _logic;
        private int? id;

        public FormWorks(IWorkLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                _logic.CreateOrUpdate(new WorkBindingModel
                {
                    Id = id,
                    WorkName = textBox_Name.Text,
                    WorkPrice = Convert.ToInt32(textBox_Price.Text)

                });
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
