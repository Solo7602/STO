using BuisnessLogic.BindingModels;
using BuisnessLogic.BuisnessLogicInterfaces;
using BuisnessLogic.Enums;
using BuisnessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientView
{
    public partial class FormRepair : Form
    {
        private readonly IRepairLogic _logic;
        private readonly IWorkLogic logicWork;
        public int Id { set { id = value; } }
        private int? id;
        public FormRepair(IRepairLogic repairLogic, IWorkLogic workLogic)
        {
            logicWork = workLogic;
            _logic = repairLogic;
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                _logic.CreateOrUpdate(new RepairBindingModel
                {
                    Id = id,
                    Sum = Convert.ToInt32(textBoxSum.Text),
                    DateStart = DateTime.Now,
                    Status = RepairStatus.Adopted,
                    Name = textBoxName.Text,
                    ClientId = Program.client.Id,
                    WorkId = (int)comboBoxWork.SelectedValue

                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }


        private void FormRepair_Load(object sender, EventArgs e)
        {

            comboBoxWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            var list = logicWork.Read(null);
            foreach (var component in list)
            {
                comboBoxWork.DisplayMember = "WorkName";
                comboBoxWork.ValueMember = "Id";
                comboBoxWork.DataSource = list;
                comboBoxWork.SelectedItem = null;
            }
            if (id.HasValue)
            {
                try
                {
                    RepairViewModel view = _logic.Read(new RepairBindingModel
                    { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        WorkViewModel work = logicWork.Read(new WorkBindingModel { Id = view.WorkId })[0];
                        textBoxSum.Text = work.WorkPrice.ToString();
                        comboBoxWork.SelectedValue = work.Id;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxWork.SelectedValue == null) return;
            int workId = (int)comboBoxWork.SelectedValue;
            if (workId<0) return;
            WorkViewModel work = logicWork.Read(new WorkBindingModel {Id = workId })[0];
            if (work == null) return;
            textBoxSum.Text = work.WorkPrice.ToString();
        }
    }
    
}
