using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using navcomp.Models;
using  Intelizign.Net.ViewComponents.NavBarViewComponent;

namespace navcomp.Controllers;

public class ChangeManagementController : Controller
{
    private readonly ILogger<ChangeManagementController> _logger;
    public ChangeManagementController(ILogger<ChangeManagementController> logger)
    {
        _logger = logger;
    }
    public List<ButtonModel> buttonlist()
    {
        ButtonModel btn1 = new ButtonModel();
        btn1.DisplayText = "Main";
        btn1.Name = "main";
        btn1.Roles = new List<string>(){"Admin","User","Initiator"};
        btn1.Url = "/ChangeManagement/Main";
        
        ButtonModel btn4 = new ButtonModel();
        btn4.DisplayText = "Pending";
        btn4.Name = "pending";
        btn4.Url = "/ChangeManagement/Pending";
        btn4.Roles = new List<string>(){"User","Initiator"};

        ButtonModel btn5 = new ButtonModel();
        btn5.DisplayText = "Pending With Others";
        btn5.Name = "pendingwithothers";
        btn5.Url = "/ChangeManagement/PendingWithOthers";
        btn5.Roles = new List<string>(){"User","Initiator"};

        ButtonModel btn2 = new ButtonModel();
        btn2.DisplayText = "Create CR";
        btn2.Name = "createcr";
        btn2.Url = "/ChangeManagement/CreateCR";
        btn2.Roles = new List<string>(){"Initiator"};

        ButtonModel btn6 = new ButtonModel();
        btn6.DisplayText = "Rejected";
        btn6.Name = "rejected";
        btn6.Url = "/ChangeManagement/Rejected";
        btn6.Roles = new List<string>(){"Admin","User","Initiator"};

        ButtonModel btn3 = new ButtonModel();
        btn3.DisplayText = "Saved";
        btn3.Name = "saved";
        btn3.Url = "/ChangeManagement/saved";
        btn3.Roles = new List<string>(){"Admin","User","Initiator"};

        List<ButtonModel> buttonlist = new List<ButtonModel>();
        buttonlist.Add(btn1);
        buttonlist.Add(btn2);
        buttonlist.Add(btn3);
        buttonlist.Add(btn4);
        buttonlist.Add(btn5);
        buttonlist.Add(btn6);
        return buttonlist;
    }
    public IActionResult Main()
    {
        NavBarItemModel vcproperties = new NavBarItemModel("Initiator",buttonlist());
        return View(vcproperties);
    }
    public IActionResult CreateCR()
    {
        NavBarItemModel vcproperties = new NavBarItemModel("Initiator",buttonlist());
        return View(vcproperties);
    }
    public IActionResult Pending()
    {
        NavBarItemModel vcproperties = new NavBarItemModel("Initiator",buttonlist());
        return View(vcproperties);
    }
    public IActionResult PendingWithOthers()
    {
        NavBarItemModel vcproperties = new NavBarItemModel("Initiator",buttonlist());
        return View(vcproperties);
    }
    public IActionResult Rejected()
    {
        NavBarItemModel vcproperties = new NavBarItemModel("Initiator",buttonlist());
        return View(vcproperties);
    }
    public IActionResult Saved()
    {
        NavBarItemModel vcproperties = new NavBarItemModel("Initiator",buttonlist());
        return View(vcproperties);
    }
    public IActionResult Index()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}