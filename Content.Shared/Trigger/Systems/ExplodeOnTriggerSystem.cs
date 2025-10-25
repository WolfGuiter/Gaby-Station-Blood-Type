using Content.Shared.Explosion.EntitySystems;
using Content.Shared.Trigger.Components.Effects;

namespace Content.Shared.Trigger.Systems;

public sealed class ExplodeOnTriggerSystem : XOnTriggerSystem<ExplodeOnTriggerComponent>
{
    [Dependency] private readonly SharedExplosionSystem _explosion = default!;

    protected override void OnTrigger(Entity<ExplodeOnTriggerComponent> ent, EntityUid target, ref TriggerEvent args)
    {
<<<<<<< HEAD
        base.Initialize();

        SubscribeLocalEvent<ExplodeOnTriggerComponent, TriggerEvent>(OnTrigger);
    }

    private void OnTrigger(Entity<ExplodeOnTriggerComponent> ent, ref TriggerEvent args)
    {
        if (args.Key != null && !ent.Comp.KeysIn.Contains(args.Key))
            return;

        var target = ent.Comp.TargetUser ? args.User : ent.Owner;
=======
        _explosion.TriggerExplosive(target, user: args.User);
        args.Handled = true;
    }
}
>>>>>>> c01ec294d01 (Reduce Triggers Boilerplate. (#41086))

public sealed class ExplosionOnTriggerSystem : XOnTriggerSystem<ExplosionOnTriggerComponent>
{
    [Dependency] private readonly SharedExplosionSystem _explosion = default!;

<<<<<<< HEAD
        _explosion.TriggerExplosive(target.Value, user: args.User);
=======
    protected override void OnTrigger(Entity<ExplosionOnTriggerComponent> ent, EntityUid target, ref TriggerEvent args)
    {
        _explosion.QueueExplosion(target,
            ent.Comp.ExplosionType,
            ent.Comp.TotalIntensity,
            ent.Comp.IntensitySlope,
            ent.Comp.MaxTileIntensity,
            ent.Comp.TileBreakScale,
            ent.Comp.MaxTileBreak,
            ent.Comp.CanCreateVacuum,
            args.User);
>>>>>>> c01ec294d01 (Reduce Triggers Boilerplate. (#41086))
        args.Handled = true;
    }
}
