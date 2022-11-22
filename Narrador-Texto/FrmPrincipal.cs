using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Narrador_Texto
{
    public partial class FormNarrar : Form
    {
        SoundPlayer _soundPlayer { get; set; } 
        public string sourceAudio { get; set; } = @"C:\Repository\AudioProjetoNarradorTexto\fala.wav";
        public FormNarrar()
        {
            InitializeComponent();
            VozeslistBox.SelectedIndex = 0;
        }

        private void FormNarrar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public async void ExecutarNarracaoButton_Click(object sender, EventArgs e)
        {
            ConvertendoTextoProgressBar.Value = 0;
            if (string.IsNullOrEmpty(ConteudoNarrarTextBox.Text.ToString()))
            {
                MessageBox.Show("Conteúdo para narração está vazio", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            timerProgressBar.Enabled = true;
            ExecutarNarracaoButton.Text = "Carregando...";
            ExecutarNarracaoButton.Enabled = false;
            var text = ConteudoNarrarTextBox.Text.ToString();
            ConveterTexto(text);
        }
        public void ConveterTexto(string text)
        {
            try
            {
                string[] array_vozes = { "pt-BR-FranciscaNeural", "pt-BR-AntonioNeural", "pt-BR-Daniel", "pt-BR-HeloisaRUS" };
                var config = SpeechConfig.FromSubscription("9a7e592ca0dc43e39174ef9b6f1f9e4f", "brazilsouth");
                config.SpeechSynthesisVoiceName = array_vozes[VozeslistBox.SelectedIndex];
                var audioConfig = AudioConfig.FromWavFileOutput(sourceAudio);
                var synthesizer = new SpeechSynthesizer(config, audioConfig);
                synthesizer.SpeakTextAsync(text);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }
        public void ExecutaAudio()
        {
            _soundPlayer = new SoundPlayer(soundLocation: sourceAudio);

         
                _soundPlayer.Play();
                ExecutarNarracaoButton.Text = "Narrando...";
                PararNarracaobutton.Visible = true;

           
        }

        private void PararNarracaobutton_Click(object sender, EventArgs e)
        {
            _soundPlayer.Stop();
            ExecutarNarracaoButton.Text = "Narrar";
            ExecutarNarracaoButton.Enabled = true;
            PararNarracaobutton.Visible = false;

        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            if (ConvertendoTextoProgressBar.Value < 100)
            {
                ConvertendoTextoProgressBar.Value = ConvertendoTextoProgressBar.Value + 10;
            }

            if (ConvertendoTextoProgressBar.Value == 100)
            {
                ExecutaAudio();
                timerProgressBar.Stop();
            }
        }
    }
}
