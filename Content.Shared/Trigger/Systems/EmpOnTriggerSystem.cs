using Content.Shared.Emp;
using Content.Shared.Trigger.Components.Effects;

namespace Content.Shared.Trigger.Systems;

public sealed class EmpOnTriggerSystem : XOnTriggerSystem<EmpOnTriggerComponent>
{
    [Dependency] private readonly SharedEmpSystem _emp = default!;
    [Dependency] private readonly SharedTransformSystem _transform = default!;

    protected override void OnTrigger(Entity<EmpOnTriggerComponent> ent, EntityUid target, ref TriggerEvent args)
    {
<<<<<<< HEAD
        base.Initialize();

        SubscribeLocalEvent<EmpOnTriggerComponent, TriggerEvent>(OnTrigger);
    }

    private void OnTrigger(Entity<EmpOnTriggerComponent> ent, ref TriggerEvent args)
    {
        if (args.Key != null && !ent.Comp.KeysIn.Contains(args.Key))
            return;

        var target = ent.Comp.TargetUser ? args.User : ent.Owner;

        if (target == null)
            return;

        _emp.EmpPulse(_transform.GetMapCoordinates(target.Value), ent.Comp.Range, ent.Comp.EnergyConsumption, (float)ent.Comp.DisableDuration.TotalSeconds);
=======
        _emp.EmpPulse(Transform(target).Coordinates, ent.Comp.Range, ent.Comp.EnergyConsumption, ent.Comp.DisableDuration, args.User);
>>>>>>> c01ec294d01 (Reduce Triggers Boilerplate. (#41086))
        args.Handled = true;
    }
}
