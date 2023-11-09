# Excercise-006

1. En la primera etapa, se inició la creación del escenario utilizando ProBuilder para construir la base del escenario cuadrado. Luego, se importaron elementos clave, como las paredes y los personajes, desde los paquetes correspondientes, incluyendo el "Sci-fi Styled Modular Pack" y "Sci-fi Warrior PBRHPPolyart". Estos activos contribuyeron a la apariencia y la ambientación del escenario.Además, se importaron o crearon varios scripts esenciales, como Shooter, Lluvia y su generador, Enemy, Enemy Spawner y Enemy Manager. Estos scripts serían cruciales para la jugabilidad del juego, permitiendo el disparo, el comportamiento de los enemigos y la gestión de eventos. Para garantizar una interacción adecuada en el escenario, se agregaron colliders a elementos clave, incluyendo el piso, las paredes, las gotas de lluvia, los enemigos y el jugador. Estos colliders facilitaron la detección de colisiones y el comportamiento adecuado de los objetos en el juego, lo que contribuyó a la experiencia de juego deseada. Con todos estos elementos en su lugar, la primera etapa sentó las bases para el desarrollo del emocionante escenario de juego en Unity.

   ![WhatsApp Image 2023-11-07 at 3 58 29 PM](https://github.com/krivera65/Excercise-006/assets/143332773/a2e49c82-2cce-4458-ba31-e458dccb89ea)
   
2. En la segunda etapa, se agregaron desafíos al juego mediante la colocación estratégica de 4 generadores de enemigos en las esquinas del escenario. Estos generadores serían responsables de introducir enemigos al juego.

3. La tercera etapa se centró en la administración de enemigos. Se creó un administrador de enemigos llamado "EnemyManager," que supervisaría todos los enemigos instanciados por los generadores. Además, se implementó un script "Enemy" que permitía vincular a los enemigos con el administrador y agregarlos a una lista para su gestión.

4. La cuarta etapa se enfocó en la interacción del jugador con las paredes, desarrollando scripts que activaban eventos cuando el jugador disparaba y golpeaba una pared, lo que desencadenaba acciones específicas en el juego.

5. En la quinta etapa, se introdujo un administrador de suelo denominado "FloorManager" para rastrear y permitir la eliminación de los paneles de suelo. Se verificó su funcionamiento al destruir paneles en la función "Update."

6. La sexta etapa estableció una conexión entre los eventos generados por los disparos contra las paredes y la destrucción de paneles de suelo, lo que permitía que las paredes actuaran como disparadores para esta acción.

7. La séptima etapa conectó los eventos generados por las paredes de esquina con la destrucción de todos los paneles de suelo en el escenario, creando un evento significativo en el juego.

8. La octava etapa introdujo un elemento caótico en el juego al agregar lluvia. Se creó un prefabricado de "raindrop" del tamaño de una pelota de playa y se configuraron generadores de lluvia que lanzaban gotas en el escenario. Se establecieron reglas de colisión específicas para las gotas de lluvia, afectando a los enemigos y al jugador de manera particular.

9. En la novena etapa, se mejoraron las acciones controladas por los administradores mediante el uso de UnityEvents, lo que proporcionó una mayor flexibilidad y eficiencia en la gestión de eventos en el juego.

   ![rain demo](https://github.com/krivera65/Excercise-006/assets/143332773/1a9235f4-58e2-4c14-801b-85051e10ac3c)
   ![Pared-Piso 2](https://github.com/krivera65/Excercise-006/assets/143332773/f959afd6-9115-45b7-9eaa-b49111423275)

10. La décima y última etapa se centró en la configuración de escenas de victoria y derrota. Se preparó un objeto "GameMode" que manejaba la transición entre estas escenas, y se definieron condiciones de victoria (eliminación de enemigos y oleadas) y derrota (salud del jugador igual a cero). Además, se implementaron las pantallas de victoria y derrota para una experiencia de juego completa y satisfactoria. Estas diez etapas conformaron un proceso completo para el desarrollo de un escenario de juego interactivo en Unity.

   
