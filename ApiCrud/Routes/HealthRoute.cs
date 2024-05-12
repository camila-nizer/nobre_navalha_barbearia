using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Routes
{
    public static class HealthRoute{
        public static void Health(this WebApplication app){
            app.MapGet("health", () => "Everything sounds good...");
        }
    }
}