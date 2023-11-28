using Microsoft.AspNetCore.Mvc;

namespace WebApplicationInitial.ViewComponents
{
    public class AnimalsTypeInteractiveViewComponent: ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            Dictionary<string, string> animalTypes = new Dictionary<string, string>()
            {
                {"Fish", "Fish are super decorative"},
                {"Elephants", "Elephants are big sized mammals with long trumps"}
            };

            return View(animalTypes);
        }
    }
}
