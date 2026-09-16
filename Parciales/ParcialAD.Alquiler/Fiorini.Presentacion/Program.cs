namespace Fiorini.Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  Punto de entrada de la aplicación de escritorio.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormListado());
        }
    }
}
