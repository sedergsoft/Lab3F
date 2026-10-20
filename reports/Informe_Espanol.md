# Informe de laboratorio n.º 3 — MiniList<T>

## Objetivo
Implementar una colección genérica mediante una lista enlazada simple en C# y permitir recorrer sus elementos usando la interfaz estándar de enumeración de .NET.

## Fundamento
Una lista enlazada está formada por nodos. Cada nodo contiene un valor y una referencia al siguiente nodo. A diferencia de un arreglo, sus elementos no necesitan almacenarse en posiciones contiguas de memoria. La clase `MiniList<T>` mantiene referencias al primer y último nodo y un contador de elementos.

## Implementación
- `Append(T item)` agrega un elemento al final y devuelve su índice basado en cero.
- `Count` expone el número de elementos.
- `IEnumerable<T>` permite usar `foreach`.
- El iterador avanza nodo por nodo y conserva el orden de inserción.
- La aplicación Windows Forms permite crear la lista, agregar controles `CheckBox` y comparar el recorrido de controles visuales con el recorrido de la colección.

## Pruebas manuales recomendadas
1. Iniciar la aplicación y seleccionar **Создать список**.
2. Seleccionar **Добавить элемент** varias veces.
3. Ejecutar **Перебор кнопок** y comprobar que el contador coincide con los controles añadidos.
4. Ejecutar **Перебор объектов** y comprobar que el contador coincide con los elementos de la lista.
5. Crear una lista nueva y verificar que la colección vuelve a estar vacía.
6. Intentar agregar un elemento antes de crear la lista y comprobar que la aplicación informa del requisito sin fallar.

## Conclusión
La práctica muestra cómo construir una estructura enlazada genérica y cómo integrar un enumerador con las construcciones habituales de C#. La interfaz facilita observar que los elementos visuales se mantienen también como objetos de la colección.

## Limitación de verificación
Este informe describe la implementación incorporada en el repositorio. La compilación y ejecución deben confirmarse en Windows con .NET 8 y cotejarse con el documento oficial de la asignatura antes de la entrega definitiva.
