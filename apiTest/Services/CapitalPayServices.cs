using apiTest.Utilities;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace apiTest.Services;

public class CapitalPayServices 
{
    private readonly CapitalPayConfig _capitalPayConfig;
    public string apiUrl;
    HttpClient _httpClient;

    public CapitalPayServices(IOptions<CapitalPayConfig> capitalPayConfig)
    {
        _capitalPayConfig = capitalPayConfig.Value;
        apiUrl = _capitalPayConfig.BaseUrl;
        CreateHttpClient(apiUrl);
    }

    private HttpClient CreateHttpClient(string baseUrl)
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri(baseUrl);
        return _httpClient;
    }

    public async Task<TResponse> PostAsync<TResponse, TRequest>(string urlSuffix, TRequest request, bool isAuth = true,string token="") where TResponse : class
    {

        if (isAuth)
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", token);
        }


        var responseMessage = await _httpClient.PostAsJsonAsync(urlSuffix, request);
        if (!responseMessage.IsSuccessStatusCode)
            return null;

        responseMessage.EnsureSuccessStatusCode();
        var responseBody = await responseMessage.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<TResponse>(responseBody);
        return result;
    }



}
