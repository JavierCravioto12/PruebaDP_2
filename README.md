Prueba_Distribuidores

Para el montado de la Base de Datos dejo el Script en esta misma carpeta llamado "Script Prueba"

La conexión a la Base de Datos y su manejador se realizó en C# en un proyecto llamado ConexionBD_Nueva

-------------------------------------------------------------
BASE DE DATOS
-------------------------------------------------------------

La base de datos consta de 3 tablas llamadas persons, addresses y distributors. Así como 2 Stored Procedures llamados PROC_AGREGARDISTRIBUIDOR y SP_BuscarDistribuidor

Las tablas cuentan con el ID de distribuidor numérico.

En cuanto al Stored llamado PROC_AGREGARDISTRIBUIDOR cuenta con un ID autoincrementable el cual hace una consulta tomando el ultimo ID registrado de la tabla persons y le suma 1 para obtener el nuevo ID a registrar, este registra todos los datos necesarios en las 3 tablas.

Y cuenta también con el Stored llamado SP_BuscarDistribuidor (El cual pudo ser registrado como una vista, ya que realiza una función de consulta unicamente).
Hace una consulta por medio del ID de persons,  de la tabla persons y la tabla addresses uniendolas por el mismo ID.



----------------------------------------------------------------
Código 
----------------------------------------------------------------

El código cuenta con el controlador de la base de programado en C# en cual está en Form1.cs creando las funciones de AbrirConexion() y CerrarConexion() (Aunque este ultimo no sea usado precisamente)

Está la función de RegistrarDistribuidores() la cual realiza la consulta del PROC_AGREGARDISTRIBUIDOR
Y también está la función ConsultaDistribuidores() La cual realiza la consulta con el SP_BuscarDistribuidor.

En la parte visual está el Form de Menu.vb en el cual se puede seleccionar entre los dos siguientes Form el cual guía a RegistroDistribuidores.vb o ConsultaDistribuidores.vb

En el registro de distribuidores se agregan todos los datos necesarios para llenar en la base de datos, cuenta con las funciones de LimpiarControles el cual limpia todos los TextBox

También realiza una validación para asegurarse que los campos de Nombre y Apellido Paterno no queden vacios, el cual si se dejan vacios lanzara un MessageBox el cual indicará cual de esos dos campos nos faltan y nos llevará automaticamente a él.

El boton Registrar los guarda en la BD realizando la función antes mencionada en el manejador de la Base de Datos llamado RegistrarDistribuidores.



Por otro lado el form de ConsultaDistribuidores al hacer click en consulta Manda a llamar al Form ConsultaID el cual cuenta con un textbox y un botón el cual registra en su txtID el ID capturado el cual guarda su valor y realiza la consulta del manejador llamada ConsultaDistribuidores. Cierra el form ConsultaID y muestra el Datatable generado de la consulta en el grid del form ConsultraDistribuidores
