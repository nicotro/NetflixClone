using NetflixCloneAPI.Interfaces;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.Repositories;

namespace NetflixCloneAPI.Services
{
    public class ResourceService : Iresource
    {
        private BaseRepository<Resource> _resourceRepository;
        private BaseRepository<Image> _imageRepository;
        private BaseRepository<Video> _videoRepository;
        private BaseRepository<Genre> _genreRepository;
        private BaseRepository<Genre_resource> _genreResourceRepository;

        public ResourceService(BaseRepository<Resource> resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }

        public bool CreateResource(ResourceDTO newResourceDTO)
        {
            throw new NotImplementedException();
        }

        public ResourceDTO GetResourceById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ResourceDTO> GetResourcesByCategorie(Category category)
        {
            List<ResourceDTO> resourcesDTO = new List<ResourceDTO>();
            List<Resource> resources = _resourceRepository.FindAll(r => r.Category == category.Id);
            foreach (Resource resource in resources)
            {
                List<Genre_resource> genre_Resources = _genreResourceRepository.FindAll(gr => gr.ResourceId == resource.Id);
                List<Genre> genres = new List<Genre>();
                foreach (Genre_resource gr in genre_Resources)
                {
                    genres.Add(_genreRepository.Find(g => g.Id == gr.GenreId));
                }

                ResourceDTO resourceDtoTmp = new ResourceDTO
                    (
                        resource.Id,
                        resource.Category,
                        resource.Name,
                        resource.Infos,
                        resource.Season,
                        // tmp
                        genres,
                        _imageRepository.FindAll(i=>i.ResourceId==resource.Id),
                        _videoRepository.FindAll(v=>v.ResourceId==resource.Id)
                    );
                resourcesDTO.Add(resourceDtoTmp);
            }
            throw new NotImplementedException();
        }

        public List<ResourceDTO> GetResourcesByGenre(Category category, Genre genre)
        {
            throw new NotImplementedException();
        }
    }
}
