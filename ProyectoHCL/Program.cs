using ProyectoHCL.Formularios;

namespace ProyectoHCL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PermisosRoLes());
            // Application.Run(new FORMULARIO());
            //  Application.Run(new RegistrarUsuario());
            //Application.Run(new Dashboard());
            //Application.Run(new CtrlObjetos());
<<<<<<< HEAD
            Application.Run(new CtrlClientes());
            
=======
            //Application.Run(new CtrlObjetos());
            //Application.Run(new Cliente());
>>>>>>> fa4ca14db8c55c9cb551675c6164e4c288bceec0
        }
    }
}