//with relational && logical pattern matching we can make more simpler condition on switch statements as below
using RelationalPatternMatchingPro;

string[] Summaries = new[]{"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"};
Get();

var fullName = "ali ahmad";
if (fullName is not null) 
{
    Console.WriteLine("Hello Isam");
}

List<WeatherForecast> Get()
{
    var rng = new Random();
    var results = Enumerable.Range(1, 5).Select(index => new WeatherForecast
    {
        Date = DateTime.Now.AddDays(index),
        TemperatureC = rng.Next(-20, 55),
        Summary = Summaries[rng.Next(Summaries.Length)]
    })
    .ToList();

   

    //Relational pattern matching is > , < , >= , <=
    //Logical pattern matching is and , or
    foreach (var rec in results)
    {
        rec.Summary = rec.TemperatureF switch
        {
            < 0 => "Well Below Freezing",
            > 10 and < 30 => "Normal",
            > 30 and < 85 => "Hot",
            _ => "Normal"
        };
    }
    return results;
}