using System;
using Microsoft.AspNetCore.Components;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            singleton.Value += 1;
            transient.Value += 1;
        }
    }
}
