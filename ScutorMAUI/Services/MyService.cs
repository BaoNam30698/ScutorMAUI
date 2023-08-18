using ScutorMAUI.Injectable;

namespace ScutorMAUI.Services
{
    public interface IMyService : ITransientDependency

    {

        public string Hello();

    }



    public class MyService : IMyService

    {

        public string Hello()

        {

            return "Hello World";

        }

    }
}
