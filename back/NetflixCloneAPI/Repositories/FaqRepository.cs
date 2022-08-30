using NetflixCloneAPI.Models;
using NetflixCloneAPI.Services;

namespace NetflixCloneAPI.Repositories
{
    public class FaqRepository : BaseRepository<Faq>
    {
        public FaqRepository(DataContextService dataContextService) : base(dataContextService)
        {
        }

        public override bool Add(Faq entity)
        {
            _dataContextService.Faqs.Add(entity);
            return Update() && entity.Id > 0;
        }

        public override bool Delete(Faq entity)
        {
            throw new NotImplementedException();
        }

        public override Faq Find(Func<Faq, bool> predicate)
        {
            return _dataContextService.Faqs.ToList().FirstOrDefault(c => predicate(c));
        }

        public override List<Faq> FindAll(Func<Faq, bool> predicate)
        {
            return _dataContextService.Faqs.ToList().Where(f => predicate(f)).ToList();
        }

        public override List<Faq> FindByCategory(int category)
        {
            throw new NotImplementedException();
        }
    }
}
