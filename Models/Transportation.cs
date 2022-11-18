using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExperienceInWicrecend.Models
{
    public class Transportation
    {
        public string StartingPoint { get; set; }
        public string EndingPoint { get; set; }
        public string Mode { get; set; }
        public string PicturePath { get; set; }
        public string Remarks { get; set; }
    }

    public class TransportationManager
    {
        public static List<Transportation> GetTransportations()
        {
            List<Transportation> transportations = new List<Transportation>();

            transportations.Add(new Transportation { StartingPoint = "大连", EndingPoint = "无锡", Mode = "飞机", PicturePath = "Assets/plane.jpg"
            , Remarks = "这是我第二次来到南方的城市，给我最大的感受是南方的气候与北方的气候相差较大，这里的机会会更多一些。"});

            return transportations;
        }
    }
}
