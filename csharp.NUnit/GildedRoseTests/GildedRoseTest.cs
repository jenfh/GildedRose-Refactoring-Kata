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

}