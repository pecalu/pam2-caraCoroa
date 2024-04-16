namespace avaliacaoPAM
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void rolarDados(object sender, EventArgs e)
        {

            Random random = new Random();
            int resultado = random.Next(0, 2);
            if (resultado == 0)
            {
                ValorSorteado.Text = "cara";
                imagemMoeda.Source = "cara.jpeg";
            }
            if (resultado == 1) 
            {
                ValorSorteado.Text = "coroa";
                imagemMoeda.Source = "coroa.jpg";
            }
            verificarMoeda();
        }                                                       
        private void verificarMoeda () 
        {
            string selectSides = Convert.ToString(SidesPicker.SelectedItem);
            string resultadoSorteado = ValorSorteado.Text;
            if (selectSides == "cara" && resultadoSorteado == "cara")
            {
                msgResult.Text = "Parabens voce acertou!";
            }
            else if (selectSides == "coroa" && resultadoSorteado == "coroa")
            {
                msgResult.Text = "Parabens voce acertou!";
            } else
            {
                msgResult.Text = "voce errou!";
            }
            
        }
    }

}
