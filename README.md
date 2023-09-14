# Thread ATM Example
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.txt)
## Table of Contents
- [Technical Background](#technical-background)
- [Explanation](#explanation)
- [Possible Uses](#possible-uses)
- [License](#license)

---

## Technical Background

This console application serves as an example of working with threads in .NET Core. Threads are fundamental to concurrent programming, allowing multiple tasks to run concurrently, improving program performance, and enabling efficient use of system resources.

In this example, we simulate ATM transactions involving a bank account. Threads are used to withdraw random amounts of money from the account while ensuring thread safety using locks.

---

## Explanation

### Creating Threads
- We use the `System.Threading.Thread` class to create and manage threads.
- Threads are created and started using the `Start()` method.

### Simulating ATM Transactions
- Each thread represents an ATM transaction.
- Transactions involve withdrawing random amounts of money between $10 and $100.
- We use the `Random` class to generate random amounts.

### Thread Safety
- To prevent data corruption and collisions between threads, we use locks (`lock` statement).
- Locks ensure that only one thread can access the account balance at a time.

---

## Possible Uses

This example demonstrates the basics of working with threads in .NET Core, which can be applied to various scenarios, including but not limited to:
- Multithreaded data processing.
- Parallelizing CPU-bound or I/O-bound tasks.
- Building responsive and scalable applications.

Understanding thread safety and synchronization is crucial when dealing with concurrent access to shared resources, such as databases, files, or network connections.

---

## License

This project is open-source and is provided under the terms of the [LICENSE.txt](LICENSE.txt) file.

---
**Español:**

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.txt)

# Ejemplo de Cajero Automático con Hilos

## Índice
- [Antecedentes Técnicos](#antecedentes-técnicos)
- [Explicación](#explicación)
- [Posibles Usos](#posibles-usos)
- [Licencia](#licencia)

---

## Antecedentes Técnicos

Esta aplicación de consola sirve como ejemplo de cómo trabajar con hilos en .NET Core. Los hilos son fundamentales para la programación concurrente, permitiendo que múltiples tareas se ejecuten simultáneamente, mejorando el rendimiento del programa y permitiendo el uso eficiente de los recursos del sistema.

En este ejemplo, simulamos transacciones de cajero automático que involucran una cuenta bancaria. Los hilos se utilizan para retirar cantidades aleatorias de dinero de la cuenta, asegurando la seguridad de los hilos mediante bloqueos.

---

## Explicación

### Creación de Hilos
- Utilizamos la clase `System.Threading.Thread` para crear y administrar hilos.
- Los hilos se crean y se inician con el método `Start()`.

### Simulación de Transacciones de Cajero Automático
- Cada hilo representa una transacción de cajero automático.
- Las transacciones implican retirar cantidades aleatorias de dinero entre $10 y $100.
- Utilizamos la clase `Random` para generar cantidades aleatorias.

### Seguridad de Hilos
- Para evitar la corrupción de datos y colisiones entre hilos, utilizamos bloqueos (instrucción `lock`).
- Los bloqueos aseguran que solo un hilo pueda acceder al saldo de la cuenta a la vez.

---

## Posibles Usos

Este ejemplo demuestra los conceptos básicos de trabajar con hilos en .NET Core, que se pueden aplicar en varios escenarios, incluyendo, pero no limitándose a:
- Procesamiento de datos multihilo.
- Paralelización de tareas intensivas en CPU o relacionadas con E/S.
- Construcción de aplicaciones responsivas y escalables.

Comprender la seguridad de hilos y la sincronización es crucial al tratar con el acceso concurrente a recursos compartidos, como bases de datos, archivos o conexiones de red.

---

## Licencia

Este proyecto es de código abierto y se proporciona bajo los términos del archivo [LICENSE.txt](LICENSE.txt).

---
**Français:**

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.txt)

# Exemple de Distributeur Automatique de Billets (ATM) avec Threads

## Table des matières
- [Contexte technique](#contexte-technique)
- [Explication](#explication)
- [Utilisations possibles](#utilisations-possibles)
- [Licence](#licence)

---

## Contexte technique

Cette application console sert d'exemple de travail avec les threads dans .NET Core. Les threads sont fondamentaux pour la programmation concurrente, permettant l'exécution simultanée de plusieurs tâches, améliorant les performances du programme et permettant une utilisation efficace des ressources système.

Dans cet exemple, nous simulons des transactions de distributeur automatique de billets (ATM) impliquant un compte bancaire. Les threads sont utilisés pour retirer des montants aléatoires d'argent du compte, tout en assurant la sécurité des threads à l'aide de verrous.

---

## Explication

### Création de Threads
- Nous utilisons la classe `System.Threading.Thread` pour créer et gérer les threads.
- Les threads sont créés et démarrés à l'aide de la méthode `Start()`.

### Simulation de Transactions ATM
- Chaque thread représente une transaction ATM.
- Les transactions consistent à retirer des montants aléatoires d'argent entre 10 $ et 100 $.
- Nous utilisons la classe `Random` pour générer des montants aléatoires.

### Sécurité des Threads
- Pour éviter la corruption des données et les collisions entre les threads, nous utilisons des verrous (instruction `lock`).
- Les verrous garantissent qu'un seul thread peut accéder au solde du compte à la fois.

---

## Utilisations possibles

Cet exemple illustre les bases du travail avec les threads dans .NET Core, qui peuvent être appliquées à divers scénarios, notamment, mais sans s'y limiter :
- Le traitement des données en mode multithread.
- La parallélisation des tâches intensives en CPU ou liées à l'E/S.
- La création d'applications réactives et évolutives.

La compréhension de la sécurité des threads et de la synchronisation est essentielle lorsque l'on traite un accès concurrent à des ressources partagées, telles que les bases de données, les fichiers ou les connexions réseau.

---

## Licence

Ce projet est open source et est fourni sous les termes du fichier [LICENSE.txt](LICENSE.txt).

