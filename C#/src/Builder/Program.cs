using System;
class Program {
    public static void Main(String[] args){
        AppBar calendarAppBar = new AppBarDirector().Build(new CalendarAppBarBuilder());
        AppBar notificationsAppBar = new AppBarDirector().Build(new NotificationsAppBarBuilder());

        calendarAppBar.ShowAppBar();
        Console.WriteLine("-----------------------");
        notificationsAppBar.ShowAppBar();
    }
}
