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

namespace EmployeeView
{
    public partial class FormWork : Form
    {
        public readonly IWorkLogic _worklogic;
        public FormWork(IWorkLogic logic)
        {
            InitializeComponent();
            _worklogic = logic;
        }
        private void LoadData()
        {
            try
            {
                var list = _worklogic.Read(null);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = true;
                    dataGridView.Columns[1].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormWork_Load(object sender, EventArgs e)
        {
           LoadData();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormWorks>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _worklogic.Delete(new WorkBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void button_Upd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormWorks>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void button_ref_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
