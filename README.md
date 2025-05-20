# 🔐 Password Vault

A minimalistic WPF desktop application built with .NET 8 to securely manage and store your passwords locally. It offers a simple and intuitive interface to save, view, edit, and delete login credentials, with encrypted file-based storage.

![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet?logo=dotnet)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey)
![License](https://img.shields.io/badge/license-Apache--2.0-blue)

---

## ✨ Features

- 🗝️ Master password protected access
- 💾 Encrypted local storage for password entries
- ➕ Add / 📝 Edit / ❌ Delete entries with ease
- 🔍 View saved login credentials
- 📋 Copy details into the UI for quick reuse
- 🪪 Extra fields: Title, Username, Password, URL, Note
- 🔐 Based on AES encryption (via `VaultStorage`)
- ℹ️ Info dialog with GitHub link

---
## 🖥️ Screenshots

> _Not included here – feel free to add screenshots of `LoginWindow`, `MainWindow`, and the password list UI._

---

## ⚙️ Requirements

- Windows 10 or later
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022 or newer (recommended)

---

## 🚀 Getting Started

### 🔧 Build & Run (with Visual Studio)

1. Clone the repository:
   ```bash
   git clone https://github.com/hadzicni/Password-Vault.git
   cd Password-Vault
   ```

2. Open `PasswordVault.sln` in Visual Studio.

3. Press `F5` or click **Start** to build and run.
   
### 🛠️ Build via CLI

```bash
dotnet build
dotnet run --project PasswordVault
```

---

## 🔒 Usage

1. Start the app and enter the **master password** (`vault123` by default).
2. Add new entries with title, username, password, URL, and optional note.
3. Click **Save** to store all changes encrypted.
4. Click on an entry to populate the fields for editing.
5. Use **Delete** to remove selected entries.
6. Open the ℹ️ info window for GitHub source link.

---

## 👨‍💻 Author

Made by **Nikola Hadzic**

- GitHub: [@hadzicni](https://github.com/hadzicni)

---

## 📄 License

This project is licensed under the Apache License 2.0. See the [LICENSE](./LICENSE) file for details.

