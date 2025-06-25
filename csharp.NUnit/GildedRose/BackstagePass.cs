namespace GildedRoseKata
{
    public class BackstagePass : WrappedItem
    {
        public BackstagePass(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            if (wrappedItem == null)
                return;

            if (wrappedItem.SellIn > 10)
            {
                wrappedItem.Quality += 1;
            }
            else if (wrappedItem.SellIn >= 6 && wrappedItem.SellIn <= 10)
            {
                wrappedItem.Quality += 2;
            }
            else if (wrappedItem.SellIn >= 1 && wrappedItem.SellIn <= 5)
            {
                wrappedItem.Quality += 3;
            }
            else
            {
                wrappedItem.Quality = 0;
            }

            if (wrappedItem.Quality > 50)
            {
                wrappedItem.Quality = 50;
            }

            wrappedItem.SellIn--;
        }
    }
}
