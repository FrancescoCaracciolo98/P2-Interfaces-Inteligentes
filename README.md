# Práctica 2 - Introducción a los scripts en Unity
* **Asignatura:** Interfaces Inteligentes
* **Autor:** Francesco Caracciolo
* **Correo:** alu0101526621@ull.edu.es

## Parte 1
![Screenshot (5409)](https://user-images.githubusercontent.com/93151367/139236571-fd0dc10b-0cf4-4da1-b7a4-d5ed0c9b4ad3.png)


## Resolución
Introducimos los objetos 3D en la escena sobre la que vamos a testear, para poder introducir un plano que será nuestro suelo, una esfera y un cubo.

![image](https://user-images.githubusercontent.com/93151367/139236990-b7e01ef6-8c96-4c46-b4d5-1f603b7ddef8.png)

Ahora para realizar las pruebas de física colocamos los objetos en una posición elevada.

![image](https://user-images.githubusercontent.com/93151367/139237280-ca0cbf43-5c5f-45bd-8894-ab66471ba27b.png)


**a)** Ningún objeto es físico, lo que pasa es que los objetos permanecen en la misma posición.

**b)** Ahora que la esfera tiene física, vemos que de hecho la esfera cae. Para agregar física, luego la gravedad, uso el componente rigidbody.

![ezgif com-gif-maker](https://user-images.githubusercontent.com/93151367/139238640-db3f534d-ec5c-4322-b2e5-3d9a535817ad.gif)

**c)** Ahora, tanto los objetos de esfera como los de cubo tienen física, ambos caen.

![ezgif com-gif-maker (1)](https://user-images.githubusercontent.com/93151367/139239040-b6060512-6e34-422d-987a-1900daf157d2.gif)

**d)** Ahora la esfera tiene 10 veces la masa del cubo.

La masa de un objeto no afecta la velocidad a la que cae debido a la gravedad. Todos los objetos caen a la misma velocidad independientemente de su masa.

Para ver la diferencia, tal vez hagamos que los objetos reboten y veamos qué sucede. Para hacer esto creo un nuevo physics material.
![image](https://user-images.githubusercontent.com/93151367/139239940-d3387260-f4ef-44f7-9f32-557086806dc6.png)

Además en este caso no hay diferencias.

![ezgif com-gif-maker (2)](https://user-images.githubusercontent.com/93151367/139240296-716fdbe4-4823-4fe3-ab70-6609beae8cbe.gif)

**e)** Ahora que el cubo es solo de tipo disparador, no se mueve.

![ezgif com-gif-maker (3)](https://user-images.githubusercontent.com/93151367/139240662-8bf19730-28ba-4929-94d0-5c76bab2af1e.gif)

**f)** Ahora vemos que el cubo cruza el plano sin detenerse.

![ezgif com-gif-maker (4)](https://user-images.githubusercontent.com/93151367/139240889-93960237-5138-42f1-8bf4-babc9c542fc8.gif)

**g)** Para apreciar lo que significa bloquear la rotación del cubo en el plano XZ, giro el plano tanto en la dirección X como en la Z, de esta manera veo cómo el cubo se restringe a medida que cae.

![ezgif com-gif-maker (5)](https://user-images.githubusercontent.com/93151367/139241208-c55f73c5-dc23-4102-ad27-defe7cdc5552.gif)

Veamos cómo la esfera golpea el cubo y cómo este último no puede girar libremente.




## Parte 2
