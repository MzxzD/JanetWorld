# Model Sourcing — Janet (Hatsune Miku) & User (Kazuma)

Place 3D models in `Assets/Models/Janet/` and `Assets/Models/User/`.

## JANET — Hatsune Miku

| Source | Format | License | Notes |
|--------|--------|---------|-------|
| **VRoid Hub** | VRM | Varies | Search "Miku" — check per-model license |
| **Booth.pm** | VRM, MMD | Varies | Japanese marketplace; verify commercial use |
| **Unity Asset Store** | FBX, etc. | Per-asset | Search "anime character", "Miku style" |
| **Placeholder** | Unity Cube/Capsule | N/A | Use for development until final model |

**Recommended:** Start with a simple placeholder (capsule or cube with material); swap for VRM/FBX before store submission. Ensure license allows app distribution.

## USER — Kazuma (KonoSuba)

KonoSuba is a licensed property. Options:

| Source | License | Notes |
|--------|---------|-------|
| **VRoid** | Create custom | Design Kazuma-style avatar in VRoid Studio (free) |
| **Placeholder** | N/A | Capsule/cube for dev |
| **Licensed asset** | Commercial | If official KonoSuba assets exist, verify license |

**Recommended:** Use VRoid Studio to create an original "Kazuma-inspired" avatar, or a placeholder until licensing is resolved.

## Importing into Unity

1. **VRM:** Install [UniVRM](https://github.com/vrm-c/UniVRM) from Package Manager or Asset Store
2. **FBX/GLB:** Unity imports natively
3. **MMD:** May require MMD4Mecanim or similar plugin
4. Drag models into `Assets/Models/Janet/` or `Assets/Models/User/`
5. Assign to `JanetAvatarController` and `UserAvatarController` in scene
