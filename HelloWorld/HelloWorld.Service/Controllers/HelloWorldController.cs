using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        private static readonly string[] Greetings = new[]
        {
            "Hello world!", "Hello everybody!", "Hello everyone!", "Good morning!", "Good evening!", "Good night!", "Welcome!"
        };

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet(nameof(SayHello))]
        public IEnumerable<HelloWorldModel> SayHello()
        {
            return Enumerable.Range(1, 3).Select(i => new HelloWorldModel
            {
                Id = i,
                Text = Greetings[Random.Shared.Next(0, Greetings.Length -1)],
                Created = DateTime.Now.AddDays(i),
            })
                .ToArray();
        }

    }

    public class HelloWorldModel
    {
        public int Id { get; set; }
        public string Text { get; set; } = null!;
        public DateTime Created { get; set; } 
    }
}
