using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShopLibrary;
using System.Collections.Generic;

namespace PotterShopTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //User Story
        //哈利波特一到五冊熱潮正席捲全球，世界各地的孩子都為之瘋狂。
        //出版社為了慶祝TDD課程招生順利，決定訂出極大的優惠，來回饋給為了小孩四處奔波買書的父母親們。
        //定價的方式如下：
        //1. 一到五集的哈利波特，每一本都是賣100元
        //2. 如果你從這個系列買了兩本不同的書，則會有5%的折扣
        //3. 如果你買了三本不同的書，則會有10%的折扣
        //4. 如果是四本不同的書，則會有20%的折扣
        //5. 如果你一次買了整套一到五集，恭喜你將享有25%的折扣
        //6. 需要留意的是，如果你買了四本書，其中三本不同，第四本則是重複的，
        //   那麼那三本將享有10%的折扣，但重複的那一本，則仍須100元。
        // 你的任務是，設計一個哈利波特的購物車，能提供最便宜的價格給這些爸爸媽媽。
        [TestMethod]
        public void 第一集買了一本_其他都沒買_價格應為100元()
        {
            //arrange
            var target = new Calculate();
            var list = new List<Book>()
            {
             new Book { id=1,  Type = type.第一集 }
            };
            var expected = 100;

            //act
            var actual = target.Sum(list);
            
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 第一集買了一本_第二集也買了一本_價格應為190()
        {
            //arrange
            var target = new Calculate();
            var list = new List<Book>()
            {
             new Book { id=1,  Type = type.第一集 },
             new Book { id=2,  Type = type.第二集 }
            };
            var expected = 190;

            //act
            var actual = target.Sum(list);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三集各買了一本_價格應為270()
        {
            //arrange
            var target = new Calculate();
            var list = new List<Book>()
            {
             new Book { id=1,  Type = type.第一集 },
             new Book { id=2,  Type = type.第二集 },
             new Book { id=3,  Type = type.第三集 }
            };
            var expected = 270;

            //act
            var actual = target.Sum(list);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三四集各買了一本_價格應為320()
        {
            //arrange
            var target = new Calculate();
            var list = new List<Book>()
            {
             new Book { id=1,  Type = type.第一集 },
             new Book { id=2,  Type = type.第二集 },
             new Book { id=3,  Type = type.第三集 },
             new Book { id=3,  Type = type.第四集 }
            };
            var expected = 320;

            //act
            var actual = target.Sum(list);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一次買了整套_一二三四五集各買了一本_價格應為375()
        {
            //arrange
            var target = new Calculate();
            var list = new List<Book>()
            {
             new Book { id=1,  Type = type.第一集 },
             new Book { id=2,  Type = type.第二集 },
             new Book { id=3,  Type = type.第三集 },
             new Book { id=4,  Type = type.第四集 },
             new Book { id=5,  Type = type.第五集 }
            };
            var expected = 375;

            //act
            var actual = target.Sum(list);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}

