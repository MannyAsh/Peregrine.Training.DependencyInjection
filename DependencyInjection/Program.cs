using Autofac;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Injection Example");
            //--------- create a container ---------------
            var containerBuilder = new ContainerBuilder();

            //--------- Register services -----------------
            containerBuilder.RegisterType<Message>().As<IMessage>().SingleInstance();
            containerBuilder.RegisterType<Log>().As<ILog>().SingleInstance();
            containerBuilder.RegisterType<Calculator>().As<ICalculator>().SingleInstance();

            //--------- Build container -------------------
            var container = containerBuilder.Build();
            Console.WriteLine("container has been built");

            //---------- Resolve services ------------------

            var calc = container.Resolve<ICalculator>();

            //------------- Start program ------------------

            int a = 0, b = 0;
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            b = Convert.ToInt32(Console.ReadLine());


            calc.Add(a, b);
            calc.Divide(a, b);

            Console.WriteLine("done");
            Console.ReadLine(); ;

        }
    }
}