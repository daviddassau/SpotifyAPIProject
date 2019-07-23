using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Models;

namespace SpotifyAPIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotifyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Get Auth/Access Token from Spotify
        [HttpPost]
        public async Task<IActionResult> GetAuth()
        {
            CredentialsAuth auth = new CredentialsAuth("6f953d1ad8f344e6a53ebe3b2d3a2f57", "073ab4ba78b04dcaac81c758b26d3a74");
            Token token = await auth.GetToken();
            SpotifyWebAPI api = new SpotifyWebAPI() { TokenType = token.TokenType, AccessToken = token.AccessToken };

            return Ok(api);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAlbum()
        //{

        //}
    }
}