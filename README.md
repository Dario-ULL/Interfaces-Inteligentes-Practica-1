# Práctica 1: Introducción y Primeros Pasos
**Asignatura:** Interfaces Inteligentes  
**Universidad:** Universidad de La Laguna (ULL)  
**Autor:** Darío ([@Dario-ULL](https://github.com/Dario-ULL))

---

## Estructura del Repositorio
* **`Scripts/`**: Contiene el código fuente y scripts desarrollados para la práctica.
* **`Gif/`**: Contiene las capturas y animaciones que demuestran el funcionamiento de cada apartado.

---

## Demostraciones y Ejercicios

### Demostración General
Demostración en video/animación del funcionamiento global de la escena o proyecto:

<p align="center">
  <img src="Gif/Grabación%202026-10-01%20180533.gif" alt="Demostración práctica" width="700">
</p>

---

### Ejercicio 2
Descripción breve de lo realizado en el Ejercicio 2.

<p align="center">
  <img src="Gif/Ejercicio2.png" alt="Captura Ejercicio 2" width="600">
</p>

---

### Ejercicio 3
Descripción breve de lo realizado en el Ejercicio 3.

<p align="center">
  <img src="Gif/Ejercicio3.png" alt="Captura Ejercicio 3" width="600">
</p>

---

### Ejercicio 4
Descripción breve de lo realizado en el Ejercicio 4.

<p align="center">
  <img src="Gif/Ejercicio4.png" alt="Captura Ejercicio 4" width="600">
</p>


# Práctica 1 Parte 2: Introducción y Primeros Pasos

### Ejercicio 5
Desplazamiento relativo de tres objetos en la escena al pulsar la barra espaciadora. Se implementó un vector público de desplazamiento configurable desde el Inspector para cada objeto, controlando la activación mediante `Input.GetAxis("Jump")` y alternando entre la posición inicial y la posición modificada.

<p align="center">
  <img src="Gif%20Segunda%20Parte/Ejercicio5.gif" alt="Demostración Ejercicio 5" width="600">
</p>

---

### Ejercicio 6
Configuración de una variable pública de velocidad en el Inspector para el cubo. Al pulsar las teclas de flecha (arriba, abajo, izquierda, derecha), se muestra por consola el nombre de la tecla accionada junto al resultado de multiplicar dicha velocidad por los valores de los ejes `Vertical` y `Horizontal`.

<p align="center">
  <img src="Gif%20Segunda%20Parte/Ejercicio6.gif" alt="Captura Ejercicio 6" width="600">
</p>

---

### Ejercicio 7
Mapeo personalizado de controles en el Input Manager de Unity, redefiniendo la acción de disparo (`Fire1`) para asociarla a la tecla `H` y ejecutando la rutina de disparo al detectarse la pulsación con `Input.GetButtonDown("Fire1")`.

<p align="center">
  <img src="Gif%20Segunda%20Parte/Ejercicio7.gif" alt="Captura Ejercicio 7" width="600">
</p>

---

### Ejercicio 8
Traslación del cubo en cada iteración mediante `Transform.Translate()`, proporcional al vector de dirección `moveDirection` y al parámetro `speed`. Se analizaron diferentes supuestos en el informe: duplicar dirección o velocidad, valores de velocidad menores a 1, variar la cota de altura $Y$, y alternar entre los sistemas de coordenadas local (`Space.Self`) y mundial (`Space.World`).

<p align="center">
  <img src="Gif%20Segunda%20Parte/Ejercicio8.gif" alt="Demostración Ejercicio 8" width="600">
</p>

---

### Ejercicio 9
Control independiente de dos objetos: el cubo se desplaza en los ejes horizontal y vertical mediante las flechas de dirección a velocidad constante, mientras que la esfera se traslada de manera simultánea utilizando las teclas `W`, `A`, `S` y `D`.

<p align="center">
  <img src="Gif%20Segunda%20Parte/Ejercicio9.gif" alt="Demostración Ejercicio 9" width="600">
</p>

---

### Ejercicio 10
Adaptación del movimiento del ejercicio anterior incorporando `Time.deltaTime`. Al escalar el desplazamiento por el tiempo transcurrido entre frames, se independiza la velocidad de traslación de la tasa de refresco (FPS) del dispositivo.

<p align="center">
  <img src="Gif%20Segunda%20Parte/Ejercicio10.gif" alt="Demostración Ejercicio 10" width="600">
</p>

---

### Ejercicio 11
Movimiento guiado del cubo hacia la esfera. Se calculó el vector de dirección entre ambos objetos, anulando la variación de altura en el eje $Y$ y aplicando normalización (`normalized`) para garantizar un avance constante y regular independientemente de la distancia entre ellos.

<p align="center">
  <img src="Gif%20Segunda%20Parte/Ejercicio11.gif" alt="Demostración Ejercicio 11" width="600">
</p>

---

### Ejercicio 12
Orientación continua del cubo encarando la esfera mediante `Transform.LookAt()`. El cubo rota sobre su eje vertical orientando su eje $Z$ frontal positivo hacia la posición de la esfera mientras avanza en su sistema local hacia ella conforme la esfera es movida con las teclas `W`, `A`, `S` y `D`.

<p align="center">
  <img src="Gif%20Segunda%20Parte/Ejercicio12.gif" alt="Demostración Ejercicio 12" width="600">
</p>

---

### Ejercicio 13
Control de avance y rotación combinados: se emplea el eje `Horizontal` para rotar el objeto sobre su eje vertical (`transform.Rotate`) y se traslada continuamente en la dirección hacia adelante mediante `transform.forward`. Se incluye `Debug.DrawRay` para trazar el vector de dirección frontal de forma visual en la ventana Scene.

<p align="center">
  <img src="Gif%20Segunda%20Parte/Ejercicio13.gif" alt="Demostración Ejercicio 13" width="600">
</p>
