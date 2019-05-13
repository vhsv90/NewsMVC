using ModusCreate.Models.DB;
using ModusCreate.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace ModusCreate.Models.Manager
{
    public class NewsManager : IDataRepository<News>
    {
        public readonly NewsContext _newsContext;

        public NewsManager(NewsContext newsContext)
        {
            _newsContext = newsContext;
        }

        public void Add(News entity)
        {
            _newsContext.News.Add(entity);
            _newsContext.SaveChanges();
        }

        public void Delete(News entity)
        {
            _newsContext.News.Remove(entity);
            _newsContext.SaveChanges();
        }

        public News Get(long id)
        {
            return _newsContext.News.FirstOrDefault(x => x.NewsId == id);
        }

        public IEnumerable<News> GetAll()
        {
            return _newsContext.News.ToList();
        }

        public IEnumerable<News> GetAllByCategory(string category)
        {
            return _newsContext.News.Where(x => x.Category.Equals(category)).ToList();
        }

        public IEnumerable<News> Search(string searchTerm)
        {
            var result = _newsContext
                .News
                .Where(x => x.Title.Contains(searchTerm) || x.Description.Contains(searchTerm))
                .ToList()
                ;

            return result;
        }

        public void Update(News dbEntity, News entity)
        {
            dbEntity.Category = entity.Category;
            dbEntity.Date = entity.Date;
            dbEntity.Description = entity.Description;
            dbEntity.Title = entity.Title;

            _newsContext.SaveChanges();
        }
    }
}
