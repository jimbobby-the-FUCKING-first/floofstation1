using Robust.Shared.Containers;
using Robust.Shared.Audio;
using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Shared.FloofStation;

[RegisterComponent]
public sealed partial class VoreComponent : Component
{
    [DataField]
    public float Delay = 5f;

    [DataField]
    public SoundSpecifier? SoundDevour = new SoundPathSpecifier("/Audio/Effects/demon_consume.ogg")
    {
        Params = AudioParams.Default.WithVolume(-4f).WithMaxDistance(1f),
    };
    public Container Stomach = default!;
}

[Serializable, NetSerializable]
public sealed partial class VoreDoAfterEvent : DoAfterEvent
{
    public VoreDoAfterEvent(int phase) { }

    public override DoAfterEvent Clone() => this;
}
