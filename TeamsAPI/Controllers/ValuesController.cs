using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        [HttpGet("All")]
        public IActionResult GetTeams()
        {
            // Return all football teams
            return Ok("List of all football teams");
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetTeamById(int id)
        {
            // Return specific team details based on ID
            return Ok($"Football team with id = {id}");
        }

        [HttpPost]
        public IActionResult AddNewTeam([FromBody] object payload)
        {
            // Add a new football team
            return Ok("Football team added");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTeam(int id, [FromBody] object payload)
        {
            // Update details of a specific football team
            return Ok($"Football team with id = {id} updated");
        }

        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteTeam(int id)
        {
            // Delete a specific football team
            return Ok($"Football team with id = {id} deleted");
        }

        [HttpGet("Country/{id}")]
        public IActionResult GetCountry(int id)
        {
            // Return the country where the team plays
            return Ok($"Country of team with id = {id}");
        }

        [HttpGet("Position/{id}")]
        public IActionResult GetPosition(int id)
        {
            // Return the position of the team
            return Ok($"Position of team with id = {id}");
        }

        [HttpGet("GoalsScored/{id}")]
        public IActionResult GetGoalsScored(int id)
        {
            // Return the number of goals scored by the team
            return Ok($"Number of goals scored by team with id = {id}");
        }

        [HttpGet("GoalsConceded/{id}")]
        public IActionResult GetGoalsConceded(int id)
        {
            // Return the number of goals conceded by the team
            return Ok($"Number of goals conceded by team with id = {id}");
        }
    }
}