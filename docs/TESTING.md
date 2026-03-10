# JanetWorld Testing

Automated and manual test runbook.

## Automated Tests (Unity Test Framework)

### Setup

1. Window → General → Test Runner
2. Create test assembly: Edit mode or Play mode
3. Tests live in `Assets/Tests/` or `tests/` (depending on project layout)

### Run Tests

1. **Edit Mode:** Test Runner → EditMode → Run All
2. **Play Mode:** Test Runner → PlayMode → Run All

```bash
# From command line (Unity Headless)
/Applications/Unity/Hub/Editor/2022.3.x/Unity.app/Contents/MacOS/Unity \
  -runTests -batchmode -projectPath /path/to/JanetWorld \
  -testResults results.xml -testPlatform EditMode
```

### Test Cases

| Test | Scope | Assertion |
|------|-------|-----------|
| `PassthroughManager_Enable_Succeeds` | Passthrough toggle | Passthrough layer active |
| `JanetAvatar_Spawn_Exists` | Janet avatar | GameObject in scene |
| `UserAvatar_Spawn_Exists` | User avatar | GameObject in scene |
| `MainScene_Load_Succeeds` | Scene load | MainMRScene loads without error |

### Edge Cases

- Passthrough disabled (fallback to passthrough-off mode)
- No headset connected (Editor play mode)
- Avatar model missing (placeholder fallback)

### CI (GitHub Actions)

Placeholder workflow in `.github/workflows/`. Unity license required for CI; use Unity Cloud Build or self-hosted runner with licensed Unity for full automation.
