# Spotify API Project
Easily and regularly get the Spotify URIs (for Track and Album) for the specific subset of content delivered through the second feed. However, THE MOST IMPORTANT THING!!! is getting the 2nd Track and Album URIs.

The Track and Album URIs are only generated once albums have been delivered to Spotify. This means that I’ll either have to strictly target data from the Spotify API, or a combination of our data plus the Spotify API data.


## Features
- View all content/rows that meet criteria for SpotifyNewDeal2 feed or Naxos of America, INC Licensor. It would make the most sense for this to be organized VIA a datatable.
  - In the datatable, the two most necessary columns are the Track URI and Album URI.
  - Other columns would/could be Artist Name, Track Name, Label, etc.
- Each row of content in the datatable would have a "View Details" button, which would direct them to a page with all details/columns for that particular row.
- The datatable would have certain filtering capabilities, allowing the user to search/filter down the results when they're looking for something specific.
- Ability to either batch-add tracks to a playlist the user has created, or have the app automatically add tracks to a playlist, based off of certain criteria.

## Dependencies & NuGet Packages
### NuGet Packages
- Microsoft.AspNetCore.App
- Microsoft.AspNetCore.Razor.Design
- Microsoft.NETCore.App
- Microsoft.VisualStudio.Web.CodeGeneration.Design
- NLog
- SpotifyAPI.Web
- SpotifyAPI.Web.Auth
- System.Configuration.ConfigurationManager
