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
        //[HttpGet]
        //public async Task<ActionResult<object>> Get([FromQuery] FilterSpotify filter)
        //{
        //    SpotifyClientCredentialsAuthService.StartCredentialsAuth();

        //    if (filter.SpotifyFilter == EnumSpotify.Albums)
        //    {
        //        var tracks = SpotifyClientCredentialsAuthService.GetAlbums(filter.Id);
        //        return Ok(tracks);
        //    }
        //    else
        //    {
        //        return Ok("Select a filter (Album, Category, or Playlist)");
        //    }
        //}

        // Above Endpoint, but simplified
        [HttpGet]
        public async Task<ActionResult<object>> GetAlbum([FromQuery] SpotifyAlbum album)
        {
            SpotifyClientCredentialsAuthService.StartCredentialsAuth();

            var tracks = SpotifyClientCredentialsAuthService.GetAlbums(album.Id);

            return Ok(tracks);
        }
    }
}