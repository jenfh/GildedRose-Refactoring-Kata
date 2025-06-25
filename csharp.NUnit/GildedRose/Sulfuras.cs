namespace GildedRoseKata
{
    public class Sulfuras : WrappedItem
    {
        public Sulfuras(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            if (wrappedItem == null) 
                return;

            wrappedItem.Quality = 80;
        }
    }
}
