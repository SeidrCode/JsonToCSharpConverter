using JsonToCSharpConverter.Engine;

namespace JsonToCSharp;

public partial class Menu : Form
{

    public Menu()
    {
        InitializeComponent();
    }

    private void TransformButton_Click(object sender, EventArgs e)
    {
        var generatedText = GeneratorExtensions.Generate(JsonTextBox.Text);
        generatedText = generatedText.Replace("\n", Environment.NewLine);
        CSharpTextBox.Text = generatedText;
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        CSharpTextBox.Text = string.Empty;
        JsonTextBox.Text = string.Empty;
    }

    private void FromFileButton_Click(object sender, EventArgs e)
    {
        openFileDialog1 = new OpenFileDialog();
        openFileDialog1.InitialDirectory = @"E:\Downloads\";
        openFileDialog1.DefaultExt = "json";
        openFileDialog1.Multiselect = false;

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            JsonTextBox.Text = File.ReadAllText(openFileDialog1.FileName);
        }
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        File.WriteAllText(Path.Combine(@"E:\Downloads\", "Template.cs"), CSharpTextBox.Text);

        MessageBox.Show("Done");
    }
}
