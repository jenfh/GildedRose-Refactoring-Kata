namespace GildedRoseKata
{
    public class AgedBrie : WrappedItem
    {
        public AgedBrie(Item item) : base(item) 
        {
        }

        public override void UpdateQuality()
        {
            if (wrappedItem.SellIn > 0)
            {
                wrappedItem.Quality += 1;
            }
            else
            {
                wrappedItem.Quality += 2;
            }

            if (wrappedItem.Quality > 50)
            {
                wrappedItem.Quality = 50;
            }

            wrappedItem.SellIn--;
        }
    }
}
