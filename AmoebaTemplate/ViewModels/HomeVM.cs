using AmoebaTemplate.Models;

namespace AmoebaTemplate.ViewModels
{
    public class HomeVM
    {
        public List<CustomService> CustomServices { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
    }
}
