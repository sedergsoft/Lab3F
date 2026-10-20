# Lab3F — Laboratorio 3: MiniList<T>

Solución de referencia en C#/.NET 8 para una aplicación Windows Forms que representa elementos mediante una lista enlazada genérica e implementa `IEnumerable<T>`.

## Estructura
- `src/MiniListApp/MiniListApp.csproj`: proyecto Windows Forms para Windows.
- `src/MiniListApp/Program.cs`: punto de entrada.
- `src/MiniListApp/MiniList.cs`: lista enlazada genérica.
- `src/MiniListApp/Form1.cs`: interfaz y acciones del laboratorio.
- `reports/Informe_Espanol.md`, `reports/Отчёт_Русский.md`, `reports/Report_English.md`: informes en tres idiomas.
- `reports/TEST_PLAN.md`: plan de pruebas en español, ruso e inglés.
- `.github/workflows/ci.yml`: compilación automática en Windows con .NET 8 para cada push y pull request.

## Requisitos
- Windows 10/11
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

## Validación pendiente
El workflow de GitHub Actions compilará el proyecto en Windows. Hasta que se ejecute correctamente, no debe afirmarse que la compilación está validada. También hay que ejecutar los casos de `reports/TEST_PLAN.md` y cotejar la solución con el documento oficial de la asignatura, que no se ha podido recuperar de la conversación compartida.

## Informes
Los informes están en Markdown para facilitar la revisión y conversión a Word/PDF si se requiere.
