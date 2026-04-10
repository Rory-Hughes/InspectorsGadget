namespace InspectorsGadget
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Show the startup/welcome screen before opening MainForm.
            // If the user closes it without confirming, the application exits cleanly.
            using var startup = new StartupForm2();
            if (startup.ShowDialog() != DialogResult.OK)
                return;

            Application.Run(new MainForm(startup.SelectedFilePath));
        }
    }
}