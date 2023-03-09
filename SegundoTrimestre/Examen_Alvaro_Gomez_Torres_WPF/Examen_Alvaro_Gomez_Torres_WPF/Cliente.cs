namespace Examen_Alvaro_Gomez_Torres_WPF
{
    /// <summary>
    /// Clase cliente que representa un cliente
    /// </summary>
    public class Cliente
    {
        /// <value>Propiedad nombre que es el nombre de un cliente</value>
        private string nombre;
        /// <value>Propiedad dni que es el dni de un cliente</value>
        private string dni;
        /// <value>Propiedad saldo que es el saldo de un cliente en su cuenta</value>
        private int saldo;

        /// <summary>
        /// Constructor vacio de la clase,
        /// por que se puede crear un cliente sin
        /// parametros
        /// </summary>
        public Cliente()
        {
        }

        /// <summary>
        /// Constructor de la clase que crea un cliente
        /// con los siguientees datos
        /// </summary>
        /// <param name="nombre">El nombre de ese cliente</param>
        /// <param name="dni">El dni de ese cliente</param>
        /// <param name="saldo">El saldo inicial que tendra ese cliente</param>
        public Cliente(string nombre, string dni, int saldo)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.saldo = saldo;
        }

        /// <summary>
        /// Devuelve el nombre de un cliente
        /// </summary>
        /// <returns>Devuelve el nombre de un cliente en formato string</returns>
        public string dameNombre()
        {
            return nombre;
        }

        /// <summary>
        /// Getter y setter de Nombre,
        /// Tambien cambia el nombre a un cliente.
        /// </summary>
        /// <returns>Devuelve el nombre de un cliente</returns>
        public string Nombre { get; set; }

        /// <summary>
        /// Getter y setter de Dni,
        /// Tambien cambia el dni a un cliente.
        /// </summary>
        /// <returns>Devuelve el dni de un cliente</returns>
        public string Dni { get; set; }

        /// <summary>
        /// Getter y setter de saldo,
        /// Tambien cambia el saldo a un cliente.
        /// </summary>
        /// <returns>Devuelve el saldo de un cliente</returns>
        public int Saldo { get; set; }
    }
}
