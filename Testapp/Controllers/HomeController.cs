using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using navcomp.Models;
using  Intelizign.Net.ViewComponents.NavBarViewComponent;

namespace navcomp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public List<ButtonModel> ButtonList()
    {
        ButtonModel btn1 = new ButtonModel();
        btn1.DisplayText = "Main";
        btn1.Name = "Main";
        btn1.Roles = new List<string>(){"Admin","User","Initiator"};
        btn1.Url = "/ChangeManagement/Main";
        
        ButtonModel btn4 = new ButtonModel();
        btn4.DisplayText = "Pending";
        btn4.Name = "Pending";
        btn4.Url = "/ChangeManagement/Pending";
        btn4.Roles = new List<string>(){"User","Initiator"};

        ButtonModel btn5 = new ButtonModel();
        btn5.DisplayText = "Pending with Others";
        btn5.Name = "Pending with";
        btn5.Url = "/ChangeManagement/PendingWith";
        btn5.Roles = new List<string>(){"User","Initiator"};

        ButtonModel btn2 = new ButtonModel();
        btn2.DisplayText = "Create CR";
        btn2.Name = "Create CR";
        btn2.Url = "/ChangeManagement/Pending";
        btn2.Roles = new List<string>(){"Initiator"};

        ButtonModel btn6 = new ButtonModel();
        btn6.DisplayText = "Rejected";
        btn6.Name = "Rejected";
        btn6.Url = "/ChangeManagement/Rejected";
        btn6.Roles = new List<string>(){"Admin","User","Initiator"};

        ButtonModel btn3 = new ButtonModel();
        btn3.DisplayText = "Saved";
        btn3.Name = "Saved";
        btn3.Url = "/ChangeManagement/Saved";
        btn3.Roles = new List<string>(){"Admin","User","Initiator"};

        List<ButtonModel> ButtonList = new List<ButtonModel>();
        ButtonList.Add(btn1);
        ButtonList.Add(btn2);
        ButtonList.Add(btn3);
        ButtonList.Add(btn4);
        ButtonList.Add(btn5);
        ButtonList.Add(btn6);
        return ButtonList;
    }
    
    public IActionResult Index()
    {
        NavBarItemModel vcproperties = new NavBarItemModel("Initiator",ButtonList());
        NavBarItemModel vcproperties1 = new NavBarItemModel("Initiator",new List<ButtonModel>());
        return View(vcproperties);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
