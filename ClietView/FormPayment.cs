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

namespace ClientView
{
    public partial class FormPayment : Form
    {
        private readonly IPaymentLogic _logic;
        private readonly IRepairLogic _logicRep;
        public int Id { set { id = value; } }
        private int id;
        public FormPayment(IPaymentLogic paymentLogic, IRepairLogic logicRep)
        {
            _logicRep = logicRep;
            _logic = paymentLogic;
            InitializeComponent();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            try
            {
                var lastPay = _logic.GetLastPay(new PaymentBindingModel() { RepairId = id });
                int remain= _logicRep.Read(new RepairBindingModel() { Id = id})[0].Sum - Convert.ToInt32(textBoxSum.Text);
                if(lastPay != null)
                {
                    remain = lastPay.Remain - Convert.ToInt32(textBoxSum.Text);
                    if (remain < 0) remain = 0;
                }
                
                _logic.CreateOrUpdate(new PaymentBindingModel
                {
                    Remain = remain,
                    RepairId = id,
                    Sum = Convert.ToInt32(textBoxSum.Text),

                });
                MessageBox.Show("Оплата прошла успешно, осталось оплатить: "+remain, "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            try
            {
                var lastPay = _logic.GetLastPay(new PaymentBindingModel() { RepairId = id });
                labelRemain.Text = lastPay.Remain.ToString();

                var list = _logic.Read(new PaymentBindingModel() { RepairId = id});
                if (list != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var repair in list)
                    {
                        dataGridView.Rows.Add(new object[] { repair.Sum, repair.RepairId });
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
