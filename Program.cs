
using Entity;
using BZLayer;

MovieBz bz=new MovieBz();
List<Movie> movies=bz.GetMovies();
if(movies!=null)
{
    foreach(var m in movies)
    {
        Console.WriteLine($"{m.Id} {m.name} {m.Ratings} {m.Ryear}");
    }
}
else{
    Console.WriteLine("No Movies Present");
}