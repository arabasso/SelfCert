namespace SelfCert
{
    public class EnumSelectItem<T>
        : SelectItem<T>
    {
        public EnumSelectItem(
            T value)
            : base(value)
        {
            Description = Properties.Resources.ResourceManager.GetString(typeof(T).Name + value);
        }
    }
}