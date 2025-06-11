using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    public void StandardItem_Quality_Degrading_Test()
    {
        var items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(6));
    }

    [Test]
    public void StandardItem_Quality_Fast_Degrading_Test()
    {
        var items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = -1, Quality = 5 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(3));
    }

    [Test]
    public void StandardItem_No_Negative_Quality_Test()
    {
        var items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = -2, Quality = 1 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(0));
    }

    [Test]
    public void StandardItem_Decreasing_SellIn_Test()
    {
        var items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 10, Quality = 20 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].SellIn, Is.EqualTo(9));
    }

    [Test]
    public void AgedBrie_Increasing_Quality_Test()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(1));
    }

    [Test]
    public void AgedBrie_Quality_Fast_Increasing_Test()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -1, Quality = 0 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(2));
    }

    [Test]
    public void AgedBrie_Max_Quality_Test()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(50));
    }

    [Test]
    public void AgedBrie_Decreasing_SellIn_Test()
    {
        var items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 50 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].SellIn, Is.EqualTo(-1));
    }

    [Test]
    public void Sulfuras_Constant_Quality_Test()
    {
        var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Quality, Is.EqualTo(80));
    }

    [Test]
    public void Sulfuras_Constant_SellIn_Test()
    {
        var items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 } };
        GildedRose app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].SellIn, Is.EqualTo(-1));
    }

    [Test]
        public void BackstagePass_Increasing_Quality_More_Than_Ten_Days_Test()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 20 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(21));
        }

        [Test]
        public void BackstagePass_Increasing_Quality_Between_Six_And_Ten_Days_Upper_Test()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(22));
        }

        [Test]
        public void BackstagePass_Increasing_Quality_Between_Six_And_Ten_Days_Lower_Test()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 20 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(22));
        }

        [Test]
        public void BackstagePass_Increasing_Quality_Between_Five_And_One_Day_Upper_Test()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(23));
        }

        [Test]
        public void BackstagePass_Increasing_Quality_Between_Five_And_One_Day_Lower_Test()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 20 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(23));
        }

        [Test]
        public void BackstagePass_Drop_Quality_Zero_Days_Test()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 49 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(0));
        }

        [Test]
        public void BackstagePass_Decreasing_SellIn_Test()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = 49 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].SellIn, Is.EqualTo(0));
        }

        [Test]
        public void BackstagePass_Max_Quality_Test()
        {
            var items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 49 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(50));
        }
}