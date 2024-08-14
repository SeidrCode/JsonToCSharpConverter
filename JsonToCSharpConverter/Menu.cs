using JsonToCSharpConverter.Engine;

namespace JsonToCSharp;

public partial class Menu : Form
{
    private string DefaultFolderPath = @"C:\JsonToCSharpFiles\";

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
        Directory.CreateDirectory(DefaultFolderPath);

        openFileDialog1 = new OpenFileDialog();
        openFileDialog1.InitialDirectory = DefaultFolderPath;
        openFileDialog1.Filter = "json files (*.json)|*.json";
        openFileDialog1.Multiselect = false;

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            JsonTextBox.Text = File.ReadAllText(openFileDialog1.FileName);
        }
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        File.WriteAllText(Path.Combine(DefaultFolderPath, "Template.cs"), CSharpTextBox.Text);

        MessageBox.Show($"The file 'Template.cs' was successfully saved to the '{DefaultFolderPath}' folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
