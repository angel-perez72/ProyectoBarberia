# El Mejor Corte Barbershop

## Descripción del proyecto

El Mejor Corte Barbershop es una aplicación de consola hecha en C# que permite gestionar las funcionalidades básicas de una barbería, facilitando el control de clientes, barberos, citas, servicios realizados, comisiones e ingresos.

## Objetivo

Era desarrollar un sistema sencillo y funcional que permita organizar las operaciones de una barbería, aplicando los conocimientos adquiridos durante la asignatura.

## Funcionalidades

### Gestión de clientes
- Registrar clientes
- Ver clientes registrados
- Buscar clientes por ID
- Actualizar clientes
- Eliminar clientes

### Gestión de barberos
- Registrar barberos
- Eliminar barberos

### Gestión de citas
- Agendar citas
- Consultar citas
- Cancelar citas

### Servicios y finanzas
- Registrar servicios realizados
- Calcular comisiones de los barberos
- Generar reporte de ingresos

## Tecnologías utilizadas

- C#
- .NET
- Visual Studio
- Archivos de texto (.txt)
- Git y GitHub

## Estructura del proyecto

| Archivo | Función |
|---|---|
| Cliente.cs | Representa los datos de los clientes |
| Barbero.cs | Representa los datos de los barberos |
| Cita.cs | Contiene la información de las citas |
| ServicioRealizado.cs | Registra los servicios realizados y sus montos |
| Archivos.cs | Guarda y recupera los datos |
| Program.cs | Contiene el menú principal y la lógica del sistema |

## Conceptos de programación aplicados

- Clases y objetos
- Propiedades
- Métodos
- Listas
- Variables y tipos de datos
- Estructuras condicionales
- Estructuras repetitivas
- Validación de datos
- Manejo de archivos de texto

## Reglas de negocio

- No se permiten clientes ni barberos con ID repetidos
- Para agendar una cita, el cliente y el barbero deben estar registrados
- Un barbero no puede tener dos citas pendientes en la misma fecha y hora
- Solo se pueden registrar servicios de citas pendientes
- El monto de un servicio debe ser mayor que cero
- La comisión del barbero corresponde al 40 % de los servicios realizados
- El teléfono del cliente es opcional

## Almacenamiento de datos

El programa utiliza listas para manejar la información durante su ejecución y archivos de texto para conservar los datos después de cerrarlo.

La clase Archivos.cs se encarga de crear la carpeta de almacenamiento, guardar los cambios y recuperar los datos al iniciar el programa.

Los archivos de datos se excluyen del repositorio mediante .gitignore para evitar que se mezclen los datos de prueba de los integrantes.

## Cómo ejecutar el proyecto

1. Clonar o descargar el repositorio
2. Abrir el proyecto en Visual Studio
3. Ejecutar la aplicación
4. Seleccionar la opción deseada del menú principal

No requiere instalar ni configurar una base de datos externa.

## Metodología de trabajo

Durante el desarrollo utilizamos Git y GitHub para trabajar de manera colaborativa y organizada.

Creamos ramas por funcionalidad, realizamos commits descriptivos e integramos los cambios a la rama master mediante Pull Requests.

## Integrantes

- Juan Alexander Pérez
- Jacqueline Moreta
- Delianny Vicioso
