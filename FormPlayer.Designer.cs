namespace baby_foot;

partial class FormPlayer
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        name = new TextBox();
        toolTip1 = new ToolTip(components);
        button = new Button();
        SuspendLayout();
        // 
        // name
        // 
        name.Location = new Point(216, 164);
        name.Name = "name";
        name.Size = new Size(361, 39);
        name.TabIndex = 0;
        // 
        // button
        // 
        button.Location = new Point(427, 239);
        button.Name = "button";
        button.Size = new Size(150, 46);
        button.TabIndex = 1;
        button.Text = "Ajouter";
        button.UseVisualStyleBackColor = true;
        button.Click += AddPlayer;
        // 
        // FormPlayer
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button);
        Controls.Add(name);
        Name = "FormPlayer";
        Text = "Ajout d'un joueur";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox name;
    private ToolTip toolTip1;
    private Button button;
}
