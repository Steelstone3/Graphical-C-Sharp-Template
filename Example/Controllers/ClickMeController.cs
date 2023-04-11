using BubblesDivePlanner.Controllers.Interfaces;

namespace BubblesDivePlanner.Controllers
{
    public class ClickMeController : IClickMeController
    {
        public string GetSomeText()
        {
            return "Some Text";
        }
    }
}