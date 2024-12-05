using Logic.IRepositories;
using Logic.Models;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class ContentRepository : IContentRepository
	{
		private readonly IMongoCollection<Content> _contentCollection;

		public ContentRepository(IMongoDatabase database)
		{
			_contentCollection = database.GetCollection<Content>("testCollection");
		}

		public async Task CreateContent(Content content)
		{
			if (content == null) throw new ArgumentNullException(nameof(content));
			await _contentCollection.InsertOneAsync(content);
		}

		public async Task DeleteContent(Content content)
		{
			if (content == null) throw new ArgumentNullException(nameof(content));
			var filter = Builders<Content>.Filter.Eq(c => c.Id, content.Id);
			await _contentCollection.DeleteOneAsync(filter);
		}

		public async Task UpdateContent(Content content)
		{
			if (content == null) throw new ArgumentNullException(nameof(content));
			var filter = Builders<Content>.Filter.Eq(c => c.Id, content.Id);
			await _contentCollection.ReplaceOneAsync(filter, content);
		}

		public async Task<Content> GetContent(Guid contentId)
		{
			var filter = Builders<Content>.Filter.Eq(c => c.Id, contentId);
			return await _contentCollection.Find(filter).FirstOrDefaultAsync();
		}

		public async Task<Content> GetUserContent(Guid userId)
		{
			var filter = Builders<Content>.Filter.Eq(c => c.UserId, userId);
			return await _contentCollection.Find(filter).FirstOrDefaultAsync();
		}
	}
}