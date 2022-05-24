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
using Unity;

namespace ClientView
{
    public partial class FormMain : Form
    {
        private IRepairLogic repairLogic;
        public FormMain(IRepairLogic repair)
        {
            repairLogic = repair;
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                var list = repairLogic.Read(new RepairBindingModel()
                {
                    ClientId = Program.client.Id
                });
                if (list != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var repair in list)
                    {
                        dataGridView.Rows.Add(new object[] {repair.Id,  repair.Name, repair.Sum,
                            repair.Status,repair.DateStart, repair.DateEnd});
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelName.Text = Program.client.Name;
            labelSurname.Text = Program.client.Surname;
            LoadData();
        }

        private void buttonCreateRepair_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormRepair>();
            form.ShowDialog();
            LoadData();
        }

        private void buttonDeleteRepair_Click(object sender, EventArgs e)
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
                        repairLogic.Delete(new RepairBindingModel { Id = id });
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

        private void buttonUpdateRepair_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormRepair>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                form.ShowDialog();
                LoadData();
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormPayment>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                form.ShowDialog();
                LoadData();
            }
        }
    }
}
