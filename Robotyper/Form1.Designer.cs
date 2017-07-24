namespace Robotyper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSettings = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelStatus = new MaterialSkin.Controls.MaterialLabel();
            this.typingProgress = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // textEditorControl1
            // 
            this.textEditorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditorControl1.IsReadOnly = false;
            this.textEditorControl1.Location = new System.Drawing.Point(12, 118);
            this.textEditorControl1.Name = "textEditorControl1";
            this.textEditorControl1.Size = new System.Drawing.Size(977, 512);
            this.textEditorControl1.TabIndex = 0;
            this.textEditorControl1.TextChanged += new System.EventHandler(this.textEditorControl1_TextChanged);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(12, 76);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(139, 36);
            this.materialRaisedButton1.TabIndex = 1;
            this.materialRaisedButton1.Text = "Simulate typing";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.AutoSize = true;
            this.btnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Depth = 0;
            this.btnSettings.Icon = null;
            this.btnSettings.Location = new System.Drawing.Point(904, 76);
            this.btnSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Primary = true;
            this.btnSettings.Size = new System.Drawing.Size(85, 36);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 640);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(159, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Estimated typing time:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(177, 640);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "0 seconds";
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Enabled = false;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(157, 76);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(140, 36);
            this.materialRaisedButton3.TabIndex = 5;
            this.materialRaisedButton3.Text = "Stop simulation";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Depth = 0;
            this.labelStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStatus.Location = new System.Drawing.Point(316, 84);
            this.labelStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 19);
            this.labelStatus.TabIndex = 6;
            // 
            // typingProgress
            // 
            this.typingProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.typingProgress.Depth = 0;
            this.typingProgress.Location = new System.Drawing.Point(741, 646);
            this.typingProgress.MouseState = MaterialSkin.MouseState.HOVER;
            this.typingProgress.Name = "typingProgress";
            this.typingProgress.Size = new System.Drawing.Size(248, 5);
            this.typingProgress.TabIndex = 7;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(758, 76);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(139, 36);
            this.materialFlatButton1.TabIndex = 8;
            this.materialFlatButton1.Text = "Visit repository";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 668);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.typingProgress);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.textEditorControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Robotyper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSettings;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialLabel labelStatus;
        private MaterialSkin.Controls.MaterialProgressBar typingProgress;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

