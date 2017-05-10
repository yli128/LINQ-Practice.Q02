<Query Kind="Statements">
  <Connection>
    <ID>6b79e206-c5b4-4c82-ade0-6e76aac04abe</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from x in Artists
            where x.ArtistId==1
            orderby x.Name
			select new
			{
			Artist = x.Name,
			Albums = from t in x.Albums
			orderby t.Title
			select new
				{
			      Title = t.Title,
				  Tracks = from tr in t.Tracks
				           select new
					{
					TrackName = tr.Name,
					GenreId = tr.GenreId,
					Composer = tr.Composer,
					Milliseconds = tr.Milliseconds
					}
			    }
			};
results.Dump();