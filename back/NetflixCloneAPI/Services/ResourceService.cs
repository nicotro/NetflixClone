using NetflixCloneAPI.Interfaces;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.Repositories;
using static NetflixCloneAPI.Interfaces.Iresource;

namespace NetflixCloneAPI.Services
{
    public class ResourceService : IResource
    {
        private BaseRepository<Resource> _resourceRepository;
        private BaseRepository<Image> _imageRepository;
        private BaseRepository<Video> _videoRepository;
        private BaseRepository<Genre_resource> _genreResourceRepository;

        public ResourceService(BaseRepository<Resource> resourceRepository, BaseRepository<Genre_resource> genreResourceRepository, BaseRepository<Image> imageRepository, BaseRepository<Video> videoRepository)
        {
            _resourceRepository = resourceRepository;
            _genreResourceRepository = genreResourceRepository;
            _imageRepository = imageRepository;
            _videoRepository = videoRepository;
        }

        public bool CreateResource(ResourceDTO newResourceDTO)
        {
            Resource newResource = new Resource()
            {
                Name = newResourceDTO.Name,
                Infos = newResourceDTO.Infos,
                Season = newResourceDTO.Season,
                Category = newResourceDTO.Category
            };

            if (_resourceRepository.Add(newResource))
            {
                Genre_resource gr = new Genre_resource();
                foreach (int g in newResourceDTO.GenresId)
                {
                    gr.Id = 0;
                    gr.ResourceId = newResource.Id;
                    gr.GenreId = g;
                    _genreResourceRepository.Add(gr);
                }
                foreach (Image i in newResourceDTO.Images)
                {
                    _imageRepository.Add(i);
                }
                foreach (Video v in newResourceDTO.Videos)
                {
                    _videoRepository.Add(v);
                }
                return true;
            }

            //throw new NotImplementedException();
            return false;
        }

        public ResourceDTO GetResourceById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ResourceDTO> GetResourcesByCategorie(int categoryId)
        {
            List<ResourceDTO> resourcesDTO = new List<ResourceDTO>();
            List<Resource> resources = _resourceRepository.FindAll(r => r.Category == categoryId);
            foreach (Resource resource in resources)
            {
                List<Genre_resource> genre_Resources = _genreResourceRepository.FindAll(gr => gr.ResourceId == resource.Id);
                List<int> genres = new List<int>();
                foreach (Genre_resource gr in genre_Resources)
                {
                    genres.Add(gr.GenreId);
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
                        _imageRepository.FindAll(i => i.ResourceId == resource.Id),
                        _videoRepository.FindAll(v => v.ResourceId == resource.Id)
                    );
                resourcesDTO.Add(resourceDtoTmp);
            }
            return resourcesDTO;
        }


        public List<int> GetGenresByCategorie(int categorieId)
        {


            List<Genre_resource> genre_Resources = _genreResourceRepository.FindAll(gr => gr.ResourceId == categorieId); // n'importe quoi !

            throw new NotImplementedException();
        }


        public List<ResourceDTO> GetResourcesByGenre(int categoryId, int genreId)
        {
            throw new NotImplementedException();
        }
    }
}
