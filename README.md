
# Principios SOLID en C# - Ejemplos Prácticos

Este repositorio contiene una solución en C# (`SOLID_En_Ejemplos`) orientada a explicar de forma práctica e intuitiva los **5 Principios SOLID** de diseño de software orientados a objetos.
Sin teorías abstractas que solo impresionan pero no dan síntomas ni soluciones al incumplimiento de los principios.

Cada principio cuenta con una estructura dividida en dos partes:

* **Antes:** Ejemplo de código que incumple o viola el principio.
* **Después:** Refactorización aplicando el principio correctamente.

En cada carpeta se incluye el diagrama de clases correspondiente (`DiagramaClases.jpg`).

## 🛠️ Estructura de la Solución

```
SOLID_En_Ejemplos/
│
├── Dependency Inversion Principle/
│   ├── Antes/
│   └── Despues/
│
├── Interface Segregation Principle/
│   ├── Antes/
│   └── Despues/
│
├── Liskov Substitution Principle/
│   ├── Antes/
│   └── Despues/
│
├── Open-Closed Principle/
│   ├── Antes/
│   └── Despues/
│
├── Single Responsibility Principle/
│   ├── Antes/
│   └── Despues/
│
└── Program.cs
```

---

## 📌 Los 5 Principios SOLID

### 1. Single Responsibility Principle (SRP) - Principio de Responsabilidad Única

> *"Una clase debe tener una, y solo una, razón para cambiar."*

#### ❌ Antes (Incumplimiento)
Una clase asume múltiples responsabilidades a la vez.

![Diagrama SRP - Antes](SOLID_En_Ejemplos/Single%20Responsibility%20Principle/Antes/DiagramaClases.jpg)

#### ✅ Después (Cumplimiento)
Se separan las responsabilidades en distintas clases orientadas a un único propósito.

![Diagrama SRP - Después](SOLID_En_Ejemplos/Single%20Responsibility%20Principle/Despues/DiagramaClases.jpg)

---

### 2. Open-Closed Principle (OCP) - Principio de Abierto/Cerrado

> *"Las entidades de software deben estar abiertas para la extensión, pero cerradas para la modificación."*

#### ❌ Antes (Incumplimiento)
Para agregar nuevos comportamientos o tipos es necesario modificar el código existente. Por ejemplo, si incorporáramos el juego Galaga, tendríamos que modificar la clase Hardware, lo cual viola la abstracción del dominio: en el mundo real, cambiar de juego no implica modificar la consola.

![Diagrama OCP - Antes](SOLID_En_Ejemplos/Open-Closed%20Principle/Antes/DiagramaClases.jpg)

#### ✅ Después (Cumplimiento)
Se utilizan abstracciones que permiten extender la funcionalidad añadiendo nuevas clases sin modificar las existentes.

![Diagrama OCP - Después](SOLID_En_Ejemplos/Open-Closed%20Principle/Despues/DiagramaClases.jpg)

---

### 3. Liskov Substitution Principle (LSP) - Principio de Sustitución de Liskov

> *"Las clases derivadas deben poder sustituir a sus clases base sin alterar el correcto funcionamiento del programa."*

#### ❌ Antes (Incumplimiento)
Una clase derivada no cumple con el contrato de la clase base o interfaz (p. ej., lanzando excepciones no esperadas).

![Diagrama LSP - Antes](SOLID_En_Ejemplos/Liskov%20Substitution%20Principle/Antes/DiagramaClases.jpg)

#### ✅ Después (Cumplimiento)
Se ajusta la jerarquía de herencia o composición para asegurar que cada subtipo respete plenamente el comportamiento esperado.

![Diagrama LSP - Después](SOLID_En_Ejemplos/Liskov%20Substitution%20Principle/Despues/DiagramaClases.jpg)

---

### 4. Interface Segregation Principle (ISP) - Principio de Segregación de Interfaces

> *"Los clientes no deben estar obligados a depender de interfaces que no utilizan."*

#### ❌ Antes (Incumplimiento)
La interfaz `ITrabajador` contiene métodos que no aplican para todos los tipos que la implementan (por ejemplo, obligar a `Robot` a implementar métodos de comer o descansar).

![Diagrama ISP - Antes](SOLID_En_Ejemplos/Interface%20Segregation%20Principle/Antes/DiagramaClases.jpg)

#### ✅ Después (Cumplimiento)
Se segrega la interfaz en contratos más específicos (`ITrabajador`, `INecesidades`), permitiendo que `Humano` implemente ambas y `Robot` solo implemente la que necesita.

![Diagrama ISP - Después](SOLID_En_Ejemplos/Interface%20Segregation%20Principle/Despues/DiagramaClases.jpg)

---

### 5. Dependency Inversion Principle (DIP) - Principio de Inversión de Dependencias

> *"Los módulos de alto nivel no deben depender de módulos de bajo nivel. Ambos deben depender de abstracciones."*

#### ❌ Antes (Incumplimiento)
La clase de alto nivel `Velador` depende directamente de la clase concreta de bajo nivel `LamparaIncandescente`.

![Diagrama DIP - Antes](SOLID_En_Ejemplos/Dependency%20Inversion%20Principle/Antes/DiagramaClases.jpg)

#### ✅ Después (Cumplimiento)
`Velador` depende de la interfaz `ILampara`, lo que permite usar e intercambiar fácilmente distintas implementaciones como `LamparaIncandescente` o `LamparaLed`.

![Diagrama DIP - Después](SOLID_En_Ejemplos/Dependency%20Inversion%20Principle/Despues/DiagramaClases.jpg)

---
