# :computer: TA30 - Patrón MVC

## :page_with_curl: Ejercicio1 - Aplicación de Gestión de Clientes

Este es un proyecto de ejemplo que muestra una aplicación de gestión de clientes utilizando el patrón MVC (Modelo-Vista-Controlador) en C# y Windows Forms.

## :clipboard: Contenido

- [Descripción](#descripción)
- [Requisitos](#requisitos)
- [Instrucciones](#instrucciones)
- [Estructura del Código](#estructura-del-código)
- [Uso](#uso)
- [Créditos](#créditos)

## :page_facing_up: Descripción

Este proyecto consiste en una aplicación de escritorio que permite gestionar una lista de clientes. La aplicación permite crear, listar, actualizar y eliminar clientes. Está implementada siguiendo el patrón de diseño MVC para separar la lógica de negocio, la presentación y el control.

## :pushpin: Requisitos

- Microsoft Visual Studio (preferiblemente 2019 o superior)
- Conocimientos básicos de C# y Windows Forms

## :file_folder: Estructura del Código

Ejercicio1/
├── Controllers/
│ ├── ClienteController.cs
├── Models/
│ ├── Cliente.cs
├── Views/
│ ├── CreateView.cs
│ ├── DeleteView.cs
│ ├── UpdateView.cs
│ └── Form1.cs
├── Program.cs
└── README.md


## :memo: Instrucciones

1. Clona este repositorio o descarga el código fuente.
2. Abre el proyecto en Microsoft Visual Studio.
3. Compila y ejecuta el proyecto.

## :file_folder: Estructura del Código

El código está organizado en varias clases y vistas que siguen el patrón MVC:

- **Model**: La clase `Cliente` representa la entidad de cliente con sus atributos.
- **Controller**: La clase `ClienteController` maneja la lógica de negocio y la interacción entre las vistas y el modelo.
- **Views**: Contiene las vistas de la aplicación.
  - `CreateView`: Vista para crear un nuevo cliente.
  - `UpdateView`: Vista para actualizar un cliente existente.
  - `DeleteView`: Vista para eliminar un cliente.
  - `Form1`: Vista principal que muestra la lista de clientes y opciones de gestión.

## :rocket: Uso

1. Ejecuta la aplicación.
2. En la vista principal, verás una lista de clientes si existen.
3. Utiliza los botones "Crear", "Actualizar" y "Eliminar" para interactuar con los clientes.
4. También puedes utilizar el menú en la parte superior para realizar las mismas acciones.

## :clap: Créditos

Este proyecto fue desarrollado por [Tu Nombre]. Se basa en conceptos de programación en C# y patrones de diseño MVC.

---

# :computer: TA30 - Patrón MVC

## :page_with_curl: Ejercicio2 - Aplicación de Gestión de Clientes y Videos

Este es un proyecto de ejemplo que muestra una aplicación de gestión de clientes y videos utilizando el patrón MVC (Modelo-Vista-Controlador) en C# y Windows Forms.

## :pushpin: Requisitos

- Microsoft Visual Studio (preferiblemente 2019 o superior)
- Conocimientos básicos de C# y Windows Forms

## :file_folder: Estructura del Código

Ejercicio2/
├── Controllers/
│ ├── ClienteController.cs
│ └── VideoController.cs
├── Models/
│ ├── Cliente.cs
│ └── Video.cs
├── Views/
│ ├── CreateClienteView.cs
│ ├── CreateVideoView.cs
│ ├── DeleteClienteView.cs
│ ├── DeleteVideoView.cs
│ ├── UpdateClienteView.cs
│ ├── UpdateVideoView.cs
│ └── Form1.cs
├── Program.cs
└── README.md


## :memo: Instrucciones

1. Clona este repositorio o descarga el código fuente.
2. Abre el proyecto en Microsoft Visual Studio.
3. Compila y ejecuta el proyecto.

## :rocket: Uso

1. Ejecuta la aplicación.
2. En la vista principal, verás una lista de clientes y videos si existen.
3. Utiliza los botones "Crear", "Leer", "Actualizar" y "Eliminar" para interactuar con los clientes y videos.
4. También puedes utilizar el menú en la parte superior para realizar las mismas acciones.
