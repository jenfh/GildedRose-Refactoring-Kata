using GildedRoseKata.Interfaces;

namespace GildedRoseKata
{
    public class StandardItem : WrappedItem
    {
        public StandardItem(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            if (wrappedItem == null)
                return;


            if (wrappedItem.SellIn > 0)
            {
                wrappedItem.Quality -= 1;
            }
            else
            {
                wrappedItem.Quality -= 2;
            }

            if (wrappedItem.Quality < 0)
            {
                wrappedItem.Quality = 0;
            }

            wrappedItem.SellIn--;
        }
    }
}
