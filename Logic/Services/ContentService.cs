using Logic.IServices;
using Logic.IRepositories;
using Logic.Models;
using System;
using System.Threading.Tasks;

namespace Logic.Services
{
	public class ContentService : IContentService
	{
		private readonly IContentRepository _contentRepository;

		public ContentService(IContentRepository contentRepository)
		{
			_contentRepository = contentRepository ?? throw new ArgumentNullException(nameof(contentRepository));
		}

		public async Task CreateContent(Content content)
		{
			if (content == null) throw new ArgumentNullException(nameof(content));
			await _contentRepository.CreateContent(content);
		}

		public async Task DeleteContent(Content content)
		{
			if (content == null) throw new ArgumentNullException(nameof(content));
			await _contentRepository.DeleteContent(content);
		}

		public async Task UpdateContent(Content content)
		{
			if (content == null) throw new ArgumentNullException(nameof(content));
			await _contentRepository.UpdateContent(content);
		}

		public async Task<Content> GetContent(Guid contentId)
		{
			if (contentId == Guid.Empty) throw new ArgumentException("Content ID cannot be empty.", nameof(contentId));
			return await _contentRepository.GetContent(contentId);
		}

		public async Task<Content> GetUserContent(Guid userId)
		{
			if (userId == Guid.Empty) throw new ArgumentException("User ID cannot be empty.", nameof(userId));
			return await _contentRepository.GetUserContent(userId);
		}
	}
}