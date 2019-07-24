using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Models;

namespace SpotifyAPIPractice.Services
{
    public class SpotifyClientCredentialsAuthService
    {
        private static string _clientId = "6f953d1ad8f344e6a53ebe3b2d3a2f57";
        private static string _secretId = "073ab4ba78b04dcaac81c758b26d3a74";

        private static AuthorizationCodeAuth auth = null;
        private static SpotifyWebAPI api = null;

        public static void StartCredentialsAuth()
        {
            CredentialsAuth auth = new CredentialsAuth(_clientId, _secretId);
            Token token = auth.GetToken().Result;
            api = new SpotifyWebAPI() { TokenType = token.TokenType, AccessToken = token.AccessToken };
        }

        //public static Object GetCategories

        public static Paging<SimpleTrack> GetAlbumTracks(string albumId = null)
        {
            Paging<SimpleTrack> tracks = api.GetAlbumTracks(albumId);

            return tracks;
        }

        public static object GetAlbums(string albumId = null)
        {
            var albumData = api.GetAlbum(albumId);
            return albumData;
        }

        public static object GetArtist(string artistId = null)
        {
            var artistData = api.GetArtist(artistId); // TODO: Find better variable name than 'tracks'
            return artistData;
        }

        //public static CategoryPlaylist GetPlaylist(string categoryId = null, bool isPopular = false, string country = "BR")
        //{

        //}
    }
}
