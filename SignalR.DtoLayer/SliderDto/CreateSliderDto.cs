using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.SliderDto
{
    public class CreateSliderDto
    {
        public string SliderTitle { get; set; }
        public string SliderTitle2 { get; set; }
        public string SliderTitle3 { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string ImageUrl { get; set; }
    }
}
