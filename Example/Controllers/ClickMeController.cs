using BubblesDivePlanner.Controllers.Interfaces;
using Example.ViewModels.Models;

namespace BubblesDivePlanner.Controllers
{
    public class ClickMeController : IClickMeController
    {
        public string GetSomeText(IClickMeModel clickMeModel)
        {
            return clickMeModel.SomeText;
        }
    }
}