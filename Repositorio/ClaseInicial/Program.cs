using ClaseInicial.Logic;

try
{
    var dato1 = new Date();
    var dato2 = new Date()
    {
        Year = 2025,
        Month = 2,
        Day = 19
    };
    var dato3 = new Date(year: 2019, month: 11, day:10); 

    Console.WriteLine($"Primer fecha: {dato1}");
    Console.WriteLine($"Segunda fecha: {dato2}");
    Console.WriteLine($"Tercer fecha: {dato3}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
