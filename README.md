# JanetWorld

Mixed Reality app for Meta Quest 3/3S — Passthrough AR with JANET (Hatsune Miku) and USER (Kazuma) avatars. Target: Meta Horizon Store.

## Features

- **Passthrough / Mixed Reality** — See the real world with virtual avatars overlaid
- **JANET** — Hatsune Miku-style AI companion avatar
- **USER** — Kazuma (KonoSuba) avatar for the player
- **Meta Quest 3/3S** — Meta Horizon OS, Passthrough API

## Quick Start

1. **Setup** — Install tools: [docs/SETUP.md](docs/SETUP.md)
2. **Build** — Build for Quest: [docs/BUILD.md](docs/BUILD.md)
3. **Test** — Run automated tests: [docs/TESTING.md](docs/TESTING.md)
4. **Models** — Janet (Miku) & User (Kazuma) sourcing: [docs/MODELS_SOURCING.md](docs/MODELS_SOURCING.md)
5. **Store** — Submission checklist: [docs/STORE_SUBMISSION.md](docs/STORE_SUBMISSION.md)

## Project Structure

```
JanetWorld/
├── README.md
├── docs/           # SETUP, BUILD, TESTING, STORE_SUBMISSION
├── Assets/
│   ├── Scripts/    # Avatar and Passthrough controllers
│   ├── Models/     # Janet (Miku), User (Kazuma)
│   └── Scenes/     # MainMRScene
├── tests/          # Unity Test Framework
└── .github/        # CI workflows
```

## Tech Stack

- **Engine:** Unity 2022.3 LTS+
- **Platform:** Meta Quest 3/3S (Meta Horizon OS)
- **MR:** Meta Passthrough (Building Blocks)

## Status

- **Target:** Meta Horizon Store ready-to-publish
- **Pipeline:** Tools → Build → Test → Document → Git → Push → Report

## Related

- [Research/3D-TO-VIDEO-VR-TWITCH-RESEARCH.md](../../Research/3D-TO-VIDEO-VR-TWITCH-RESEARCH.md) — Meta Quest dev paths, Passthrough
- [janet_ultimate VR client](../../janet_ultimate/ok%20JANET/janet-mesh/clients/vr/) — VR patterns
