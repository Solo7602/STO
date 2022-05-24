using BuisnessLogic.BindingModels;
using BuisnessLogic.BuisnessLogicInterfaces;
using BuisnessLogic.Enums;
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

namespace EmployeeView
{
    public partial class FormRepair1 : Form
    {
        private readonly IRepairLogic _repairlogic;
        private readonly IEmployeeLogic _employeelogic;
        public FormRepair1(IRepairLogic repairlogic, IEmployeeLogic employeeLogic)
        {
            InitializeComponent();
            _repairlogic = repairlogic;
            _employeelogic = employeeLogic;
        }

        private void FormRepair_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var list = _repairlogic.Read(null);
                if (list != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var order in list)
                    {
                        dataGridView.Rows.Add(new object[] { order.Id, order.Name, order.Sum, order.EmployeeId, order.Status, order.DateStart, order.DateEnd});
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            var a = _repairlogic.Read(new RepairBindingModel
            {
                Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value)
        })[0];
            _repairlogic.CreateOrUpdate(new RepairBindingModel
            {
                Id = a.Id,
                Name = a.Name,
                Sum = a.Sum,
                EmployeeId = Program.employee.Id,
                Status = RepairStatus.InProgress,
                DateStart = a.DateStart,
                DateEnd = DateTime.Now,
                WorkId = 1
            }) ;
            MessageBox.Show("Заказ успешно взят на выполнение" , "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            var a = _repairlogic.Read(new RepairBindingModel
            {
                Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value)
            })[0];
            _repairlogic.CreateOrUpdate(new RepairBindingModel
            {
                Id = a.Id,
                Name = a.Name,
                Sum = a.Sum,
                EmployeeId = Program.employee.Id,
                Status = RepairStatus.Ready,
                DateStart = a.DateStart,
                DateEnd = a.DateEnd,
                WorkId = 1
            });
            MessageBox.Show("Заказ успешно выполнен", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOver_Click(object sender, EventArgs e)
        {
            var a = _repairlogic.Read(new RepairBindingModel
            {
                Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value)
            })[0];
            _repairlogic.CreateOrUpdate(new RepairBindingModel
            {
                Id = a.Id,
                Name = a.Name,
                Sum = a.Sum,
                EmployeeId = Program.employee.Id,
                Status = RepairStatus.Issued,
                DateStart = a.DateStart,
                DateEnd = a.DateEnd,
                WorkId = 1
            });
            MessageBox.Show("Заказ успешно отправлен", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
