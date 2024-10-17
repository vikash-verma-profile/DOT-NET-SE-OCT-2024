namespace Day_10
{
    public class ResourceHolder : IDisposable
    {
        // created to clean up unmanged resources
        ~ResourceHolder() { 
            //finalizer logic here
            Dispose(false);
        }
        private bool _disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); //prevents the finalizer from being called
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    //Dispose managed resource
                }
                //Clean up unmanaged resource
                _disposed = true;
            }
        }
    }

    internal class Program
    {
        ~Program() { }
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");



            using (ResourceHolder res = new ResourceHolder())
            {

            }//Disponse is automatically called if you are using using keyword
        }
    }
}
