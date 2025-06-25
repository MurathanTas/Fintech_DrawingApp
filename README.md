# DrawingApp

Dil / Platform:C# 12 · .NET 8 · Windows

UI: WinForms (GDI+)


 1)Özellikler

 Sürükle‑Bırak Taşıma – Çakışma/tuval sınır kontrolü dâhil

 9 Renk Paleti – Çizim yaparken veya seçili şeklin rengini anında değiştirin

 Kaydet/Yükle – TXT depoya seri hâlde yazılır, Git diff’leri okunabilir kalır

 Hit‑Test – Son tıklanan şekli seçer, kesik çerçeve ile vurgular

 Araç Çubuğu – Rectangle · Ellipse · Triangle · Hexagon · Cursor



2)Proje Yapısı

DrawingApp/

├─ DrawingApp/           # WinForms UI + Program.cs

│  ├─ Form1.cs           # Sadece View; buton & dialog mantığı

│  └─ DrawingController.cs# SRP refactor – tuval & iş mantığı

├─ DrawingApp.Shapes/    # Shape + alt sınıflar

├─ DrawingApp.Services/  # IRepository, TxtDrawingRepository


3)Kurulum

3.1)Clone’la & Aç

git clone https://github.com/MurathanTas/Fintech_DrawingApp.git

cd Fintech_DrawingApp

3.2)Visual Studio 2022 ya da dotnet build ile derleyin

dotnet build

3.3)Çalıştır

dotnet run --project Fintech_DrawingApp

En az .NET 8 SDK + Windows gereklidir (WinForms).
