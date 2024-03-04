using API_WEB_CORE.Data;
using API_WEB_CORE.Models.Domain;
using API_WEB_CORE.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API_WEB_CORE.Controllers
{
    //api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly WebApiContext dbContext;
        public RegionsController(WebApiContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //GET ALL REGIONS
        //GET: api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            //Get data from database - domain models
            var regionsDomain = dbContext.Regions.ToList();
            //map domain models to DTOs
            var regionsDTO = new List<RegionDTO>();
            foreach (var region in regionsDomain)
            {
                regionsDTO.Add(new RegionDTO()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    RegionImageUrl = region.RegionImageUrl
                }
                );

            }
            //return DTOs
            return Ok(regionsDTO);
        }

        //GET SINGLE REGIN (GET REGION BY ID)
        //GET api/regions/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetbyId([FromRoute] Guid id)
        {
            //var region = dbContext.Regions.Find(id);
            //get region domain model from database
            var regionsDomain = dbContext.Regions.FirstOrDefault(x => x.Id == id);
            if (regionsDomain == null)
            {
                return NotFound();
            }
            //Map/convert region domain model to region dto
            var regionsDTO = new RegionDTO
            {
                Id = regionsDomain.Id,
                Code = regionsDomain.Code,
                Name = regionsDomain.Name,
                RegionImageUrl = regionsDomain.RegionImageUrl
            };
            //return dto back to client
            return Ok(regionsDTO);
        }

        //POST to Create new region
        //api/regions
        [HttpPost]
        public IActionResult Create([FromBody] AddRegionRequestDTO addRegionRequestDTO)
        {
            //map or convert dto to domain model

            var regionDomainModel = new Region
            {
                Code = addRegionRequestDTO.Code,
                Name = addRegionRequestDTO.Name,
                RegionImageUrl = addRegionRequestDTO.RegionImageUrl
            };
            //use domain model to create region
            dbContext.Regions.Add(regionDomainModel);
            dbContext.SaveChanges();

            //map domain model back to dto
            var regionDto = new RegionDTO
            {
                Id = regionDomainModel.Id,
                Code = regionDomainModel.Code,
                Name = regionDomainModel.Name,
                RegionImageUrl = regionDomainModel.RegionImageUrl
            };
            return CreatedAtAction(nameof(GetbyId), new { id = regionDomainModel.Id }, regionDto);
            //return Ok();
        }
    }
}
