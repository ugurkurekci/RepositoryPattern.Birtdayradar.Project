using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BirthDayManager : IBirthDayService

    {
        IBirthDayRadar _birthDayRadar;

        public BirthDayManager(IBirthDayRadar birthDayRadar)
        {
            _birthDayRadar = birthDayRadar;
        }

        public IResult Add(BirthDayRadar birthDayRadar)
        {
            IResult result = BusinessRules.Run(EklemeKuralı(birthDayRadar.Telephone));
            if (result != null)
            {
                return result;
            }
            _birthDayRadar.Add(birthDayRadar);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(BirthDayRadar birthDayRadar)
        {
            _birthDayRadar.Delete(birthDayRadar);
            return new SuccessResult();
        }

        public IDataResult<List<BirthDayRadar>> GetAll()
        {
            return new SuccessDataResult<List<BirthDayRadar>>(_birthDayRadar.GetAll());
        }

        public IDataResult<BirthDayRadar> GetByDate(DateTime date)
        {
            return new SuccessDataResult<BirthDayRadar>(_birthDayRadar.Get(x => x.Date == date));
        }

        public IDataResult<BirthDayRadar> GetById(int id)
        {
            return new SuccessDataResult<BirthDayRadar>(_birthDayRadar.Get(x => x.Id == id));
        }

        public IDataResult<BirthDayRadar> GetByName(string name)
        {
            return new SuccessDataResult<BirthDayRadar>(_birthDayRadar.Get(x => x.Name == name));

        }

        public IDataResult<BirthDayRadar> GetBySurname(string surname)
        {
            return new SuccessDataResult<BirthDayRadar>(_birthDayRadar.Get(x => x.Surname == surname));
        }

        public IDataResult<BirthDayRadar> GetByTelephone(string telephone)
        {
            return new SuccessDataResult<BirthDayRadar>(_birthDayRadar.Get(x => x.Telephone == telephone));
        }

        public IResult Update(BirthDayRadar birthDayRadar)
        {
            _birthDayRadar.Update(birthDayRadar);
            return new SuccessResult();
        }

        private IResult EklemeKuralı(string Telephone)
        {
            var result = _birthDayRadar.GetAll(p => p.Telephone == Telephone).Any();
            if (result)
            {
                return new ErrorResult("Aynı telefon numarası ile kayıt bulunmaktadır.");

            }
            return new SuccessResult();
        }
    }
}
