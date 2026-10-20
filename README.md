# Lab3F — Laboratorio 3: MiniList<T>

Solución de referencia en C#/.NET 8 para una aplicación Windows Forms que representa elementos mediante una lista enlazada genérica e implementa `IEnumerable<T>`/`IEnumerator<T>`.

## Estructura
- `src/MiniListApp/MiniListApp.csproj`: proyecto Windows Forms para Windows.
- `src/MiniListApp/Program.cs`: punto de entrada.
- `src/MiniListApp/MiniList.cs`: lista enlazada genérica y enumerador.
- `src/MiniListApp/Form1.cs`: interfaz y acciones del laboratorio.
- `reports/Informe_Espanol.md`, `reports/Отчёт_Русский.md`, `reports/Report_English.md`: informes en tres idiomas.

## Requisitos
- Windows
- .NET 8 SDK
- Visual Studio 2022 o Visual Studio Code con C# Dev Kit

## Ejecutar
Desde Windows, en la raíz del repositorio:

```powershell
dotnet restore .\src\MiniListApp\MiniListApp.csproj
dotnet run --project .\src\MiniListApp\MiniListApp.csproj
```

> Windows Forms requiere Windows. En Linux/macOS puede revisarse el código, pero no ejecutarse esta interfaz con el runtime estándar.

## Funcionalidad
1. Crear una lista vacía.
2. Agregar botones como elementos de la lista.
3. Recorrer los controles visuales del panel.
4. Recorrer los elementos mediante `foreach` sobre `MiniList<T>`.

## Estado de validación
La estructura y el código están incorporados en esta rama. La compilación de Windows Forms no se ha ejecutado en un entorno Windows en esta sesión. Antes de entregar, ejecutar los comandos anteriores y contrastar los detalles con el documento original de la asignatura.

## Informes
Los informes están en Markdown para que puedan revisarse y convertirse a Word/PDF si se requiere.
