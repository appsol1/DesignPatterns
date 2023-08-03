public class CalendarAppBarBuilder : IAppBarBuilder {
    public override void SetProperties() {
        appBar.Properties = new string[]{"Coffee Beans", "QA Test property"};
    }

    public override void SetTitle() {
        appBar.Title = "Calendar";
    }

    public override void SetLinks() {
        appBar.Links = new string[]{"Calendar", "Turn Board", "Notifications"};
    }

    public override void SetActions() {
        appBar.Actions = new string[]{"filter", "search", "Profile"};
    }
}