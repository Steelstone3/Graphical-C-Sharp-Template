using Example.ViewModels.Models;

namespace BubblesDivePlanner.Controllers.Interfaces
{
    public interface IClickMeController
    {
        string GetSomeText(IClickMeModel clickMeModel);
    }
}