# Aplicación de principios y arquitecturas de sistemas hipermedia: Enemy Follow
Link del video en loom: https://www.loom.com/share/4247bb3b8931451f86eee3f4134962eb?sid=c7eef5bd-6eee-478e-8d0e-8610ca5762e6
Por: Joe Cordero
Este proyecto de Unity demuestra cómo un enemigo puede seguir al jugador y realizar las siguientes funcionalidades:

## Funcionalidades Implementadas

### Persecución del Jugador

- **Sistema de Navegación (NavMesh):** El enemigo utiliza el sistema de navegación de Unity (NavMesh) para navegar por el escenario y seguir al jugador de manera inteligente y eficiente.

- **Configuración Flexible:** Es posible ajustar parámetros como la velocidad de persecución, la distancia de seguimiento y el radio de detección en el inspector de Unity.

### Disparo de Balas

- **Disparo Preciso:** El enemigo tiene la capacidad de disparar balas hacia el jugador.

- **Configuración del Disparo:** Es posible personalizar la frecuencia de disparo, la velocidad de las balas, la cantidad de balas disparadas en cada ráfaga y otros parámetros a través del inspector.

- **Precisión del Disparo:** Las balas son disparadas con precisión hacia la posición actual del jugador.

### Reducción de la Vida del Jugador

- **Impacto en la Vida del Jugador:** Cuando una bala del enemigo colisiona con el jugador, la salud del jugador se reduce en una cantidad específica (en este caso, 10 unidades).

- **Actualización de la Barra de Salud:** La barra de salud del jugador se actualiza en tiempo real para reflejar la reducción de su vida.

- **Detección de Game Over:** Si la salud del jugador llega a cero o menos, se activa una función de "Game Over" que nos muestra la pantalla de fin del juego.

