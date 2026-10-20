# Plan de pruebas / План тестирования / Test Plan

## Preparación
En Windows 10/11 con .NET 8, ejecutar `dotnet restore ./src/MiniListApp/MiniListApp.csproj` y `dotnet build ./src/MiniListApp/MiniListApp.csproj -c Release`.

| ID | Acción | Resultado esperado |
|---|---|---|
| TC-01 | Iniciar la aplicación | La ventana se abre sin excepción. |
| TC-02 | Añadir antes de crear la lista | Se muestra un mensaje útil y la aplicación continúa. |
| TC-03 | Crear lista | El panel queda vacío. |
| TC-04 | Añadir un elemento | Aparece un CheckBox y el total es 1. |
| TC-05 | Añadir varios elementos | El total coincide con los elementos añadidos. |
| TC-06 | Recorrer botones | Se cuenta el número de CheckBox del panel. |
| TC-07 | Recorrer objetos | `foreach` recorre la colección y cuenta todos sus elementos. |
| TC-08 | Crear otra lista | Los controles anteriores se eliminan y el contador vuelve a cero. |

## Критерии приёмки
- Проект собирается в Windows с .NET 8.
- При добавлении до создания списка отображается понятное сообщение.
- Число визуальных элементов совпадает с числом объектов коллекции.
- Отчёты на русском, испанском и английском языках находятся в `reports`.

## Acceptance criteria
- The project builds on Windows with .NET 8.
- Adding before list creation shows a helpful message.
- The visual-control count matches collection iteration.
- Reports in Russian, Spanish, and English are present in `reports`.

**Estado / Статус / Status:** this plan is documented, but the cases still need to be executed on Windows. Documenting a test is not the same as passing it.
