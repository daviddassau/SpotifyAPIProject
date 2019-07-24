using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Models;
using SpotifyAPIPractice.Dto;
using SpotifyAPIPractice.Services;

namespace SpotifyAPIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotifyTestController : ControllerBase
    {
        [HttpGet("album")]
        public async Task<ActionResult<object>> GetAlbum([FromQuery] SpotifyAlbum album)
        {
            SpotifyClientCredentialsAuthService.StartCredentialsAuth();

            var albumData = SpotifyClientCredentialsAuthService.GetAlbums(album.Id);

            return Ok(albumData);
        }

        [HttpGet("artist")]
        public async Task<ActionResult<object>> GetArtist([FromQuery] SpotifyArtist artist)
        {
            SpotifyClientCredentialsAuthService.StartCredentialsAuth();

            var artistData = SpotifyClientCredentialsAuthService.GetArtist(artist.Id);

            return Ok(artistData);
        }
    }
}