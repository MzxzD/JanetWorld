# JanetWorld Setup

Tools and environment setup for Meta Quest 3/3S development.

## Prerequisites

### 1. Unity Hub + Unity

- **Unity Hub:** [https://unity.com/download](https://unity.com/download)
- **Unity Version:** 2022.3 LTS or newer (or Unity 6.x)
- **Modules:** Android Build Support, Android SDK & NDK

```bash
# After install, verify
# Unity Hub → Installs → Add → 2022.3.x LTS with Android
```

### 2. Meta XR SDK

- **All-in-One SDK:** [Unity Asset Store — Meta XR All-in-One](https://assetstore.unity.com/packages/tools/integration/meta-xr-all-in-one-sdk-269091)
- Or add via Unity Package Manager: Meta XR SDK packages
- **Documentation:** [Meta Horizon Unity Docs](https://developers.meta.com/horizon/documentation/unity/)

### 3. Android SDK / NDK

- Installed with Unity Android Build Support
- Or standalone: [Android Studio — SDK Manager](https://developer.android.com/studio)
- Verify `ANDROID_HOME` (or `ANDROID_SDK_ROOT`) is set

### 4. Meta Quest Developer Hub (MQDH)

- **Download:** [Meta Quest Developer Hub](https://developer.oculus.com/downloads/package/oculus-developer-hub-mac/)
- For device management, build deploy, debugging

### 5. ADB (Android Debug Bridge)

- Part of Android SDK Platform Tools
- **Download:** [Platform Tools](https://developer.android.com/studio/releases/platform-tools)
- Add to PATH; verify: `adb version`

### 6. Git

- [https://git-scm.com](https://git-scm.com)
- Verify: `git --version`

## Unity Project Setup

This project already includes:
- Unity ProjectSettings and Packages (Unity 6 / 2022.3+)
- Meta scoped registry (add Meta XR SDK via Asset Store or Package Manager)
- Unity Test Framework

1. Open project in Unity Hub: Add → select `JanetWorld` folder
2. Set build target: File → Build Settings → Android
3. Add Passthrough: Meta icon (bottom-right) → Building Blocks → Add Block → Passthrough
4. (Optional) Add Meta XR All-in-One from Asset Store for full feature set
5. Import JanetWorld Assets (Scripts, Models) into `Assets/`
6. Run Project Setup Tool (Meta) for Quest compliance

## Quest Device Setup

1. Enable **Developer Mode** on Quest: Settings → System → Developer → ON
2. Enable **USB Debugging**: Connect via USB-C, accept prompt
3. Verify: `adb devices` shows your Quest

## Verification

| Tool        | Command           | Expected              |
|-------------|-------------------|------------------------|
| Unity       | Open project      | No errors              |
| ADB         | `adb devices`     | Quest listed           |
| Meta SDK    | Meta → Building Blocks | Passthrough available |
