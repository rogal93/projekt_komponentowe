namespace Czat.HostWS
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.czatServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.czatServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // czatServiceProcessInstaller
            // 
            this.czatServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.czatServiceProcessInstaller.Password = null;
            this.czatServiceProcessInstaller.Username = null;
            // 
            // czatServiceInstaller
            // 
            this.czatServiceInstaller.DisplayName = "Usługa Komunikatora";
            this.czatServiceInstaller.ServiceName = "czatUsluga";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.czatServiceProcessInstaller,
            this.czatServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller czatServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller czatServiceInstaller;
    }
}