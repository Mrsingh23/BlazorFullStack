using System;
using BlazorCrudFullStack.Shared;

namespace BlazorCrudFullStack.Client.Services.SuperHeroService
{
	public interface ISuperHeroService
	{
		List<SuperHero> Heroes { get; set; }
		List<Comic> Comics { get; set; }
        //This is the return type of the method.
		//Task is a type that represents an asynchronous operation,
		//<string> specifies method return a string once the operation complete.
        Task GetComics();
		Task GetSuperHeroes();
		Task<SuperHero?> GetSingleHero(int id);
	}
}

