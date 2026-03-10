# JanetWorld Build Guide

Build APK for Meta Quest 3/3S.

## Prerequisites

- Complete [SETUP.md](SETUP.md)
- Unity project configured for Android (Quest)
- Meta XR SDK and Passthrough installed
- Quest connected via USB (for deploy)

## Build Steps

### 1. Unity Build Settings

1. **File → Build Settings**
2. **Platform:** Android
3. **Texture Compression:** ASTC (Quest)
4. **Player Settings:**
   - Company Name, Product Name set
   - Package Name: `com.janetworld.app` (or your namespace)
   - Minimum API Level: 29+
   - Target API Level: 33+ (per Meta requirements)
   - IL2CPP, ARM64

### 2. Signing

- **Debug:** Use default debug keystore
- **Release:** Create release keystore for store submission
  - Build Settings → Player → Publishing Settings
  - Create new keystore or select existing

### 3. Build APK

1. File → Build Settings → Build (or Build And Run)
2. Choose output path (e.g. `Builds/JanetWorld.apk`)
3. Wait for build to complete

### 4. Install to Quest

**Option A — Unity Build And Run**

- Build And Run directly from Unity (Quest must be connected)

**Option B — MQDH**

- Meta Quest Developer Hub → Install APK

**Option C — ADB**

```bash
adb install -r path/to/JanetWorld.apk
```

## Verification

1. Put on Quest headset
2. Unknown Sources → JanetWorld
3. Launch app
4. Confirm Passthrough works (real world visible)
5. Confirm Janet (Miku) and User (Kazuma) avatars appear

## Troubleshooting

| Issue | Fix |
|-------|-----|
| Build fails: Android SDK | Verify ANDROID_HOME, reinstall Android module |
| APK won't install | Enable USB debugging, accept prompt on device |
| Passthrough black | Check Meta XR permissions, Passthrough layer |
| Crashes on launch | Check logcat: `adb logcat -s Unity` |
