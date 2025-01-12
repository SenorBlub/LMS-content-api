using Logic.IServices;
using Logic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS_content_api.Controllers
{
	[Route("content/[controller]")]
	[ApiController]
	public class ContentController : ControllerBase
	{
		private readonly IContentService _contentService;

		public ContentController(IContentService contentService)
		{
			_contentService = contentService ?? throw new ArgumentNullException(nameof(contentService));
		}

		[HttpPost]
		public async Task<IActionResult> CreateContent([FromBody] Content content)
		{
			if (content == null)
				return BadRequest("Content cannot be null.");

			await _contentService.CreateContent(content);
			return CreatedAtAction(nameof(GetContent), new { contentId = content.Id }, content);
		}

		[HttpGet]
		public async Task<IActionResult> GetContent(Guid contentId)
		{
			if (contentId == Guid.Empty)
				return BadRequest("Content ID cannot be empty.");

			var content = await _contentService.GetContent(contentId);

			if (content == null)
				return NotFound();

			return Ok(content);
		}

		[HttpGet("user/{userId:guid}")]
		public async Task<IActionResult> GetUserContent([FromRoute] Guid userId)
		{
			if (userId == Guid.Empty)
				return BadRequest("User ID cannot be empty.");

			var content = await _contentService.GetUserContent(userId);

			if (content == null)
				return NotFound();

			return Ok(content);
		}

		[HttpPut("{contentId:guid}")]
		public async Task<IActionResult> UpdateContent([FromRoute] Guid contentId, [FromBody] Content updatedContent)
		{
			if (updatedContent == null || contentId == Guid.Empty || updatedContent.Id != contentId)
				return BadRequest("Invalid content data or mismatched ID.");

			await _contentService.UpdateContent(updatedContent);
			return NoContent();
		}

		[HttpDelete("{contentId:guid}")]
		public async Task<IActionResult> DeleteContent([FromRoute] Guid contentId)
		{
			if (contentId == Guid.Empty)
				return BadRequest("Content ID cannot be empty.");

			var content = await _contentService.GetContent(contentId);
			if (content == null)
				return NotFound();

			await _contentService.DeleteContent(content);
			return NoContent();
		}
	}
}
