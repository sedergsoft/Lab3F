# Lab3F — Laboratorio 3: MiniList<T>

Solución en C#/.NET 8 para una aplicación Windows Forms que usa una lista enlazada genérica `MiniList<T>` e implementa `IEnumerable<T>` e `IEnumerator<T>`.

## Estructura
- `src/MiniListApp/MiniListApp.csproj`: proyecto Windows Forms para Windows.
- `src/MiniListApp/Program.cs`: punto de entrada.
- `src/MiniListApp/MiniList.cs`: lista enlazada genérica y enumerador explícito (`Current`, `MoveNext`, `Reset`, `Dispose`).
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

## Validación
- GitHub Actions completó correctamente `Restore` y `Build` en Windows con .NET 8 para el commit de implementación `25bc5575949f4430f65604cc4d2c02c033f3454a`.
- La validación anterior confirma compilación, no pruebas funcionales de la interfaz.
- Los casos manuales de `reports/TEST_PLAN.md` aún deben ejecutarse en Windows.
- El documento oficial `ТПР ПО Осн Лаб 3.docx` está incluido en esta rama, pero su contenido no se ha cotejado línea por línea; por tanto, no se afirma que todos los requisitos docentes estén verificados.

## Informes
Los informes están en Markdown para facilitar la revisión y conversión a Word/PDF si se requiere.
