using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightPointTest.Models.DbModels
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        /*
         * Я думаю время работы для ознакомительных целей лучше хранить в строке,
         * т.к. если хранить нормально, то нужно будет формаровать сроки(например пн. 17.00-2.00)
         * в случае если у некоторых магазинов сложное время работы
         * (отличается каждый день, переходит через полночь, сложные перерывы или др.) это может оказаться существенным,
         * храня время работы в строках этих проблем не будет, возможно только придется контролировать добавление в БД
         * ну и в большинстве случаев это будет занимать больше места, если это проблема, тогда тоже нужно хранить в отдельной таблице
          */
        public string WorkTimeString { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}