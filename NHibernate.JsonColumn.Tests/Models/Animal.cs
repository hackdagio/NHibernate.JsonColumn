namespace NHibernate.JsonColumn.Tests.Models
{
    public class Animal
    {
        public Animal()
        {
        }

        public Animal(float speed)
        {
            this.Speed = speed;
        }

        public float Speed { get; set; }
    }
}