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
}