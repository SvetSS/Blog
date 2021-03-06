using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WebApp2.Models;
using WebApp2.Options;

namespace WebApp2.Services
{
    public class GoogleRecaptchaService : IRecaptchaService
    {
        private readonly ReCaptchaOptions _options;
        private readonly HttpClient _httpClient;

        public GoogleRecaptchaService(IOptions<AppOptions> optionsAccessor)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://www.google.com");

            _options = optionsAccessor.Value.ReCaptcha;
        }

        public async Task<RecaptchaResponse> Validate(IFormCollection form)
        {
            var gRecaptchaResponse = form["g-recaptcha-response"];
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("secret", _options.SecretKey),
                new KeyValuePair<string, string>("response", gRecaptchaResponse)
            });

            var response = await _httpClient.PostAsync("/recaptcha/api/siteverify", content);
            var resultContent = await response.Content.ReadAsStringAsync();
            var captchaResponse = JsonConvert.DeserializeObject<RecaptchaResponse>(resultContent);

            return captchaResponse;
        }
    
    }
}
