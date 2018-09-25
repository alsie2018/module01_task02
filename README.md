# Que es 'Diseño de Software'?

El 'Diseño de Software' es el proceso mediante el cual obtenemos un 'Plan de Desarrollo de Software'.

## Que debe tener un Plan de Desarrollo de Software?

Un Plan de Desarrollo de Software es un artefacto compuesto que reune toda la informacion requerida para administrar y desarrollar un producto de software. Al ser compuesto, incluye una extensa lista de artefactos que veremos en otra oportunidad (por la falta de tiempo). Sin embargo, de las lecturas podemos extraer los siguientes:

### Proposito, Alcance y Objetivos.

Todo software creado tiene un proposito, una razon de ser... basicamente su proposito es Ayudar a las Personas. No importa si el software es un servicio o una libreria, ya que esta ayudara a otros desarrolladores con su tarea, y estos a su vez usaran nuestro servicio o libreria para ayudar a otras personas a resolver algun problema particular. Cuando pensamos en el alcance de un proyecto de software debemos limitar el area en el cual ayudaremos a nuestros usuarios finales, por ejemplo si quiero implementar un programa para el control de inventarios, no debo tocar puntos como control de ventas, recursos humanos, distribucion de producto, etc, ya que de ser asi jamas terminaremos de implementar la aplicacion. Es importante tener un objetivo claro, de otra manera el exito no es garantizado. Hace tiempo escuche una charla en la cual mencionaban un experimento interesante, en un salon de clases se pedia a los estudiantes que caminen en varias direcciones dentro del aula sin detenerse. Despues se les pedia que desde donde se encentren caminen hacia la puerta, todos tomaron rutas distintas pero sabian donde tenian que llegar, asi es cuando se tiene un objetivo bien trazado.

### Identificar los features a ser implementados.

Despues de tener una lista inicial de requerimientos, lo importante es ir conociendo la logica del negocio. Para ello es de ayuda tener un documento con la Definicion de terminos y acronimos que seran utilizados durante la vida del producto. El siguiente reto es identificar que requerimientos son los mas importantes, para ello me gusto bastante la tecnica planteada en el capitulo 4 del libro 'Code Simplicity'. Basicamente debemos asegurarnos de dar prioridad a aquellos requerimientos que tengan un mayor valor (que ayuden en un mayor grado a cumplir el objetivo de la aplicacion) y que involucren un menor esfuerzo (la fuerza de trabajo requerida persona/hora).

### Establecer la Metodologia de Desarrollo.

Puede que algunos crean que la mejor opcion es aplicar SCRUM a cualquier proyecto de Software, sin embargo esto depende del tamaño del proyecto y la formalidad con la que quiera ser tratado por el cliente.

### Establecer los Estandares de Desarrollo de Software.

Debemos definir un estilo de programacion basado en valores, principios y practicas con el fin de ser mas productivos y evitar posibles conflictos dentro del equipo de desarrollo. Si alguien quiere hacer algo de una manera y yo de otra, podemos identificar el nivel de nuestro desacuerdo y evitar perder el tiempo. Hace cuatro years esto me hubiese sido bastante util, tuve una acalorada charla con gente de USA que querian escribir codigo JavaScript con un estilo C#, recuerdo que ellos crearon un documento de Code Conventions que no me convencieron del todo y mande un email explicando porque cada una de esas convenciones no me parecia correcta, en algunas se justificaron pero en la mayoria su respuesta fue: Porque asi lo decidimos en el equipo. Esa fue la respuesta mas tonta que escuche en toda mi carrera, los Code Conventions no son validos porque un grupo de 8 personas lo decida, cada lenguage de desarrollo tiene sus convenciones. Pondre algunos links utiles respecto a este punto al final del documento.

### Definir la Arquitectura del Software.

Una vez que nuestro objetivo es claro, tenemos que fijarnos ciertas metas para el diseño: Debe permitirnos escribir software que sea lo mas util posible. Debe continuar siendo lo mas util posible. El diseno debe ser creado de manera que sea mantenible por sus desarrolladores, de manera que cumpla la primer y segunda meta. Cuando el software es dificil de mantener, es dificil hacer que continue ayudando a personas y por lo tanto la vida del producto llega a su fin. Esto no significa que su diseño haya sido del todo malo, simplemente hay consecuencias imprevisibles. 

