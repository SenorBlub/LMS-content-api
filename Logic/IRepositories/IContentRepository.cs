using Logic.Models;

namespace Logic.IRepositories;

public interface IContentRepository
{
	public Task CreateContent(Content content);
	public Task DeleteContent(Content content);
	public Task UpdateContent(Content content);
	public Task<Content> GetContent(Guid contentId);
	public Task<Content> GetUserContent(Guid userId);
}