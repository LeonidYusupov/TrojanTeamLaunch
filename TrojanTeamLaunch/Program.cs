namespace TrojanTeamLaunch
{
    internal static class Program
    {

        private static DBWorker worker = new DBWorker("C:\\Users\\user\\source\\repos\\TrojanTeamLaunch\\MyDB.db");
        private static main_mainForm mainForm = new main_mainForm();
        private static win_authIcon authForm = new win_authIcon(mainForm, worker);
        //private static win_launchIcon launForm = new win_launchIcon(); 

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            authForm.Show();

            Application.Run(mainForm);
        }
    }
}