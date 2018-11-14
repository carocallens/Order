using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Order.API.Controllers.Items.Interfaces;
using Order.Domain.Items;
using Order.Services.ItemServices.Interfaces;

namespace Order.API.Controllers.Items
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;
        private readonly IItemMapper _itemMapper;

        public ItemsController(IItemService itemService, IItemMapper itemMapper)
        {
            _itemService = itemService;
            _itemMapper = itemMapper;
        }

        //[Authorize(Policy = "RequireAdministratorRole")]
        [HttpGet]
        public ActionResult<List<ItemResponseDTO>> GetAll()
        {
            return Ok(_itemMapper.ItemListToItemDTOList(_itemService.GetAll()));
        }

        //[Authorize(Policy = "RequireAdministratorRole")]
        [HttpPost]
        public ActionResult CreateItem([FromBody]ItemRequestDTO itemDTO)
        {
            _itemService.CreateItem(_itemMapper.ItemDTOToItem(itemDTO));

            return Ok();
        }
    }
}