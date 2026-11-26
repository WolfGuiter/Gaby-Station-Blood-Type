using Robust.Client.Graphics;

namespace Content.Client._Dumont.FireNet.Ui.FireNetConsole;

public static class FireNetConsoleTheme
{
    public static readonly StyleBoxFlat Background = new() { BackgroundColor = Color.FromHex("#3b3b08") };
    public static readonly StyleBoxFlat NavBar = new() { BackgroundColor = Color.FromHex("#757326") };
    public static readonly Color Button = Color.FromHex("#b0b02c");
    private static StyleBoxFlat Box(Color background, Color border) => new()
    {
        BackgroundColor = background,
        BorderColor = border,
        BorderThickness = new Thickness(1),
    };
}