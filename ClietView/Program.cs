using BuisnessLogic.BindingModels;
using BuisnessLogic.BuisnessLogic;
using BuisnessLogic.BuisnessLogicInterfaces;
using BuisnessLogic.BusinessLogic.OfficePackage;
using BuisnessLogic.BusinessLogic.OfficePackage.Implements;
using BuisnessLogic.StorageInterfaces;
using BuisnessLogic.ViewModels;
using ClietView;
using DatabaseImplement.Implements;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace ClientView
{
    internal static class Program
    {
        private static IUnityContainer container = null;
        public static ClientViewModel client = null;
        public static IUnityContainer Container
        {
            get
            {
                if (container == null)
                {
                    container = BuildUnityContainer();
                }
                return container;
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Container.Resolve<MailWorker>().MailConfig(new MailConfigBindingModel()
            {
                MailLogin = ConfigurationManager.AppSettings["MailLogin"],
                MailPassword =
            ConfigurationManager.AppSettings["MailPassword"],
                SmtpClientHost =
            ConfigurationManager.AppSettings["SmtpClientHost"],
                SmtpClientPort =
            Convert.ToInt32(ConfigurationManager.AppSettings["SmtpClientPort"]),
                PopHost = ConfigurationManager.AppSettings["PopHost"],
                PopPort =
            Convert.ToInt32(ConfigurationManager.AppSettings["PopPort"])
            });
            Application.Run(Container.Resolve<FormRegistration>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IClientStorage,
            ClientStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IPaymentStorage, PaymentStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IRepairStorage, RepairStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IClientLogic, ClientLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IRepairLogic, RepairLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IPaymentLogic, PaymentLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IWorkLogic, WorkLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IStaffLogic, StaffLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IEmployeeLogic, EmployeeLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IWorkStorage, WorkStorage>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IStaffStorage, StaffStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IEmployeeStorage, EmployeeStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReportToExcel, SaveToExcel>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReportToPdf, SaveToPdf>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReportLogic>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<MailWorker>(new
            HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
