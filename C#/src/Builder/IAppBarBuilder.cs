public abstract class IAppBarBuilder {
    protected AppBar appBar;

    public abstract void SetProperties();
    public abstract void SetLinks();
    public abstract void SetTitle();
    public abstract void SetActions();
    public void CreateAppBar() {
        appBar = new AppBar();
    }
    public AppBar GetAppBar() {
        return appBar;
    }
}