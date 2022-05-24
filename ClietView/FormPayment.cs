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
                PaymentBindingModel nextPay = new PaymentBindingModel();
                if (lastPay != null)
                {
                    nextPay.Sum = Convert.ToDecimal(textBoxSum.Text);
                    nextPay.Remain=lastPay.Remain- Convert.ToDecimal(textBoxSum.Text);
                }
                else
                {
                    var sumTemp = _logicRep.Read(new RepairBindingModel() { Id = id })[0].Sum;
                    nextPay.Sum = Convert.ToDecimal(textBoxSum.Text);
                    nextPay.Remain=sumTemp - Convert.ToDecimal(textBoxSum.Text);
                }
                nextPay.RepairId = id;
                nextPay.Date = DateTime.Now;
                
                _logic.CreateOrUpdate(nextPay);
                MessageBox.Show("Оплата прошла успешно, осталось оплатить: "+nextPay.Remain, "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if(lastPay != null)
                {
                    labelRemain.Text = lastPay.Remain.ToString();
                }
                

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
