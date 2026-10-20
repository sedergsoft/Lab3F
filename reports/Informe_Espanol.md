# Informe de laboratorio n.º 3 — MiniList<T>

## Objetivo
Implementar una colección genérica mediante una lista enlazada simple en C# y permitir recorrer sus elementos con `IEnumerable<T>` e `IEnumerator<T>`.

## Fundamento
Una lista enlazada está formada por nodos. Cada nodo contiene un valor y una referencia al siguiente nodo. La clase `MiniList<T>` mantiene referencias al primer y último nodo y un contador de elementos.

## Implementación
- `Append(T item)` agrega un elemento al final y devuelve su índice basado en cero.
- `Count` expone el número de elementos.
- `MiniList<T>` implementa `IEnumerable<T>`, con la implementación genérica y la no genérica.
- El enumerador privado implementa explícitamente `IEnumerator<T>`: `Current`, `MoveNext()`, `Reset()` y `Dispose()`.
- `MoveNext()` recorre los nodos en orden de inserción y permanece al final después de agotar la secuencia, hasta que se llama a `Reset()`.
- La aplicación Windows Forms permite crear la lista, agregar controles `CheckBox` y comparar el recorrido de los controles visuales con el de la colección.

## Pruebas manuales
1. Iniciar la aplicación y seleccionar **Создать список**.
2. Agregar varios elementos y comprobar que el contador aumenta.
3. Ejecutar **Перебор кнопок** y verificar que el contador coincide con los controles añadidos.
4. Ejecutar **Перебор объектов** y verificar que el contador coincide con los elementos de la colección.
5. Crear una lista nueva y verificar que queda vacía.
6. Intentar agregar un elemento antes de crear la lista y comprobar que aparece un mensaje informativo.
7. Verificar la enumeración de una lista vacía, de un elemento y de varios elementos; después de que `MoveNext()` devuelva `false`, las llamadas siguientes deben seguir devolviendo `false` hasta `Reset()`.

## Conclusión
La implementación muestra una lista enlazada genérica y un enumerador explícito compatible con los contratos de .NET. La interfaz permite observar la relación entre los controles y los objetos almacenados en la colección.

## Estado de verificación
El código se ha revisado estáticamente, pero la compilación y ejecución deben confirmarse mediante GitHub Actions en Windows con .NET 8. No se debe considerar la práctica validada hasta que el workflow termine correctamente y se contraste con el enunciado oficial.
