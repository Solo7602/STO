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
    public partial class FormRepair1 : Form
    {
        private readonly IRepairLogic _repairlogic;
        public FormRepair1(IRepairLogic repairlogic)
        {
            InitializeComponent();
            _repairlogic = repairlogic;
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
                        dataGridView.Rows.Add(new object[] { order.Id, order.Name, order.Sum, order.DateStart, order.DateEnd,
                            order.WorkId});
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
