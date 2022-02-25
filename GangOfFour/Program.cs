using DoFactory.GangOfFour.Abstract.RealWorld;
using DoFactory.GangOfFour.Builder.RealWorld;
using DoFactory.GangOfFour.Factory.RealWorld;

namespace GangOfFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunAbstractFactory();
            RunBuilder();
            RunFactoryMethod();
        }

        static void RunAbstractFactory()
        {
            AbstractFactory.Start();
        }

        static void RunBuilder()
        {
            Builder.Start();
        }

        static void RunFactoryMethod()
        {
            FactoryMethod.Start();
        }
    }
}
