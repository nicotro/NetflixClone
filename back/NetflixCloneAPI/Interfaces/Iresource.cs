using NetflixCloneAPI.Models;

namespace NetflixCloneAPI.Interfaces
{
    public class Iresource
    {
        public interface IResource
        {
            public bool CreateResource(ResourceDTO newResourceDTO);
            public ResourceDTO GetResourceById(int id);
            public List<ResourceDTO> GetResourcesByCategorie(int categoryId);
            public List<Genre> GetGenresByCategorie(int categorieId);
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
