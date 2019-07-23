using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Models;
using SpotifyAPIPractice.Services;

namespace SpotifyAPIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotifyController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAlbum(string albumId)
        {
            CredentialsAuth auth = new CredentialsAuth("6f953d1ad8f344e6a53ebe3b2d3a2f57", "073ab4ba78b04dcaac81c758b26d3a74");
            Token token = await auth.GetToken();
            SpotifyWebAPI api = new SpotifyWebAPI() { TokenType = token.TokenType, AccessToken = token.AccessToken };

            FullAlbum album = api.GetAlbum(albumId);

            if (album == null)
            {
                //return NotFound($"No Album found with id of {id}");
                return NotFound($"No Album found");
            }

            return Ok(album);
        }

        // Get Auth/Access Token from Spotify
        [HttpPost]
        public async Task<IActionResult> GetAuth()
        {
            CredentialsAuth auth = new CredentialsAuth("6f953d1ad8f344e6a53ebe3b2d3a2f57", "073ab4ba78b04dcaac81c758b26d3a74");
            Token token = await auth.GetToken();
            SpotifyWebAPI api = new SpotifyWebAPI() { TokenType = token.TokenType, AccessToken = token.AccessToken };

            FullAlbum album = api.GetAlbum("2KhkdN53S255mwgjrHUhho");

            if (album == null)
            {
                //return NotFound($"No Album found with id of {id}");
                return NotFound($"No Album found");
            }

            return Ok(album);
        }

        //private static SpotifyWebAPI _spotify;

        //private AuthorizationService _authorizationService;

        //public SpotifyController()
        //{
        //    _authorizationService = new AuthorizationService();

        //    _spotify = _authorizationService.Authorize(_spotify);
        //}

        //[HttpGet]
        //public async Task<IActionResult> GetAlbum(string albumId)
        //{
        //    FullAlbum album = _spotify.GetAlbum(albumId);

        //    if (album == null)
        //    {
        //        return NotFound("No album found");
        //    }

        //    return Ok(album);
        //    //return _spotify.GetAlbum();
        //}
    }
}