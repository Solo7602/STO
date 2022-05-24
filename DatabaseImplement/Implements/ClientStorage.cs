using BuisnessLogic.BindingModels;
using BuisnessLogic.StorageInterfaces;
using BuisnessLogic.ViewModels;
using DatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseImplement.Implements
{
    public class ClientStorage : IClientStorage
    {
        public List<ClientViewModel> GetFullList()
        {
            using var context = new StoDatabase();
            return context.Clients
            .Select(CreateModel)
            .ToList();
        }
        public List<ClientViewModel> GetFilteredList(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new StoDatabase();
            return context.Clients
            .Where(rec => rec.Email.Contains(model.Email))
            .Select(CreateModel)
            .ToList();
        }
        public ClientViewModel GetElement(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new StoDatabase();
            var client = context.Clients
            .FirstOrDefault(rec => rec.PhoneNumber == model.PhoneNumber);
            if(client == null)
            {
                return null;
            }
            return client.Password == model.Password ? CreateModel(client) : null;
        }
        public void Insert(ClientBindingModel model)
        {
            using var context = new StoDatabase();
            Client element = context.Clients.FirstOrDefault(rec => rec.PhoneNumber ==
           model.PhoneNumber);
            if(element != null){
                throw new Exception("Телефон уже зарегистрирован");
            }
            context.Clients.Add(CreateModel(model, new Client()));
            context.SaveChanges();
        }
        public void Update(ClientBindingModel model)
        {
            using var context = new StoDatabase();
            var element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(ClientBindingModel model)
        {
            using var context = new StoDatabase();
            Client element = context.Clients.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Clients.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Client CreateModel(ClientBindingModel model, Client
       client)
        {
            client.Middlename = model.Middlename;
            client.Password = model.Password;
            client.Name = model.Name;
            client.Surname = model.Surname;
            client.PhoneNumber = model.PhoneNumber;
            client.Email = model.Email;
            return client;
        }
        private static ClientViewModel CreateModel(Client client)
        {
            return new ClientViewModel
            {
                Id = client.Id,
                Password = client.Password,
                MiddleName = client.Middlename,
                Name = client.Name,
                Surname = client.Surname,
                PhoneNumber = client.PhoneNumber,
                Email = client.Email
            };
        }
    }
}
