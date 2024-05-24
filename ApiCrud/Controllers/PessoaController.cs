using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCrud.Models;
using Newtonsoft.Json;
using ApiCrud.Models.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace ApiCrud.Pessoa
{
    public static class PessoaController
{   
    
    public static void CriaPessoa(this WebApplication app, NobreNavalhaBarbeariaDbContext dbcontext)
    {
        
        app.MapPost("/pessoa", async context =>
        {
            // Verifica se o corpo da requisição está vazio
            if (!context.Request.Body.CanRead || context.Request.ContentLength == 0)
            {
                context.Response.StatusCode = 400; // Código de status "Bad Request"
                await context.Response.WriteAsync("Corpo da requisição vazio.");
                return;
            }

             using (StreamReader reader = new StreamReader(context.Request.Body, Encoding.UTF8))
            {
                string requestBody = await reader.ReadToEndAsync();

                // Converte a string JSON em um objeto Pessoa
                ApiCrud.Models.Pessoa pessoa;
                try
                {
                    pessoa = JsonConvert.DeserializeObject<ApiCrud.Models.Pessoa>(requestBody);
                }
                catch (JsonException)
                {
                    context.Response.StatusCode = 400; // Código de status "Bad Request"
                    await context.Response.WriteAsync("Formato JSON inválido.");
                    return;
                }

                // Verifica se todos os campos obrigatórios estão preenchidos
                if (string.IsNullOrWhiteSpace(pessoa.Nome))
                {
                    context.Response.StatusCode = 400; // Código de status "Bad Request"
                    await context.Response.WriteAsync("O campo 'Nome' é obrigatório.");
                    return;
                }

                // Aqui você pode adicionar mais verificações conforme necessário

                // Criação da pessoa
                try
                {
                    // Aqui você pode adicionar a lógica para salvar a pessoa no banco de dados
                    // Por exemplo:
                    dbcontext.Pessoas.Add(pessoa);
                    await dbcontext.SaveChangesAsync();

                    // Retorna a pessoa criada como resposta
                    context.Response.StatusCode = 201; // Código de status "Created"
                    context.Response.Headers.Add("Content-Type", "application/json");
                    await context.Response.WriteAsync(JsonConvert.SerializeObject(pessoa));
                }
                catch (Exception ex)
                {
                    context.Response.StatusCode = 500; // Código de status "Internal Server Error"
                    await context.Response.WriteAsync($"Erro ao criar a pessoa: {ex.Message}");
                }
            }
        });
    }
}
}