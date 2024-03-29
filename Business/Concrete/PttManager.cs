﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //Constructor new yapıldığında çalışır 
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            // PersonManager personManager = new PersonManager();
            //if (personManager.CheckPerson(person))
            if(_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");

            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
    //bir iş sınıfı başka bir iş sınıfını çağırırken newliyorsa bu ilerde personmanagera bağlılıktan kaynaklı sıkıntı çıkarır
    //devlet vatandaş olmayana da maske verecem derse sistem patlar

        }
        
    }
}
