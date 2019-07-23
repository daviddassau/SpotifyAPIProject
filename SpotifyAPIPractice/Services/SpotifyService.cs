using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;

namespace SpotifyAPIPractice.Services
{
    public class SpotifyService
    {
        private static SpotifyWebAPI _spotify;

        private AuthorizationService _authorizationService;

        public SpotifyService()
        {
            _authorizationService = new AuthorizationService();

            _spotify = _authorizationService.Authorize(_spotify);
        }

        public FullTrack GetTrack(string trackId)
        {
            return _spotify.GetTrack(trackId);
        }

        public FullAlbum GetAlbum(string albumId)
        {
            return _spotify.GetAlbum(albumId);
        }

        public List<SimplePlaylist> GetAllPlaylists(string userId)
        {
            var playlists = new List<SimplePlaylist>();

            var playlistPage = _spotify.GetUserPlaylists(userId);

            playlists.AddRange(playlistPage.Items);

            while (playlistPage.HasNextPage())
            {
                playlistPage = _spotify.GetNextPage(playlistPage);
                playlists.AddRange(playlistPage.Items);
            }

            return playlists;
        }

        // TODO
        //public FullPlaylist GetPlaylist(string userId, string playlistId)
        //{
        //    return _spotify.GetPlaylist(userId, playlistId);
        //}


    }
}
