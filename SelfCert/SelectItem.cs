namespace SelfCert
{
    public class SelectItem<T>
    {
        public T Value { get; set; }
        public string Description { get; set; }

        public SelectItem()
        {
        }

        public SelectItem(
            T value)
        {
            Value = value;
        }

        public SelectItem(
            T value,
            string description)
        {
            Value = value;
            Description = description;
        }
    }
}
