# JWT Authentication in .NET Core Web API

This project demonstrates how to implement **JWT (JSON Web Token) Authentication** in an ASP.NET Core Web API. It includes secure endpoints, token generation, and Swagger integration for testing.

## 🚀 Features

- JWT Token generation via login endpoint
- Secure API endpoints using `[Authorize]`
- Swagger UI integration with JWT support
- Configuration via `appsettings.json`

## 🔧 Technologies Used

- ASP.NET 10
- C#
- Swagger (Swashbuckle)
- JWT Bearer Authentication
- .NET Dependency Injection

## 📁 Project Structure
```
JWT-Authentication-in-.NET-Core-Web-API/
│
├── Controllers/
│   └── AuthController.cs
│   └── MyRequestController.cs
│
├── Models/
│   └── LoginInfo.cs
│
├── Service/
│   └── JwtService.cs
│
├── Program.cs
├── appsettings.json
└── README.md
```
## 🔐 How JWT Authentication Works

1. User sends credentials to `/api/Auth/Login`.
2. If valid, a JWT token is returned.
3. Token is passed in the `Authorization` header as `Bearer <token>`.
4. Secure endpoints require `[Authorize]` and validate the token.

## 🧪 Testing with Swagger

1. Run the project.
2. Open Swagger UI at `/swagger`.
3. Use the **Authorize** button to enter your JWT token:
4. Call secure endpoints like `/api//MyRequest/GetMySecureData`.

## 📦 Configuration

Update `appsettings.json` with your JWT settings:Ideally read this from Azure key vault

```json
"Jwt": {
  "Key": "My_Super_Authentication_Super_Secreatkey",
  "Issuer": "myjwt_issuer",
  "Audience": "myjwt_audience",
  "Expires": 5
}
