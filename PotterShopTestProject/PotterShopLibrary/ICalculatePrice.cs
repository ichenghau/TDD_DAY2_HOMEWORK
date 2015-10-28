using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShopLibrary
{
    public interface ICalculatePrice
    {
        /// <summary>
        /// 計算總金額
        /// </summary>
        /// <param name="shop">購買書</param>
        /// <returns></returns>
        double Sum(List<Book> shop);
    }
}
