﻿using Bus.Data;
using Bus.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bus.Services
{
    public class BusDetailsService:IBusdetailsService
    {
        private IRepository<BusDetails> _busRepo;
        public BusDetailsService(IRepository<BusDetails> busRepo)
        {
            _busRepo = busRepo;
        }

        public void AddBuss(BusDetails bus)
        {
       
            _busRepo.Create(bus);
        }

        public void DeletBus(int id)
        {
            var bus = _busRepo.GetById(id);
            _busRepo.Delete(bus);
            _busRepo.SaveChanges();
        }

        public IEnumerable<BusDetails> GetAllBus()
        {
            return _busRepo.GetAll().ToList();
        }

        public BusDetails GetBusbyID(int id)
        {
            return _busRepo.GetById(id);
        }

        public void UpdateBus(BusDetails bus)
        {
            _busRepo.Update(bus);
        }
    }
}
