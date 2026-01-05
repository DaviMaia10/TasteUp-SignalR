using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;

        public MessageController(IMessageService messageService, IMapper mapper)
        {
            _messageService = messageService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _messageService.TGetListAll();
            var result = _mapper.Map<List<ResultMessageDto>>(values);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            createMessageDto.MessageStatus = false;
            createMessageDto.MessageSendDate = DateTime.Now;
            var message = _mapper.Map<Message>(createMessageDto);
            _messageService.TAdd(message);
            return Ok("Mesaj Başarılı Bir Şekilde Gönderildi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            _messageService.TDelete(value);
            return Ok("Mesaj Başarılı Bir Şekilde Silindi");
        }

        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            updateMessageDto.MessageStatus = false;
            var message = _mapper.Map<Message>(updateMessageDto);
            _messageService.TUpdate(message);
            return Ok("Mesaj Başarılı Bir Şekilde Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var value = _messageService.TGetByID(id);
            var result = _mapper.Map<GetMessageDto>(value);
            return Ok(result);
        }
    }
}
