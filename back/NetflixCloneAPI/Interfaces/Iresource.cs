using NetflixCloneAPI.Models;

namespace NetflixCloneAPI.Interfaces
{
    public class Iresource
    {
        public interface IResource
        {
            public bool CreateResource(ResourceDTO newResourceDTO);
            public ResourceDTO GetResourceById(int id);
            public List<ResourceDTO> GetResourcesByCategory(int categoryId);
            public ResourceDTO GetSingleResourceByCategory(int categoryId, int resourceId);
            public List<Genre> GetGenresByCategory(int categoryId);
            public List<ResourceDTO> GetResourcesByGenre(int categoryId, int genreId);
        }

        public record ResourceDTO
            (
                int Id,
                int Category,
                string Name,
                string Infos,
                string Season,
                List<int> GenresId,
                List<Image> Images,
                List<Video> Videos
            );
    }
}
