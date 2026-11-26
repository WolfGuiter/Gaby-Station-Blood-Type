using Robust.Client.UserInterface;
using JetBrains.Annotations;

namespace Content.Client._Dumont.FireNet.Ui.FireNetConsole;

[UsedImplicitly]
public sealed class FireNetConsoleBui(EntityUid owner, Enum uiKey) : BoundUserInterface(owner, uiKey)
{
    private FireNetConsoleWindow? _window;

    protected override void Open()
    {
        base.Open();

        _window = this.CreateWindow<FireNetConsoleWindow>();
    }

}