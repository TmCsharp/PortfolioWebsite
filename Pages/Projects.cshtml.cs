using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PortfolioWebsite.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<GitHubProject> Projects { get; set; } = new();

        public void OnGet()
        {
            Projects = new List<GitHubProject>
            {
                new GitHubProject(
                    "Portfolio Website",
                    "This responsive portfolio built with ASP.NET Core and Razor Pages",
                    new List<string> { "C#", "Razor", "CSS", "Html" },
                    "https://github.com/TmCsharp/PortfolioWebsite"
                ),

                new GitHubProject(
                    "Entity Framework Core & MSSQL Database",
                    "A collection of practical exercises implementing Entity Framework Core with MSSQL.",
                    new List<string> { ".NET 8", "EF Core", "MSSQL"},
                    "https://github.com/TmCsharp/DB-MSSQL_EntityFrameworkCore"
                ),

                new GitHubProject(
                    "Advanced & OOP",
                    "A collection of practical exercises implementing Object Oriented Programming.",
                    new List<string> { ".NET 8", "C#", "OOP" },
                    "https://github.com/TmCsharp/Advanced_OOP"
                ),

                  new GitHubProject(
                    "Fundamentals",
                    "A collection of practical exercises covering core programming concepts",
                    new List<string> { ".NET 8", "C#", "Algorithms" },
                    "https://github.com/TmCsharp/Fundamentals"
                ),

                  new GitHubProject(
                    "Hangman Console Game",
                    "A classic word-guessing game built with C#, featuring ASCII art, customizable word lists",
                    new List<string> { ".NET 8", "C#", "ASCII Art" },
                    "https://github.com/TmCsharp/Fundamentals"
                ),

                  new GitHubProject(
                    "Rock/Paper/Scissors Console Game",
                    "A classic hand game implemented in C# with ASCII art visuals and score tracking.",
                    new List<string> { ".NET 8", "C#", "Game Logic" },
                    "https://github.com/TmCsharp/RockPaperScissors"
                ),

                  new GitHubProject(
                    "Guess the Number Game",
                    "Console-based classic guess-the-number challenge in C#.",
                    new List<string> { ".NET 8", "C#", "Game Logic" },
                    "https://github.com/TmCsharp/GuessANumber"
                )
            };
        }
    }

    public record GitHubProject(
        string Title,
        string Description,
        List<string> Technologies,
        string Url
    );
}