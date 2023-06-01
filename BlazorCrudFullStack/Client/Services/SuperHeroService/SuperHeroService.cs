using System;
using System.Net.Http.Json;
using BlazorCrudFullStack.Shared;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;

namespace BlazorCrudFullStack.Client.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly HttpClient _http;

        public SuperHeroService(HttpClient http)
        {
            _http = http;
            
        }
        public List<SuperHero> Heroes { get; set; } = new List<SuperHero>();
        public List<Comic> Comics { get; set; } = new List<Comic>();
 
        public Task GetComics()
        {
            throw new NotImplementedException();
        }

        public async Task<SuperHero?> GetSingleHero(int id)
        {
            var result = await _http.GetFromJsonAsync<SuperHero>("api/{id}");
            if ( result != null)
             return result;
           return null;
        }

        public async Task GetSuperHeroes()
        {
            
            var result = await _http.GetFromJsonAsync<List<SuperHero>>("api/superhero"); //GET - format JSON
            if (result != null)
                Heroes = result;
        }
    }


}

