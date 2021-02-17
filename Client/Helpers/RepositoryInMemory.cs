using System;
using System.Collections.Generic;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){Title = "Spider-Man: Far From Home", ReleaseDate = new DateTime(2020, 1, 2)},
                new Movie(){Title = "Moana", ReleaseDate = new DateTime(2016, 3, 9)},
                new Movie(){Title = "Inception", ReleaseDate = new DateTime(2010, 7, 16)},
            };
        }
    }
}
