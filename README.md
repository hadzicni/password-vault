# 🔐 Password Vault

A secure and user-friendly desktop application for managing and storing your passwords locally using strong encryption. Built with C# and WPF, **Password Vault** ensures your sensitive information remains private and accessible only to you.

![.NET](https://img.shields.io/badge/.NET-6.0-blue?logo=dotnet)
![License](https://img.shields.io/badge/license-MIT-green.svg)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey)

---

## ✨ Features

- 🔐 Secure password storage with encryption
- 🧠 User-friendly WPF interface
- 🧩 Modular design for easy extensibility
- 🗂 View and manage stored credentials
- 🔒 Login window for access protection

---

## 📦 Installation

### Requirements

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download) or later
- Windows OS

### Steps

```bash
git clone https://github.com/hadzicni/Password-Vault.git
cd Password-Vault/PasswordVault
dotnet build
```

Then run the application using:

```bash
dotnet run
```

---

## 🚀 Usage

1. Launch the application.
2. Log in to access your vault.
3. Add, view, and manage your password entries.
4. Data is securely stored using encryption.

---

## 🧪 Project Structure

```
PasswordVault/
├── App.xaml                    # Application definition
├── MainWindow.xaml             # Main dashboard UI
├── LoginWindow.xaml            # Login UI
├── InfoWindow.xaml             # Info display window
├── Data/
│   └── VaultStorage.cs         # Handles secure data storage
├── Models/
│   └── PasswordEntry.cs        # Model for password records
├── Services/
│   └── EncryptionService.cs    # Handles encryption/decryption
├── PasswordVault.csproj        # Project file
```

---

## 🤝 Contributing

Contributions are welcome! Please fork the repository and submit a pull request for any enhancements or fixes.

---

## 📄 License

This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for details.

---
