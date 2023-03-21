using System.Text;
using System.Net.Http.Headers;

var endpoint = "https://api.openai.com/v1/completions";

var data = "{\"model\": \"text-davinci-003\", \"prompt\": \"What is the language for the following text? Hola crayola!\", \"temperature\": 0.3, \"max_tokens\": 100, \"top_p\": 1, \"frequency_penalty\": 0, \"presence_penalty\": 0, \"logprobs\": 5 }";
var content = new StringContent(data, Encoding.UTF8, "application/json");

var client = new HttpClient();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "---");

var response = await client.PostAsync(endpoint, content);

if (response.IsSuccessStatusCode)
{
	var result = await response.Content.ReadAsStringAsync();
	Console.WriteLine(result);
}

