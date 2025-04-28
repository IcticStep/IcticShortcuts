# IcticShortcuts

[![Unity Editor Extension](https://img.shields.io/badge/Unity-Editor%20Extension-blue.svg)](https://unity.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

**IcticShortcuts** adds essential shortcuts to the Unity Editor's **File** menu to boost productivity and fix common IDE or workflow issues — no tedious clicking required!

---

## ✨ Features

- **Domain Reload** (`Ctrl + Shift + Alt + D`)  
  Reloads the scripting domain manually. Especially useful for projects using **"Enter Play Mode Options"** with **"Domain Reload" disabled**.

- **Regenerate Project Files** (`Ctrl + Shift + Alt + R`)  
  Forces Unity to regenerate IDE project files. Helps when **Rider** or **Visual Studio** integration malfunctions.

- **Save Project and Scenes** (`Ctrl + Shift + Alt + S`)  
  Saves all open scenes and project files to prevent data loss.

Each action logs a colorful message in the Console for quick feedback!

---

## 🛠 Shortcuts Summary

| Action                      | Menu Path                     | Shortcut                |
| :--------------------------- | :----------------------------- | :---------------------- |
| **Domain Reload**            | File → Domain Reload           | `Ctrl + Shift + Alt + D` |
| **Regenerate Project Files** | File → Regenerate Project Files | `Ctrl + Shift + Alt + R` |
| **Save Project and Scenes**  | File → Save Project and Scenes  | `Ctrl + Shift + Alt + S` |

---

## 🚀 Installation

1. Go to the [Releases](https://github.com/IcticStep/IcticShortcuts/releases) page.
2. Download the latest `IcticShortcuts.unitypackage`.
3. In Unity, open your project and import the package via  
   **Assets → Import Package → Custom Package...**.

Done! The new shortcuts will now appear under the **File** menu.

---

## 📜 Code Overview

<details>
<summary>Example Shortcut Code</summary>

```csharp
[MenuItem("File/Domain Reload %#&d")]
public static void ReloadDomain()
{
    AssetDatabase.SaveAssets();
    EditorUtility.RequestScriptReload();
    LogActionDone("Domain reloaded.");
}
```
- `%` = Ctrl (Cmd on Mac)
- `#` = Shift
- `&` = Alt
- `d` = D key
</details>

---

## 🎯 Why Use IcticShortcuts?

- Save time during development.
- Quickly recover broken IDE integration.
- Manually trigger domain reloads when needed.

---

## 🤝 Contributing

Suggestions for new shortcuts are welcome!  
Feel free to open an issue or submit a pull request.

---

## 📢 License

This project is licensed under the [MIT License](LICENSE).
