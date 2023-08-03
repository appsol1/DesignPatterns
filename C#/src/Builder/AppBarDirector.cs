public class AppBarDirector {
    public AppBar Build(IAppBarBuilder appBarBuilder) {
        appBarBuilder.CreateAppBar();
        appBarBuilder.SetProperties();
        appBarBuilder.SetTitle();
        appBarBuilder.SetLinks();
        appBarBuilder.SetActions();

        return appBarBuilder.GetAppBar();
    }
}