<Query Kind="Statements">
  <Connection>
    <ID>df7fd5ed-af6b-4a13-bd49-ff02c9a012f4</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              orderby g.Name
			  select new
			   {
			     Genre = g.Name,
				 TracksCount = g.Tracks.Count()
			   };
results.Dump("Query Math");