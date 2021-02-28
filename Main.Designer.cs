
namespace Windows10FPS_fix
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.update_registry_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ownrisk = new System.Windows.Forms.CheckBox();
            this.githublinklabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // update_registry_button
            // 
            this.update_registry_button.Location = new System.Drawing.Point(12, 146);
            this.update_registry_button.Name = "update_registry_button";
            this.update_registry_button.Size = new System.Drawing.Size(91, 23);
            this.update_registry_button.TabIndex = 0;
            this.update_registry_button.Text = "Update Registry";
            this.update_registry_button.UseVisualStyleBackColor = true;
            this.update_registry_button.Click += new System.EventHandler(this.update_registry_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // ownrisk
            // 
            this.ownrisk.AutoSize = true;
            this.ownrisk.Location = new System.Drawing.Point(109, 150);
            this.ownrisk.Name = "ownrisk";
            this.ownrisk.Size = new System.Drawing.Size(197, 17);
            this.ownrisk.TabIndex = 2;
            this.ownrisk.Text = "I use this application as my own risk.";
            this.ownrisk.UseVisualStyleBackColor = true;
            this.ownrisk.CheckedChanged += new System.EventHandler(this.ownrisk_CheckedChanged);
            // 
            // githublinklabel
            // 
            this.githublinklabel.AutoSize = true;
            this.githublinklabel.Location = new System.Drawing.Point(352, 151);
            this.githublinklabel.Name = "githublinklabel";
            this.githublinklabel.Size = new System.Drawing.Size(40, 13);
            this.githublinklabel.TabIndex = 3;
            this.githublinklabel.TabStop = true;
            this.githublinklabel.Text = "GitHub";
            this.githublinklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githublinklabel_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 181);
            this.Controls.Add(this.githublinklabel);
            this.Controls.Add(this.ownrisk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_registry_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Windows 10 FPS Fix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_registry_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ownrisk;
        private System.Windows.Forms.LinkLabel githublinklabel;
    }
}

