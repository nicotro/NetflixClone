using NetflixCloneAPI.Models;

namespace NetflixCloneAPI.Interfaces
{
    public interface Iresource
    {
        public bool CreateResource(ResourceDTO newResourceDTO);
        public ResourceDTO GetResourceById(int id);
        public List<ResourceDTO> GetResourcesByCategorie(Category category);
        public List<ResourceDTO> GetResourcesByGenre(Category category, Genre genre);
    }

    public record ResourceDTO
        (
            int Id,
            int Category,
            string Name,
            string Infos,
            string Season,
            List<Genre> Genres,
            List<Image> Images,
            List<Video> Videos
        );
}
