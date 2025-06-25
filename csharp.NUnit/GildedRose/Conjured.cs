namespace GildedRoseKata
{
    public class Conjured : WrappedItem
    {
        public Conjured(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            if (wrappedItem == null)
                return;

            wrappedItem.Quality -= 2;

            if (wrappedItem.SellIn < 0)
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
