using Microsoft.AspNetCore.Mvc;

namespace Intelizign.Net.ViewComponents.NavBarViewComponent;
[ViewComponent(Name = "vLib.NavBar")]
public class NavBarViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(NavBarItemModel Properties)
    {
        foreach (var button in Properties.NavBarItems)
        {
            if (button.Roles.Contains(Properties.CurrentUserRoleName))
            {
                button.ShowNav = true;
            }
        }
        return View("Default", Properties);
    }
}