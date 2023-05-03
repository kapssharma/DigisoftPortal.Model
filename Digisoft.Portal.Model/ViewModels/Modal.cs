namespace Digisoft.Portal.Model.ViewModels;
public class Modal
{
    public bool HideTitle { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }
    public bool OnCancelRefresh { get; set; }
    public bool RefreshContentID { get; set; }
    public bool RefreshFieldID { get; set; }
    public bool RefreshAction { get; set; }
    public bool HideFooter { get; set; }
    public bool HideSaveButton { get; set; }
    public string? AjaxPostAction { get; set; }
    public string? ModalPopupID { get; set; }
    public string? FormID { get; set; }
    public string? CloseButtonText { get; set; } = "Close";
    public string? SaveButtonText { get; set; } = "Submit";
    public string? ModalClassName { get; set; }
    public string? FunctionName { get; set; } = "OnSubmit(this)";
    public string? CallBackFunctionName { get; set; }

}
