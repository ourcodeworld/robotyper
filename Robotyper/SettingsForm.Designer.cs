namespace Robotyper
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.btnSimulationCharacters = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSimulationWords = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtboxTypingDelay = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.txtboxStartTypingDelay = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkboxAllowBeep = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // btnSimulationCharacters
            // 
            this.btnSimulationCharacters.AutoSize = true;
            this.btnSimulationCharacters.BackColor = System.Drawing.Color.Transparent;
            this.btnSimulationCharacters.Depth = 0;
            this.btnSimulationCharacters.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnSimulationCharacters.Location = new System.Drawing.Point(180, 74);
            this.btnSimulationCharacters.Margin = new System.Windows.Forms.Padding(0);
            this.btnSimulationCharacters.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnSimulationCharacters.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSimulationCharacters.Name = "btnSimulationCharacters";
            this.btnSimulationCharacters.Ripple = true;
            this.btnSimulationCharacters.Size = new System.Drawing.Size(115, 30);
            this.btnSimulationCharacters.TabIndex = 0;
            this.btnSimulationCharacters.Text = "By Characters";
            this.btnSimulationCharacters.UseVisualStyleBackColor = false;
            this.btnSimulationCharacters.CheckedChanged += new System.EventHandler(this.btnSimulationCharacters_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 79);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(113, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Simulation type";
            // 
            // btnSimulationWords
            // 
            this.btnSimulationWords.AutoSize = true;
            this.btnSimulationWords.BackColor = System.Drawing.Color.Transparent;
            this.btnSimulationWords.Depth = 0;
            this.btnSimulationWords.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnSimulationWords.Location = new System.Drawing.Point(315, 74);
            this.btnSimulationWords.Margin = new System.Windows.Forms.Padding(0);
            this.btnSimulationWords.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnSimulationWords.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSimulationWords.Name = "btnSimulationWords";
            this.btnSimulationWords.Ripple = true;
            this.btnSimulationWords.Size = new System.Drawing.Size(87, 30);
            this.btnSimulationWords.TabIndex = 3;
            this.btnSimulationWords.Text = "By Words";
            this.btnSimulationWords.UseVisualStyleBackColor = false;
            this.btnSimulationWords.CheckedChanged += new System.EventHandler(this.btnSimulationWords_CheckedChanged);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-2, 112);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(442, 8);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(23, 134);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(127, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Typing delay (ms)";
            // 
            // txtboxTypingDelay
            // 
            this.txtboxTypingDelay.Depth = 0;
            this.txtboxTypingDelay.Hint = "";
            this.txtboxTypingDelay.Location = new System.Drawing.Point(180, 134);
            this.txtboxTypingDelay.MaxLength = 32767;
            this.txtboxTypingDelay.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxTypingDelay.Name = "txtboxTypingDelay";
            this.txtboxTypingDelay.PasswordChar = '\0';
            this.txtboxTypingDelay.SelectedText = "";
            this.txtboxTypingDelay.SelectionLength = 0;
            this.txtboxTypingDelay.SelectionStart = 0;
            this.txtboxTypingDelay.Size = new System.Drawing.Size(222, 23);
            this.txtboxTypingDelay.TabIndex = 6;
            this.txtboxTypingDelay.TabStop = false;
            this.txtboxTypingDelay.UseSystemPasswordChar = false;
            this.txtboxTypingDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxTypingDelay_KeyPress);
            this.txtboxTypingDelay.TextChanged += new System.EventHandler(this.txtboxTypingDelay_TextChanged);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-5, 181);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(442, 8);
            this.materialDivider2.TabIndex = 7;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // txtboxStartTypingDelay
            // 
            this.txtboxStartTypingDelay.Depth = 0;
            this.txtboxStartTypingDelay.Hint = "";
            this.txtboxStartTypingDelay.Location = new System.Drawing.Point(180, 209);
            this.txtboxStartTypingDelay.MaxLength = 32767;
            this.txtboxStartTypingDelay.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxStartTypingDelay.Name = "txtboxStartTypingDelay";
            this.txtboxStartTypingDelay.PasswordChar = '\0';
            this.txtboxStartTypingDelay.SelectedText = "";
            this.txtboxStartTypingDelay.SelectionLength = 0;
            this.txtboxStartTypingDelay.SelectionStart = 0;
            this.txtboxStartTypingDelay.Size = new System.Drawing.Size(222, 23);
            this.txtboxStartTypingDelay.TabIndex = 9;
            this.txtboxStartTypingDelay.TabStop = false;
            this.txtboxStartTypingDelay.UseSystemPasswordChar = false;
            this.txtboxStartTypingDelay.TextChanged += new System.EventHandler(this.txtboxStartTypingDelay_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 209);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(163, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Start Typing delay (ms)";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(-5, 250);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(442, 8);
            this.materialDivider3.TabIndex = 10;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(23, 278);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(137, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Enable Beep Sound";
            this.toolTip1.SetToolTip(this.materialLabel4, "Allow beep sound when the simulation starts and ends");
            // 
            // checkboxAllowBeep
            // 
            this.checkboxAllowBeep.AutoSize = true;
            this.checkboxAllowBeep.BackColor = System.Drawing.Color.Transparent;
            this.checkboxAllowBeep.Depth = 0;
            this.checkboxAllowBeep.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkboxAllowBeep.Location = new System.Drawing.Point(263, 274);
            this.checkboxAllowBeep.Margin = new System.Windows.Forms.Padding(0);
            this.checkboxAllowBeep.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkboxAllowBeep.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkboxAllowBeep.Name = "checkboxAllowBeep";
            this.checkboxAllowBeep.Ripple = true;
            this.checkboxAllowBeep.Size = new System.Drawing.Size(64, 30);
            this.checkboxAllowBeep.TabIndex = 12;
            this.checkboxAllowBeep.Text = "Allow";
            this.checkboxAllowBeep.UseVisualStyleBackColor = false;
            this.checkboxAllowBeep.CheckedChanged += new System.EventHandler(this.checkboxAllowBeep_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 371);
            this.Controls.Add(this.checkboxAllowBeep);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialDivider3);
            this.Controls.Add(this.txtboxStartTypingDelay);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.txtboxTypingDelay);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnSimulationWords);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnSimulationCharacters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Robotyper Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton btnSimulationCharacters;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton btnSimulationWords;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxTypingDelay;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxStartTypingDelay;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialCheckBox checkboxAllowBeep;
    }
}