using Microsoft.AspNetCore.Http;
using System;

namespace LayoutsMultiplos
{
    public class Tema
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Tema(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string TemaAtual()
        {
            var url = _httpContextAccessor.HttpContext.Request.Host.Value;
            url = url.Replace("www.", "");
            return url;
        }
    }
}
