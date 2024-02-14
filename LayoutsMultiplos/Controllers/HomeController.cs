
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LayoutsMultiplos
{
    public class Tema
    {
        public static string TemaAtual()
        {
            var url = HttpContext.Current.Request.Url.Host;
            url = url.Replace("www.", "");
            return url;
        }

    }
