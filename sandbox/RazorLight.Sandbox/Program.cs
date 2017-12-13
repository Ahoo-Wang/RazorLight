using System;
using System.Threading.Tasks;
using System.Dynamic;

namespace RazorLight.Sandbox
{
    class Program
    {
        static void Main()
        {
            MainAsync().GetAwaiter().GetResult();
        }

        private static async Task MainAsync()
        {
            var engine = new EngineFactory().ForEmbeddedResources(typeof(Program));
          
            var model = new
            {
                Name1 = "qwe"
            };
            dynamic viewBag = new ExpandoObject();
            viewBag.Ahoo = "Great Man!";
            string s = await engine.CompileRenderAsync("go", model, model.GetType(), viewBag);

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
