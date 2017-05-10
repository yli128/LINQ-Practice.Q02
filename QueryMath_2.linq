<Query Kind="Statements">
  <Connection>
    <ID>df7fd5ed-af6b-4a13-bd49-ff02c9a012f4</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in MediaType
              where g.Name.Equals("Heavy Metal")
			  select new
			  {
			    TracksCount = g.Tracks.Count(),
				TrackId = from t in g.Tracks
				         select new
				{
				   TrackName = t.Name,
				   AlbumName = t.Album.Title,
				   Milliseconds = t. Milliseconds,
				   Size = (t.Bytes / 1000)+" kb",
				   Price = t.UnitPrice
				   }
			};
			results.Dump("More Math");