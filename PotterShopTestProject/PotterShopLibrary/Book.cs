using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShopLibrary
{
    public class Book
    {
        public type Type { get; set; }
    }

    /// <summary>
    /// 哈利波特一到五冊
    /// </summary>
    public enum type
    {
        第一集,

        第二集,

        第三集,

        第四集,

        第五集
    }
}
