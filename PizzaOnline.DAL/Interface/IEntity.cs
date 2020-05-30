namespace PizzaOnline.DAL.Interface
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
