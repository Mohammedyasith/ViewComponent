namespace Intelizign.Net.ViewComponents.NavBarViewComponent;
public class NavBarItemModel
{
    public NavBarItemModel(string currentUserRoleName, List<ButtonModel> navBarItems){
        CurrentUserRoleName = currentUserRoleName;
        NavBarItems = navBarItems;
    }
    public string CurrentUserRoleName {get;init;}
    public List<ButtonModel> NavBarItems {get;init;}
}
