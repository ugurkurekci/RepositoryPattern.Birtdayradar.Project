using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBirthDayService
    {

        IResult Add(BirthDayRadar birthDayRadar);
        IResult Delete(BirthDayRadar birthDayRadar);
        IResult Update(BirthDayRadar birthDayRadar);
        IDataResult<List<BirthDayRadar>> GetAll();
        IDataResult<BirthDayRadar> GetById(int id);
        IDataResult<BirthDayRadar> GetByName(string name);
        IDataResult<BirthDayRadar> GetBySurname(string surname);
        IDataResult<BirthDayRadar> GetByTelephone(string telephone);
        IDataResult<BirthDayRadar> GetByDate(DateTime date);


    }
}
