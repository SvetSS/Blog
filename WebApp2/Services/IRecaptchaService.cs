using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using WebApp2.Models;

namespace WebApp2.Services
{
    public interface IRecaptchaService
    {
        Task<RecaptchaResponse> Validate(IFormCollection form);
    }
}
