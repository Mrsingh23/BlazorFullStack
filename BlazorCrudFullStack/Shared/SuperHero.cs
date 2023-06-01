using System;

namespace BlazorCrudFullStack.Shared
{
	public class SuperHero
	{

		public int Id { get; set; }
		public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string HeroName { get; set; } = string.Empty;
		public Comic?Comic;
		public int ComicId { get; set; }

        public static implicit operator List<object>(SuperHero v)
        {
            throw new NotImplementedException();
        }
    }
}

