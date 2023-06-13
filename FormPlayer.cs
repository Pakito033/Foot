namespace baby_foot;

public partial class FormPlayer : Form {
    
    public FormPlayer() {
        InitializeComponent();
    }

    private void AddPlayer(object sender, EventArgs e) {
        try {
            // Get value in textBox name and insert a new player
            string value = name.Text; // Text in textBox name
            Player player = new Player(value);
            player.Insert();
            name.Text = "";
            MessageBox.Show("Joueur" + value + " ajouté");
        } catch (Exception ex) {
            MessageBox.Show(ex.Message);
        }
    }
    
}
