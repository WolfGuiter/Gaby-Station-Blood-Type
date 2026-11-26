using System.Linq;
using Content.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Utility;

namespace Content.Client._Dumont.FireNet.Ui.FireNetConsole;

public sealed partial class FireNetConsoleWindow : FancyWindow
{
    public FireNetConsoleWindow()
    {
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);
    }
}