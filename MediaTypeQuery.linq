<Query Kind="Statements">
  <Connection>
    <ID>df7fd5ed-af6b-4a13-bd49-ff02c9a012f4</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in MediaTypes
			  select new
			  {
			    Name = g.Name,
				Tracks = from t in g.Tracks
				         select new
				{
				   TrackName = t.Name,
				   Album = t.Album.Title,
				   GenreId = t.Genre.Name,
				   Artist = t.Album.Artist.Name,
				   ReleaseYear = t.Album.ReleaseYear,
				   ReleaseLabel = t.Album. ReleaseLabel ,
				   }
			};
			results.Dump();