using DoFactory.GangOfFour.Abstract.RealWorld;
using DoFactory.GangOfFour.Builder.RealWorld;

namespace GangOfFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunAbstractFactory();
            RunBuilder();
        }

        static void RunAbstractFactory()
        {
            AbstractFactory.Start();
        }

        static void RunBuilder()
        {
            Builder.Start();
        }
    }
}
