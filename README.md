# Patrones-de-Dise-o

Este repositorio contiene un proyecto en \*\*C# (.NET)\*\* que implementa diferentes \*\*patrones de diseño\*\*.  

El propósito es mostrar ejemplos prácticos de cómo se aplican en un sistema real y cómo permiten escribir código más flexible y mantenible.



---



\## 🚀 Tecnologías utilizadas

\- Lenguaje: \*\*C#\*\*

\- Framework: \*\*.NET Framework / .NET Core\*\*

\- IDE recomendado: \*\*Visual Studio 2022\*\* o superior



---



\## 📂 Patrones implementados



\### 🔹 Abstract Factory

\*\*¿Qué es?\*\*  

Permite crear familias de objetos relacionados sin especificar sus clases concretas.



\*\*Implementación en el proyecto:\*\*  

Se modelan diferentes tipos de aeronaves:  

\- Aviones y avionetas civiles.  

\- Aviones y avionetas militares.  



Cada “fábrica” se encarga de producir una familia de aeronaves.



---



\### 🔹 Bridge

\*\*¿Qué es?\*\*  

Separa una abstracción de su implementación, permitiendo que ambas evolucionen de manera independiente.



\*\*Implementación en el proyecto:\*\*  

Se modela una jerarquía de dispositivos y controles, donde la lógica del control se desacopla del dispositivo en sí (puede variar sin modificar el resto).



---



\### 🔹 Composite

\*\*¿Qué es?\*\*  

Permite tratar objetos individuales y composiciones de objetos de manera uniforme (árbol jerárquico).



\*\*Implementación en el proyecto:\*\*  

Se construye una jerarquía de componentes que pueden ser simples o compuestos, pero todos responden a las mismas operaciones.



---



\### 🔹 Mediator

\*\*¿Qué es?\*\*  

Define un objeto que encapsula la comunicación entre objetos, reduciendo las dependencias entre ellos.



\*\*Implementación en el proyecto:\*\*  

Se implementa un mediador que coordina la interacción entre diferentes clases sin que estas se conozcan directamente.



---



\### 🔹 Observer

\*\*¿Qué es?\*\*  

Permite que un objeto notifique automáticamente a otros cuando su estado cambia.



\*\*Implementación en el proyecto:\*\*  

Se simula un sistema de suscriptores que reciben notificaciones cuando un objeto observado cambia de estado.



---



\### 🔹 Proxy

\*\*¿Qué es?\*\*  

Proporciona un sustituto o representante de otro objeto para controlar su acceso.



\*\*Implementación en el proyecto:\*\*  

Se crea un proxy que controla el acceso a un recurso costoso o restringido, permitiendo validar o diferir la creación del objeto real.



---



\### 🔹 Visitor

\*\*¿Qué es?\*\*  

Permite definir nuevas operaciones sobre una estructura de objetos sin modificar las clases de dichos objetos.



\*\*Implementación en el proyecto:\*\*  

Se construye una jerarquía de elementos sobre la cual se pueden aplicar diferentes visitantes que definen operaciones externas.



