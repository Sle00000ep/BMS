namespace LibrarySystem
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
            FrmLog frmLog = new FrmLog();
            if (frmLog.ShowDialog() == DialogResult.OK)
            {
                if (frmLog.mode == 1)
                {
                    Application.Run(new FrmAdminister());
                }
                else
                {
                    Application.Run(new FrmUser());
                }
            }
            else
                Application.Exit();
        }
    }
}