using System.Net.Http.Json;

public class MyTodoApiClientConsole
{
    class MyRequest
    {
        public int Alter { get; set; }
        public double Einkommen { get; set; }
    }
    public static  void Main()
    {
        Console.WriteLine("Bitte drücken Sie eine Taste");
        Console.ReadLine();
        Console.WriteLine("Hello Campus02");

        MyRequest request = new MyRequest();
        request.Alter = 12;
        request.Einkommen = 200;
       double ergebnis=  PostKlimabonus(request).Result;

    }
    static HttpClient client = new HttpClient();
    static async Task<double> PostKlimabonus(MyRequest request)
    {
       
        HttpResponseMessage response = await client.PostAsJsonAsync(
            "https://localhost:7021/api/Klimabonsu", request);
        response.EnsureSuccessStatusCode();

        // return URI of the created resource.
        var content=  response.Content;
        return 120;
       
    }
}