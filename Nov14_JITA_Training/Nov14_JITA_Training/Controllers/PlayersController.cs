using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nov14_JITA_Training.Models;

namespace Nov14_JITA_Training.Controllers
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {

        // GET api/values
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            var players = new List<Player>
            {
                new Player
                {
                    Id = 1,
                    Name = "Sam",
                    Position = "QB",
                    Number = 4,
                },
                new Player()
            };

            return players;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Player Get(int id)
        {
            return new Player();
        }

    
    }
}
