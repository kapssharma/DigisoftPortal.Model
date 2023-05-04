using DigisoftPortal.Model.Models.Request;
using DigisoftPortal.Model.Models.Response;

namespace Digisoft.Portal.Model.ViewModels;
    public class VMPortal
    {
    public VMPortal()
    {
        PortalRequest = new PortalRequest();
        Portals = new Portals();
    }

    public Portals? Portals { get; set; }
    public PortalRequest? PortalRequest { get; set; }
}