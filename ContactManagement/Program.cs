namespace ContactManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ContactForm contactForm = new();

            ContactDetailsForm contactDetailForm = new(contactForm);

            // Subscribe to ValueChanged in main contact form
            contactForm.ValueChanged += value =>
            {
                // Show contact Detail form when the event occurs
                contactDetailForm.ShowDialog();
            };

            // by default show contact form
            Application.Run(contactForm);
        }
    }
}