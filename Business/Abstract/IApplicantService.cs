using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
       
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);

        //bunlar metotların imzaları
        //bununla yazılımda bağımlılığı çözeceğiz

        // interfaceler belli metot imzalarını barındırırlar birbirlerninin alternatifi olan sistemlerin farklı implementasyon yapmasını sağlarlar
       
    }

}

