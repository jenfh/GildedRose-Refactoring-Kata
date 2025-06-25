using GildedRoseKata.Interfaces;

namespace GildedRoseKata
{
    public abstract class WrappedItem : IQualityHandler
    {
        protected Item wrappedItem;

        public WrappedItem(Item item)
        {
            this.wrappedItem = item;
        }

        public abstract void UpdateQuality();
    }
}
