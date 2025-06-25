using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            var item = GetItem(Items[i]);
            item.UpdateQuality();
        }
    }

    public WrappedItem GetItem(Item item)
    {
        switch (item.Name)
        {  
            case "Aged Brie": return new AgedBrie(item);
            case "Sulfuras, Hand of Ragnaros": return new Sulfuras(item);
            case "Backstage passes to a TAFKAL80ETC concert": return new BackstagePass(item);
            case "Conjured Mana Cake": return new Conjured(item);
            default: return new StandardItem(item);
        }
    }
}