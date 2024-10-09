namespace Day_7
{
   //multiple inheritance
   public interface IWalk
    {
        void Walk();
    }
    public interface IFly
    {
        void Fly();
    }
    public class Bird : IWalk, IFly
    {
        public void Walk()
        {
            Console.WriteLine("the bird is walking");
        }
        public void Fly()
        {
            Console.WriteLine("the bird is flying");
        }
    }
    internal class Program
    {
        static void Main0(string[] args)
        {
          Bird b=new Bird();
            b.Walk();
            b.Fly();
        }
    }
}
