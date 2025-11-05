# ExteranlLogin

An ASP.NET Core 8.0 MVC web application that provides secure **external authentication** using popular providers such as Google, Facebook, and Microsoft.  
This project demonstrates integrating third-party authentication with ASP.NET Identity and Entity Framework Core.

---

## 🚀 Features

- ASP.NET Core 8 MVC architecture  
- External authentication (Google, Facebook, Microsoft, etc.)  
- Integrated ASP.NET Core Identity  
- Entity Framework Core with SQL Server or SQLite  
- Responsive Bootstrap 5 user interface  
- Login, logout, and registration management  
- Development and production configuration support  

---

## 🧩 Project Structure

```
ExteranlLogin/
├── Areas/
│   └── Identity/
│       └── Pages/
│           └── Account/
│               ├── Login.cshtml
│               ├── Login.cshtml.cs
│               └── _ViewImports.cshtml
│
├── Controllers/
│   └── HomeController.cs
│
├── Data/
│   ├── ApplicationDbContext.cs
│   └── Migrations/
│
├── Models/
│   └── ErrorViewModel.cs
│
├── Views/
│   ├── Home/
│   ├── Shared/
│   └── _ViewImports.cshtml
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   ├── lib/
│   └── image/
│
├── Program.cs
├── appsettings.json
└── ExteranlLogin.csproj
```

---

## ⚙️ Requirements

- .NET 8.0 SDK  
- Visual Studio 2022 or later  
- SQL Server or LocalDB  
- Internet connection for external authentication setup  

---

## 🧠 How to Run the Project

1. Clone this repository:

   ```bash
   git clone https://github.com/yourusername/ExteranlLogin.git
   ```

2. Navigate into the project folder:

   ```bash
   cd ExteranlLogin
   ```

3. Restore dependencies:

   ```bash
   dotnet restore
   ```

4. Apply database migrations:

   ```bash
   dotnet ef database update
   ```

5. Run the application:

   ```bash
   dotnet run
   ```

6. Open your browser and navigate to:  
   👉 http://localhost:5000 or http://localhost:5179

---

## 🔑 Configuring External Logins

1. Go to the **Google Cloud Console** or **Facebook Developers** dashboard.  
2. Create new OAuth credentials for your app.  
3. Copy your **Client ID** and **Client Secret**.  
4. Add them inside the `appsettings.json` file:

   ```json
   "Authentication": {
     "Google": {
       "ClientId": "YOUR_CLIENT_ID",
       "ClientSecret": "YOUR_CLIENT_SECRET"
     },
     "Facebook": {
       "AppId": "YOUR_APP_ID",
       "AppSecret": "YOUR_APP_SECRET"
     }
   }
   ```

5. Save and restart the project.  

---

## 🧩 Technologies Used

- ASP.NET Core 8.0 MVC  
- Entity Framework Core 8  
- ASP.NET Core Identity  
- C# 12  
- Bootstrap 5  
- SQL Server / SQLite  
- OAuth 2.0  

---

## 👨‍💻 Author

**Ahmed Saleh**  
Junior .NET Backend Developer  
📧 [GitHub](https://github.com/ahmedsaleh374) | [LinkedIn](https://www.linkedin.com/in/ahmedsaleh8090)

---

## 🪪 License

This project is licensed under the **MIT License**.  
You may freely use, modify, and distribute it with proper attribution.
