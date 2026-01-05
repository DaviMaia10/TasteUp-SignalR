using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CustomerSeatDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerSeatsController : ControllerBase
    {
        private readonly ICustomerSeatService _customerSeatService;
        private readonly IMapper _mapper;

        public CustomerSeatsController(ICustomerSeatService customerSeatService, IMapper mapper)
        {
            _customerSeatService = customerSeatService;
            _mapper = mapper;
        }

        [HttpGet("CustomerSeatCount")]
        public IActionResult CustomerSeatCount()
        {
            return Ok(_customerSeatService.TCustomerSeatCount());
        }


        [HttpGet]
        public IActionResult CustomerSeatList()
        {
            var values = _customerSeatService.TGetListAll();
            return Ok(_mapper.Map<List<ResultCustomerSeatDto>>(values));
        }

        [HttpPost]
        public IActionResult CreateCustomerSeat(CreateCustomerSeatDto createCustomerSeatDto)
        {
            createCustomerSeatDto.Status = false;
            var value = _mapper.Map<CustomerSeat>(createCustomerSeatDto);
            _customerSeatService.TAdd(value);
            return Ok("Masa Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomerSeat(int id)
        {
            var value = _customerSeatService.TGetByID(id);
            _customerSeatService.TDelete(value);
            return Ok("Masa Başarılı Bir Şekilde Silindi");
        }

        [HttpPut]
        public IActionResult UpdateCustomerSeat(UpdateCustomerSeatDto updateCustomerSeatDto)
        {
            var value = _mapper.Map<CustomerSeat>(updateCustomerSeatDto);
            _customerSeatService.TUpdate(value);
            return Ok("Masa Bilgisi Başarılı Şekilde Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomerSeat(int id)
        {
            var value = _customerSeatService.TGetByID(id);
            var result = _mapper.Map<GetCustomerSeatDto>(value);
            return Ok(result);
        }

        [HttpGet("ChangeCustomerSeatStatusToTrue")]
        public IActionResult ChangeCustomerSeatStatusToTrue(int id)
        {
            _customerSeatService.TChangeCustomerSeatStatusToTrue(id);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("ChangeCustomerSeatStatusToFalse")]
        public IActionResult ChangeCustomerSeatStatusToFalse(int id)
        {
            _customerSeatService.TChangeCustomerSeatStatusToFalse(id);
            return Ok("İşlem Başarılı");
        }
    }
}
