using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShopLibrary
{
    public class Calculate: ICalculatePrice
    {
        const int 書的價錢 = 100;

        public double Sum(List<Book> shops)
        {
            double sum = 0;

            while (shops.Any())
            {
                sum += 計算一個群組的總和(ref shops);
            }

            return sum;
        }

        private double 計算一個群組的總和(ref List<Book> shops)
        {
            int count = 0;

            var 第一集 = shops.FirstOrDefault(w => w.Type == type.第一集);
            if (第一集 != null)
            {
                count++;
                shops.Remove(第一集);
            }

            var 第二集 = shops.FirstOrDefault(w => w.Type == type.第二集);
            if (第二集 != null)
            {
                count++;
                shops.Remove(第二集);
            }

            var 第三集 = shops.FirstOrDefault(w => w.Type == type.第三集);
            if (第三集 != null)
            {
                count++;
                shops.Remove(第三集);
            }

            var 第四集 = shops.FirstOrDefault(w => w.Type == type.第四集);
            if (第四集 != null)
            {
                count++;
                shops.Remove(第四集);
            }

            var 第五集 = shops.FirstOrDefault(w => w.Type == type.第五集);
            if (第五集 != null)
            {
                count++;
                shops.Remove(第五集);
            }

            return 計算群組搭配總和(count);
        }
        
        private double 計算群組搭配總和(int count)
        {
            int 群組未計算折扣的價錢 = count * 書的價錢;

            switch (count)
            {
                case 1:
                    return 群組未計算折扣的價錢 * 1;

                case 2:
                    return 群組未計算折扣的價錢 * 0.95;

                case 3:
                    return 群組未計算折扣的價錢 * 0.90;

                case 4:
                    return 群組未計算折扣的價錢 * 0.80;

                case 5:
                    return 群組未計算折扣的價錢 * 0.75;

                default:
                    return 群組未計算折扣的價錢;
            }
        }
    }
}
