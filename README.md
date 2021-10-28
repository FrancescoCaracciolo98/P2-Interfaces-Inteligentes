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
![Screenshot (5411)](https://user-images.githubusercontent.com/93151367/139276195-16a3633f-606e-46a3-b79b-1b8f7f31ebf3.png)

Vamos a hacer un jugador controlable. Usamos el mismo suelo y el mismo cubo.

![image](https://user-images.githubusercontent.com/93151367/139276574-6d4c89fe-a6e8-45eb-a4ff-a06bdd7be587.png)

**a)**	hacemos que el Player sea utilizable. Voy a crear una carpeta que llamaré scripts donde insertaré el código en C#.

![image](https://user-images.githubusercontent.com/93151367/139276826-358cc4ff-0ff4-487d-8d46-06b786483ef9.png)

He insertado líneas de código que me permiten mover mi Jugador en el plano. Usé una variable horizontal que equiparo a la función Input.GetAxis ("Horizontal") de Unity que nos da -1 si el usuario está presionando el botón A o la flecha izquierda, y 1 si el usuario está presionando la D o la flecha derecha ; hacemos lo mismo con una variable vertical que es igual a Input.GetAxis ("Vertical"), pero en este caso Unity me pregunta 1 si el usuario presiona la W o la flecha hacia arriba y -1 si presiono la S o la flecha hacia abajo. Luego podemos acceder al componente transform de este objeto que contiene la posición y escribir transform.traslate para mover el objeto, ya que estamos en un espacio 3D tengo que usar un vector de 3 dimensiones, en el cual a x voy a asignar el variable horizontal, ay nada porque no queremos que el objeto suba o baje, ya z le asignamos la variable vertical.
Obviamente tengo que agregar este script como un componente al objeto que quiero controlar, en mi caso el cubo.

![ezgif com-gif-maker (6)](https://user-images.githubusercontent.com/93151367/139279640-b263abee-e41c-4d7a-a254-78a541f52dd6.gif)

**b)** Ahora creemos una variable que me permita controlar la velocidad del objeto porque de hecho en este momento es demasiado alta, como hemos visto. Creo una variable de velocidad pública y la multiplico a nuestro vector tridimensional para cambiar la velocidad.

![image](https://user-images.githubusercontent.com/93151367/139279840-97db4d62-32bf-46b6-85c6-4363a8373321.png)

![image](https://user-images.githubusercontent.com/93151367/139279947-b6599d37-e8c9-4518-8d39-8242c31b3044.png)

Ahora vemos que ha aparecido la caja de velocidad. Intentemos ponerlo en 2.

![ezgif com-gif-maker (7)](https://user-images.githubusercontent.com/93151367/139280319-205fec47-81fb-449b-b429-c52bb03aa623.gif)

Ahora que el objeto es muy lento, establezcamos la velocidad en 10.

![ezgif com-gif-maker (8)](https://user-images.githubusercontent.com/93151367/139280636-dc7c48a3-7606-4ec7-b439-ddfac787d2df.gif)

Vemos que ahora la velocidad ha aumentado.


**c)** Hasta ahora para mover al jugador se le ha permitido usar tanto las flechas del teclado como los botones AWSD, ahora permitimos usar solo un conjunto de movimientos, yo elijo el conjunto AWSD, ahora tengo que modificar el script que se convierte en:

![image](https://user-images.githubusercontent.com/93151367/139282313-5341144c-b122-4a67-afa6-57846037e53e.png)

![ezgif com-gif-maker (9)](https://user-images.githubusercontent.com/93151367/139282490-ef90978a-a79f-42fe-b07d-21803de8ce71.gif)


**d)** Ahora agreguemos la capacidad de moverse en el eje vertical, lo hacemos introduciendo la capacidad de saltar a nuestro jugador. Creo una variable privada de tipo rigidbody a la que llamo Physics, después de usar la función GetComponent para rigidbody.

![image](https://user-images.githubusercontent.com/93151367/139282942-0a77707d-67a0-4752-b6c3-a3809d657e2d.png)

![ezgif com-gif-maker (10)](https://user-images.githubusercontent.com/93151367/139283126-a7d34ec3-dd13-4e9c-b139-6fac86dcfafd.gif)


**extra)** ahora cuidemos la cámara, decido usar cinemachine, una solución de Unity para crear una cámara interactiva en movimiento, de esta manera tendré una cámara muy avanzada sin tener que escribir ninguna línea de código.
Añado el paquete cinemachine.

![image](https://user-images.githubusercontent.com/93151367/139283652-0d9305d4-4c34-47c3-8faa-9111aa1f1a42.png)

Y obligo a la cámara a seguir mi cubo.

![ezgif com-gif-maker (11)](https://user-images.githubusercontent.com/93151367/139283924-6719578c-925e-49b0-a950-c9b3dc974c7f.gif)




## Parte 3


