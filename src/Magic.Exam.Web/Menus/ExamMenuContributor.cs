using System.Threading.Tasks;
using Magic.Exam.Localization;
using Magic.Exam.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Magic.Exam.Web.Menus;

public class ExamMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<ExamResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                ExamMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );


        context.Menu.AddItem(
            new ApplicationMenuItem(
                ExamMenus.Exam,
                l["Menu:Exam"],
                icon: "fa fa-book"
            ).AddItem(
                new ApplicationMenuItem(
                    ExamMenus.Examinations,
                    l["Menu:Examinations"],
                    url: "/Examinations"
                )
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        return Task.CompletedTask;
    }
}
