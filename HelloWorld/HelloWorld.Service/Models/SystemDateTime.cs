namespace HelloWorld.Service.Models
{
    public class SystemDateTime : IDateTime
    {
        public DateTime Now 
            { 
                get { return DateTime.Now; } 
            }
    }
}