```
Nosotros no podemos predecir el futuro pero podemos crear un diseño que permita cambios en el futuro.
```

Ahora la pregunta que todos se haran es... como creamos un diseño que permita cambios en el futuro?
Nuestro amigo Kent Beck nos da algunas pautas para poder construir un diseño mantenible, debemos enfocarnos en los Valores (proporcionan motivacion), Principios (ayudan a traducir el motivo en accion) y Patrones (describen que hacer). Para mas detalles vease la seccion inferior.


## Valores.

Existen tres valores que debemos tomar en cuenta para construir software mantenible:

### Comunicacion.
En su obra, Kent Beck menciona un articulo de Donald E. Knuth en el cual se hace enfasis en que un programa deberia poder ser leido al igual que un libro. Cada pedazo de codigo deberia tener un comentario al menos los metodos para saber que parametros espera, y al igual que un escritor los programadores deberian pensar en que otras personas leeran su codigo, por lo cual este deberia tener cierta estructura y explicar en algunos casos el porque ese pedazo de codigo esta alli.

### Simplicidad.
Desde la universidad entendemos que lo deseable es tener una aplicacion con alta cohesion y bajo acoplamiento. Por lo tanto, cuanto menos complejo sea un sistema sera mas facil de leer y comprender.

### Flexibilidad.
Los programas deben ser flexibles, pero solo en la forma en que cambian. Debemos ser cuidadosos al elegir patrones que fomenten la flexibilidad y traigan beneficios inmediatos, ya que podemos incrementar la complejidad en algunos casos.


## Principios.

Los principios pueden proporcionar una explicacion para la motivacion detras de un patron. Las opciones sobre patrones contradictorios a menudo se discuten mejor en terminos de principios en lugar de los detalles de los patrones involucrados. Incluso, los principios nos proporcionan una guia cuando nos encontramos frente a situaciones nuevas. Tenemos la siguiente lista de principios:

### Local Consequences.
Debemos estructurar el codigo de manera que los cambios tengan consecuencias locales. Si un cambio aqui puede causar un problema alla, entonces el costo del cambio aumenta drasticamente. Los modulos con bajo acoplamiento se pueden entender mas facilmente sin tener que armar todos los pedazos y tener una comprension del todo. Esto tambien va de la mano con el primer valor (comunicacion), dado que los nuevos desarrolladores podran dedicar mas tiempo en escribir nuevo codigo en lugar de estar leyendo y comprendiendo una montaña de codigo.

### Minimize Repetition.
Duplicar codigo no es del todo malo, sin embargo incrementa los costos de cambio. Por ejemplo si tenemos el mismo pedazo de codigo en 10 lugares distintos, y el dia de mañana tenemos que cambiar esa logica, tendremos que cambiar en los 10 lugares. Ahora bien, si olvidamos cambiar uno solo de ellos ya habremos dado lugar a la aparicion de uno o mas bugs.

### Logic and Data Together.
Es deseable mantener los cambios de logica y data juntos, de manera que las consecuencias de sus cambios se mantienen locales. Pueden darse casos en los que separemos la escritura en bases de datos de los objetos manejados en un determinado tiempo, en esos casos podria darse una discrepancia de datos si es que no son manejados juntos o bien si no se sincronizan de manera correcta.

### Symmetry.
Las simetrias abundan en las aplicaciones, por ejemplo si tienes un metodo add() tendras un metodo remove(), esto ayuda a los nuevos programadores a leer y entender mas rapido el codigo. Por ejemplo si tenemos un modulo de gestion de usuarios, si vemos un AddUser, entendemos que por algun lado existira un RemoveUser().

### Declarative Expression.
De acuerdo al lenguage de desarrollo algunas veces tendremos la opcion de programar con un estilo imperativo o con uno declarativo. El estilo imperativo es poderoso, e incluso puede recibir multiples parametros, sin embargo requiere que el lector siga paso a paso el hilo de ejecucion, por otro lado el estilo declarativo hace que el codigo sea mas facil de leer.

### Rate of Change.
De acuerdo a este principio debemos poner la logica o los datos que cambian al mismo ritmo juntos y separar la logica o datos que cambian a diferentes velocidades. Estas tasas de cambio son una forma de simetría temporal. Por ejemplo, si el calculo de una metrica cambia cada year, la logica para calcular la metrica deberia separarse de manera que solo modifiquemos los parametros de entrada.