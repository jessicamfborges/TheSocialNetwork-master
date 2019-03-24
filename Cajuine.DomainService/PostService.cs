using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajuine.DomainModel.Entities;
using Cajuine.DomainModel.Interfaces.Repositories;

namespace Cajuine.DomainService
{
    public class PostService
    {
        private IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public void CreatePost(Profile sender, Profile recipient, string content)
        {
            var post = new Post
            {
                Id = Guid.NewGuid(),
                Sender = sender,
                Recipient = recipient,
                Content = content,
                PublishDateTime = DateTime.Now
            };
            _postRepository.Create(post);
        }

        public IEnumerable<Post> GetAllPosts(Profile sender, Profile recipient)
        {
            return _postRepository.ReadAll();
        }
    }
}
