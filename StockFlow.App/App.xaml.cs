
using System;
using System.IO;
using System.Windows;

namespace StockFlow.App;

public partial class App : Application
{
    // Gestionnaire global des exceptions non gérées
    /*protected override void OnStartup(
        StartupEventArgs e)
    {
        AppDomain.CurrentDomain.UnhandledException +=
            (sender, args) =>
            {
                string error = args.ExceptionObject.ToString()
                    ?? "Erreur inconnue";

                File.WriteAllText(
                    Path.Combine(
                        Path.GetTempPath(),
                        "StockFlow-error.txt"),
                    error
                );

                MessageBox.Show(
                    error,
                    "Erreur StockFlow",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
            };

        base.OnStartup(e);
    }*/
}
